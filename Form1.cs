using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konverter_valuta
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> tecajevi = new Dictionary<string, double>()
            {
                { "EUR", 7.54},
                { "USD", 6.13},
                { "HRK", 1 },
                {"RUS", 12.53 }
            };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPretvori_Click(object sender, EventArgs e)
        {
            try
            {
            double iznos = double.Parse(txtIznos.Text);
            string valuta = cmbValuta.SelectedItem.ToString();
            double tecaj = tecajevi[valuta];
            double rezultat = Math.Round(iznos * tecaj, 2);
            lblRezultat.Text = rezultat.ToString() + " HRK";
            }
            catch(FormatException)
            {
                MessageBox.Show("Iznos mora biti broj");
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show("Nepoznata valuta");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string valuta in tecajevi.Keys)
            {
                cmbValuta.Items.Add(valuta);
            }

            cmbValuta.SelectedIndex = 0;
        }
    }
}
