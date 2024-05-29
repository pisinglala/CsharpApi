using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using static CsharpApi.Form1;

namespace CsharpApi
{
    public partial class transactions : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public transactions()
        {
            InitializeComponent();
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/escotaTransactions.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var transactions = JsonConvert.DeserializeObject<List<Transaction>>(responseBody);

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = transactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public class Transaction
        {
            public int transaction_id { get; set; }
            public string concert_name { get; set; }
            public string concert_date { get; set; }
            public int ticket_price { get; set; }
            public string purchase_date { get; set; }

        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            var transactionData = new { concert_name = concertTxtbox.Text, ticket_price = priceTxtbox.Text,
                concert_date = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
            };
            string json = JsonConvert.SerializeObject(transactionData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/escotaTransactions.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var transactions = JsonConvert.DeserializeObject<Transaction>(responseBody);

                getBtn_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
