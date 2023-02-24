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
    public partial class Customer : Form
    {
        private readonly HttpClient client;

        public Customer()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            customerBindingSource.DataSource = await GetCustomers();
            grvCustomers.DataSource = customerBindingSource;
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

        private async Task<List<CustomerListDto?>> GetCustomers()
        {
            var response = await client.GetFromJsonAsync<List<CustomerListDto?>>("customer");
            return response.ToList();   
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
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

        private void gridView1_DeleteRow(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null)
            {
                CustomerListDto? customer = view.GetFocusedRow() as CustomerListDto;
                _ = DeleteCustomer(customer.Id);
            }
        }

        //POST REQUEST
        private async Task NewCustomer(CustomerListDto? customer)
        {
            var response = await client.PostAsJsonAsync("customer", customer);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        //PUT REQUEST
        private async Task EditCustomer(CustomerListDto? customer)
        {

            var response = await client.PutAsJsonAsync("customer", customer);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }

        //DELETE REQUEST
        private async Task DeleteCustomer(int id)
        {
            var response = await client.DeleteAsync($"customer/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Try again.", "Alert Message");
                _ = SetControlProperties();
            }
        }
    }
}
