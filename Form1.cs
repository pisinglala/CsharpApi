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


namespace CsharpApi
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/escotaAPI.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                var venue = JsonConvert.DeserializeObject<List<Venue>>(responseBody);

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = venue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var concertData = new { concert_name = concertTxtbox.Text, venue_location = locationTxtbox.Text, capacity = capacityTxtbox.Text };
            string json = JsonConvert.SerializeObject(concertData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/escotaAPI.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var venue = JsonConvert.DeserializeObject<Venue>(responseBody);

                btnGet_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public class Venue
        {
            public int venue_id { get; set; }
            public string concert_name { get; set; }
            public string venue_location { get; set; }
            public int capacity { get; set; }
        }

        private void transactionsForm_Click(object sender, EventArgs e)
        {
            var transactionsForm = new transactions();
            this.Hide();
            transactionsForm.Show();
        }
    }
}
