using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace BongoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetBongoData();
        }

        public async void GetBongoData()
        {
            HttpClient client = new HttpClient();
            var uri = new Uri(@"http://api.ebongo.org/routelist?format=json&api_key=XXXX");
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                asdfasdfasdf.Text = content;
            }
        }
    }
}
