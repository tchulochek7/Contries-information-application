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
using System.Net.Http.Headers;
using CountiesInformationClient.Models;
using Newtonsoft.Json;


namespace DatabaseClient
{
    public partial class CountryForm : Form
    {
        private HttpClient client;
        private HttpClient clientCI;

        private CountryInformation countryFromAPI;

        private APIConnecter apiConnecter;
        private APIConnecterCI apiConnecterCI;

        public CountryForm()
        {
            InitializeComponent();

            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44380/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            clientCI = new HttpClient();
            clientCI.BaseAddress = new Uri("https://restcountries.eu/");
            clientCI.DefaultRequestHeaders.Accept.Clear();
            clientCI.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            apiConnecter = new APIConnecter(client);
            apiConnecterCI = new APIConnecterCI(clientCI);
        }

        private void buttonGetInf_Click(object sender, EventArgs e)
        {
            if (textBoxCountryName.Text != null)
            {          
                countryFromAPI = apiConnecterCI.GetCountryInformation(textBoxCountryName.Text);

                if (countryFromAPI != null)
                {
                    FillFormFields();
                    AddCountryToDatabase();
                }
                else
                {
                    MessageBox.Show("Country information not found!");
                }
            }
        }

        private void FillFormFields()
        {
            textBoxName.Text = countryFromAPI.Title;
            textBoxCode.Text = countryFromAPI.Code;
            textBoxCapital.Text = countryFromAPI.Capital;
            textBoxArea.Text = countryFromAPI.Area.ToString();
            textBoxPopulation.Text = countryFromAPI.Population.ToString();
            textBoxRegion.Text = countryFromAPI.Region;
        }


        private void AddCountryToDatabase()
        {
            DialogResult dialogResult = MessageBox.Show("Add information to database Countries?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               string message = apiConnecter.AddCountryInformation(countryFromAPI);
               MessageBox.Show(message);
            }
        }

        private void CountryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
            {
                client.Dispose();
            }

            if (clientCI != null)
            {
                clientCI.Dispose();
            }
        }
    }
}
