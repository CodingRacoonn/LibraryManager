using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingForms
{
    public partial class Form1 : Form
    {
        private HttpClient _apiClient;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InitializeClient();
            await TestGet();
            //await TestPost();
        }


        private void InitializeClient()
        {
            string api = "https://localhost:44354";

            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task TestPost()
        {
            UserModel model = new UserModel {Id = "xd", FirstName = "Jam", LastName ="JestKazam", CreatedDate = DateTime.Now, EmailAddress = "bubu@bobob.pl"};
            //tworzy anonimowy obiekt i tworzy właściwości wstawionego typu
            //var data = new { model };

            using (HttpResponseMessage response = await _apiClient.PostAsJsonAsync("/api/user/adduser", model)) 
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task TestGet()
        {

            using (HttpResponseMessage response = await _apiClient.GetAsync("/api/user/hello"))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
