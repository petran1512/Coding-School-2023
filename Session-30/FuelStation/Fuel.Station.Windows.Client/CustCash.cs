using Fuel.Station.Blazor.Shared;
using Fuel.Station.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Controls;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace Fuel.Station.Windows.Client
{
    public partial class CustCash : Form
    {
        private readonly HttpClient client;

        public CustCash()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private async Task SetControlProperties()
        {
            customerBindingSource.DataSource = await GetCustomers();
            grvCustomers.DataSource = customerBindingSource;
        }

        private async Task<List<CustomerListDto?>> GetCustomers()
        {
            var response = await client.GetFromJsonAsync<List<CustomerListDto?>>("customer");
            return response.ToList();
        }

        private void grvCustomers_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void CustCash_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cashier().Show();
            this.Close();
        }

        //REQUEST METHODS
        private async Task NewCustomer(CustomerListDto? customer)
        {
            var response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Please try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        private async Task EditCustomer(CustomerListDto? customer)
        {

            var response = await client.PutAsJsonAsync("customer", customer);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Please try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        private async Task DeleteCustomer(int id)
        {
            var response = await client.DeleteAsync($"customer/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Please try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        private void gridView1_DeleteRow(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null)
            {
                CustomerListDto? customer = view.GetFocusedRow() as CustomerListDto;
                _ = DeleteCustomer(customer.Id);
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //gridView testers
            //int focusedRowHandle = gridView1.FocusedRowHandle;
            //object focusedRowData = gridView1.GetFocusedRow();
            //DataGridViewRow selectedRow = gridView1.CurrentRow;
            //MyDataObject dataObject = (MyDataObject)selectedRow.DataBoundItem;



            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null)
            {
                CustomerListDto? customer = view.GetFocusedRow() as CustomerListDto;
                if (customer.Id == 0)
                {
                    _ = NewCustomer(customer);
                }
                else
                {
                    _ = EditCustomer(customer);
                }

            }
        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
