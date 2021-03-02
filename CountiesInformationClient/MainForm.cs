using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSectionGetInf_Click(object sender, EventArgs e)
        {
            using (CountryForm countryForm = new CountryForm())
            {
                DialogResult result = countryForm.ShowDialog(this);
            }
        }

        private void buttonSectionOpenDCountries_Click(object sender, EventArgs e)
        {
            using (DbCountriesForm dBCountryForm = new DbCountriesForm())
            {
                DialogResult result = dBCountryForm.ShowDialog(this);
            }
        }
    }
}
