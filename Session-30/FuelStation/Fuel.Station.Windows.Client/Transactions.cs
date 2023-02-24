using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using FuelStation.Model.Enums;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;
using System.Windows.Documents;


namespace Fuel.Station.Windows.Client
{
    public partial class Transactions : Form
    {
        private readonly HttpClient client;
        private CustomerListDto _customer;
        private List<ItemListDto?>? _items;

        //public Transactions()
        //{
        //    InitializeComponent();
        //    client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:7095/");
        //}

        public Transactions(CustomerListDto customer)
        {
            InitializeComponent();
            _customer = customer;
            //labelCustomer.Text = $"{_customer.Name} {_customer.Surname}'s Transactions (Card Number: {_customer.CardNumber})";
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            var transactions = await GetTransactions(_customer.Id);
            if (transactions != null)
            {
                transactionBindingSource.DataSource = transactions;

                transactionlineBindingSource.DataSource = transactionBindingSource;
                transactionlineBindingSource.DataMember = "TransactionLines";

                grvTransactions.DataSource = transactionBindingSource;
                grvTransactionLines.DataSource = transactionlineBindingSource;

                var employees = await GetEmployees();
                bsItemTypes.DataSource = employees;
                repEmployees.DataSource = bsItemTypes;
                repEmployees.DisplayMember = "Surname";
                repEmployees.ValueMember = "Id";

                _items = await GetItems();
                bsItems.DataSource = _items;
                repItemTree.DataSource = bsItems;
                repItemTree.DisplayMember = "Description";
                repItemTree.ValueMember = "Id";

                if (_items != null) SetListBoxProperties();
            }
        }
        // transactionBindingSource.DataSource = await GetTransactions();
        //grvTransactions.DataSource = transactionBindingSource;

        //transactionlineBindingSource.DataSource = await GetTransactionLines();
        //grvTransactionLines.DataSource = transactionlineBindingSource;

        // SET COMBOBOXES OF ITEMS
        private void SetListBoxProperties()
        {
            if (_items != null)
            {
                repItemTree.DataSource = _items;
                repItemTree.DisplayMember = "Description";
                repItemTree.ValueMember = "Id";

                List<ItemType> itemTypeList = Enum.GetValues(typeof(ItemType)).Cast<ItemType>().ToList();

                bsItemTypes.DataSource = itemTypeList;
                comboItems.DataSource = bsItemTypes;
                comboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        // SET LISTBOX WHEN CHANGE COMBO VALUE
        private void comboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboItems.SelectedItem != null)
            {
                listItems.DataSource = null;
                var selectedItemType = (ItemType)comboItems.SelectedItem;

                var itemList = _items.Where(item => item != null && item.itemType == selectedItemType).ToList();
                listItems.DataSource = itemList;
                listItems.DisplayMember = "Description";
                listItems.ValueMember = "Id";
            }
        }

        // ADD NEW TRANSACTION LINE
        private void AddNewTransactionLine(int qty)
        {
            ItemListDto? item = listItems.SelectedItem as ItemListDto;

            if (item.itemType != ItemType.Fuel || !SecondFuelExist())
            {

                GridView? gridView = grvTransactions.FocusedView as GridView;
                if (gridView != null)
                {
                    if (item != null)
                    {
                        TransactionLineEditDto newTempTL = new();
                        newTempTL.ItemId = item.Id;
                        newTempTL.Quantity = qty;
                        newTempTL.ItemPrice = item.Price;
                        newTempTL.NetValue = newTempTL.ItemPrice * newTempTL.Quantity;

                        if (item.itemType == ItemType.Fuel && newTempTL.NetValue > 20) newTempTL.DiscountPercent = 10;
                        else newTempTL.DiscountPercent = 0;

                        newTempTL.DiscountValue = (newTempTL.NetValue * newTempTL.DiscountPercent) / 100;
                        newTempTL.TotalValue = newTempTL.NetValue - newTempTL.DiscountValue;

                        var transaction = gridView.GetRow(gridView.FocusedRowHandle) as TransactionListDto;
                        if (transaction != null) newTempTL.TransactionId = transaction.Id;

                        newTempTL.Item = item;
                        transactionlineBindingSource.Add(newTempTL);
                        CalculateTotalValue();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fuel type already exists.", "Error");
            }

        }

        public string MessageGet(string message, string title)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox(message, title);
            return userInput;
        }

        // ADD NEW TRANSACTION
        private void AddNewTransaction()
        {
            TransactionListDto newTempTransaction = new();
            newTempTransaction.CustomerId = _customer.Id;
            newTempTransaction.TotalValue = 0;
            transactionBindingSource.Add(newTempTransaction);
            CalculateTotalValue();
        }

        //CHECKS IF UNSAVED TRANSACTION
        private bool IsNotPosted()
        {
            var isNotPosted = false;
            GridView? gridViewTransactions = grvTransactions.FocusedView as GridView;

            if (gridViewTransactions != null)
            {
                for (int i = 0; i < gridViewTransactions.RowCount; i++)
                {
                    var row = (TransactionListDto)gridViewTransactions.GetRow(i);
                    if (row.Id == 0)
                    {

                        MessageBox.Show("An unsaved transaction already exists.", "Alert");
                        isNotPosted = true;
                    }
                }
            }
            return isNotPosted;
        }

        // CHECK DATASOURCE FOR SECOND FUEL
        private bool SecondFuelExist()
        {
            bool foundFuelItem = false;
            GridView? gridViewTL = grvTransactionLines.FocusedView as GridView;

            if (gridViewTL != null)
            {
                for (int i = 0; i < gridViewTL.RowCount; i++)
                {
                    TransactionLineEditDto? transactionLine = gridViewTL.GetRow(i) as TransactionLineEditDto;
                    if (transactionLine != null && transactionLine.Item.itemType == ItemType.Fuel)
                    {
                        foundFuelItem = true;
                        break;
                    }
                }
            }
            return foundFuelItem;
        }


        // DELETE TRANSACTIONSLINE METHOD
        private void TransactionLineDeleting()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                TransactionLineEditDto transactionLine = (TransactionLineEditDto)gridView1.GetFocusedRow();

                if (transactionLine != null && transactionLine.Id > 0)
                {
                    try { _ = DeleteTransactionLine(transactionLine.Id); }
                    catch { MessageBox.Show("Error deleting.", "Error"); }
                    CalculateTotalValue();

                }
                else if (transactionLine != null && transactionLine.Id == 0)
                {
                    transactionlineBindingSource.Remove(transactionLine);
                    CalculateTotalValue();
                }
                else MessageBox.Show("Item not found. Try again", "Alert");
            }
        }

        // DELETE TRANSACTION METHOD
        private void TransactionsDeleting()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                TransactionListDto transaction = (TransactionListDto)gridView1.GetFocusedRow();

                if (transaction != null)
                {
                    if (transaction.Id > 0)
                    {
                        try { _ = DeleteTransaction(transaction.Id); }
                        catch { MessageBox.Show("Error deleting.", "Error"); }
                        _ = SetControlProperties();

                    }
                    else if (transaction.Id == 0)
                    {
                        transactionBindingSource.Remove(transaction);
                        _ = SetControlProperties();
                    }
                    else MessageBox.Show("Item not found. Try again", "Alert");
                }
                //_ = SetTransactionsControlProperties();
            }
        }

        // SAVE TRANSACTION METHOD
        private void TransactionsSaving()
        {
            if (gridView1.FocusedRowHandle >= 0)
            {
                TransactionListDto transaction = (TransactionListDto)gridView1.GetFocusedRow();

                if (transaction != null)
                {
                    //transaction.TransactionLines = null;
                    if (transaction.Id > 0)
                    {
                        _ = EditTransaction(transaction);
                        //SAVE TLINES
                    }
                    else if (transaction.Id == 0)
                    {
                        _ = NewTransaction(transaction);
                        //SAVE TLINES
                    }
                    else MessageBox.Show("Nothing to save.", "Message");
                }
                _ = SetControlProperties();
            }
        }

        // CALCULATE TOTAL VALUE FOR TRANSACTION
        public void CalculateTotalValue()
        {
            GridView? gridViewTL = grvTransactionLines.FocusedView as GridView;
            decimal totalValue = 0;
            if (gridViewTL != null)
            {
                for (int i = 0; i < gridViewTL.RowCount; i++)
                {
                    TransactionLineEditDto? transactionLine = gridViewTL.GetRow(i) as TransactionLineEditDto;
                    totalValue += transactionLine?.TotalValue ?? 0;
                }
            }
            var gridView = grvTransactions.FocusedView as GridView;
            if (gridView != null)
            {
                gridView.SetRowCellValue(gridView.FocusedRowHandle, "TotalValue", totalValue);
                if (totalValue > 50) gridView.SetRowCellValue(gridView.FocusedRowHandle, "PaymentMethod", PaymentMethod.Cash);
            }

        }

        // CELL VALUE CHANGE IF TOTAL VALUE IS 50 OR MORE 
        private void gridView5_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "PaymentMethod")
            {
                string? selectedPaymentMethod = Convert.ToString(e.Value);
                decimal totalValue = Convert.ToDecimal(gridView1.GetRowCellValue(e.RowHandle, "TotalValue"));

                if (totalValue > 50 && selectedPaymentMethod != "Cash")
                {
                    MessageBox.Show("TotalValue is above 50, only Cash payment is accepted.", "Alert");
                    gridView1.SetRowCellValue(e.RowHandle, "PaymentMethod", "Cash");
                }
            }
        }



        private async Task<List<TransactionListDto?>> GetTransactions()
        {
            var response = await client.GetFromJsonAsync<List<TransactionListDto?>>("transaction");
            return response.ToList();
        }

        private async Task<List<TransactionLineListDto?>> GetTransactionLines()
        {
            var response = await client.GetFromJsonAsync<List<TransactionLineListDto?>>("transactionline");
            return response.ToList();
        }

        private void grvTransactions_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        /************REQUESTS*************/
        // GET REQUEST TRANSACTIONS
        private async Task<List<TransactionListDto>> GetTransactions(int id)
        {
            var response = await client.GetAsync($"transaction/customer/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        // POST REQUEST ADD TRANSACTION
        private async Task NewTransaction(TransactionListDto? transaction)
        {
            var response = await client.PostAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
            }
        }

        // PUT REQUEST EDIT TRANSACTION
        private async Task EditTransaction(TransactionListDto? transaction)
        {

            var response = await client.PutAsJsonAsync("transaction", transaction);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
            }
        }

        // DELETE REQUEST DELETE TRANSACTION
        private async Task DeleteTransaction(int id)
        {
            var response = await client.DeleteAsync($"transaction/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
            }
        }

        // DELETE REQUEST DELETE TRANSACTIONLine
        private async Task DeleteTransactionLine(int id)
        {
            var response = await client.DeleteAsync($"transactionline/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deleted!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
            }
        }

        // GET REQUEST EMPLOYEES
        private async Task<List<EmployeeListDto?>> GetEmployees()
        {
            var response = await client.GetAsync("employee");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto?>>(content);
            }
            return null;
        }

        // GET REQUEST ITEMS
        private async Task<List<ItemListDto?>> GetItems()
        {
            var response = await client.GetAsync("item");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto?>>(content);
            }
            return null;
        }

        private void comboItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboItems.SelectedItem != null)
            {
                listItems.DataSource = null;
                var selectedItemType = (ItemType)comboItems.SelectedItem;

                var itemList = _items.Where(item => item != null && item.itemType == selectedItemType).ToList();
                listItems.DataSource = itemList;
                listItems.DisplayMember = "Description";
                listItems.ValueMember = "Id";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qty = 0;
            string userInput = MessageGet("Enter item quantity:", "Quantity");
            if (!Int32.TryParse(userInput, out qty)) MessageBox.Show("Error, try again with number.", "Error");
            else if (qty <= 0) MessageBox.Show("Error, try again with number above 0.", "Error");
            else AddNewTransactionLine(qty);

        }
    }
}

