using DevExpress.XtraGrid.Views.Grid;
using Fuel.Station.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel.Station.Windows.Client
{
    public partial class ItStaff : Form
    {
        private readonly HttpClient client;

        public ItStaff()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7095/");
        }

        private async Task<List<ItemListDto?>> GetItems()
        {
            var response = await client.GetFromJsonAsync<List<ItemListDto?>>("item");
            return response.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Staff().Show();
            this.Close();
        }

        private void grvItems_Click(object sender, EventArgs e)
        {

        }

        private void tabControlMain_Click(object sender, EventArgs e)
        {

        }

        private void ItStaff_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();

        }

        //REQUEST METHODS
        private async Task NewItem(ItemListDto? item)
        {
            var response = await client.PostAsJsonAsync("item", item);
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

        private async Task EditItem(ItemListDto? item)
        {

            var response = await client.PutAsJsonAsync("item", item);

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

        private async Task DeleteItem(int id)
        {
            var response = await client.DeleteAsync($"item/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Success!", "Success Message");
            }
            else
            {
                MessageBox.Show("Error! Please try again..", "Alert Message");
                _ = SetControlProperties();
            }
        }

        private async Task SetControlProperties()
        {
            itemBindingSource.DataSource = await GetItems();
            grvItems.DataSource = itemBindingSource;
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null)
            {
                ItemListDto? item = view.GetFocusedRow() as ItemListDto;
                _ = DeleteItem(item.Id);
            }
        }

        private void gridView1_ValidatingRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView? view = sender as GridView;
            if (view.GetFocusedRow != null)
            {
                ItemListDto? item = view.GetFocusedRow() as ItemListDto;
                if (item.Id == 0)
                {
                    _ = NewItem(item);
                }
                else
                {
                    _ = EditItem(item);
                }
            }
        }
    }
}
