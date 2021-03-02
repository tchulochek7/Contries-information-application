using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountiesInformationClient.Models;
using Newtonsoft.Json;
using System.Data;

namespace DatabaseClient
{
    public partial class DbCountriesForm : Form
    {
        private HttpClient client;
        private APIConnecter apiConnecter;

        public DbCountriesForm()
        {
            InitializeComponent();

            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44380/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            apiConnecter = new APIConnecter(client);
        }

        private void GetAllCountries()
        {
            List<Country> listCountries = Task.Run(() => apiConnecter.GetAllCountriesAsync()).Result;
            if (listCountries != null)
            {
                dataGridViewCountries.DataSource = ListToDataSet(listCountries);
            }
        }

        private DataTable ListToDataSet(List<Country> listCountries)
        {
            DataTable tableCountries = CreateDataTable();

            foreach (var classCountry in listCountries)
            {
                IEnumerable<Country> iEClassCountry = new[] { classCountry };
 
                foreach (Country country in iEClassCountry)
                {
                    DataRow dataRow = tableCountries.Rows.Add();
                    FillDataRow(dataRow, country);
                }
            }

            return tableCountries;
        }

        private DataTable CreateDataTable()
        {
            DataTable tableCountries = new DataTable();
            tableCountries.Columns.Add("Id");
            tableCountries.Columns.Add("Name");
            tableCountries.Columns.Add("CountryCode");
            tableCountries.Columns.Add("Capital");
            tableCountries.Columns.Add("Area");
            tableCountries.Columns.Add("Population");
            tableCountries.Columns.Add("Region");

            return tableCountries;
        }

        private void FillDataRow (DataRow dataRow, Country country)
        {
            dataRow.SetField("Id", country.Id);
            dataRow.SetField("Name", country.Title);
            dataRow.SetField("CountryCode", country.Code);
            dataRow.SetField("Capital", country.Capital.Title);
            dataRow.SetField("Area", country.Area);
            dataRow.SetField("Population", country.Population);
            dataRow.SetField("Region", country.Region.Title);
        }

        private void DbCountriesForm_Load(object sender, EventArgs e)
        {
            GetAllCountries();
        }

        private void DbCountriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (client != null)
            {
                client.Dispose();
            }
        }
    }
}
