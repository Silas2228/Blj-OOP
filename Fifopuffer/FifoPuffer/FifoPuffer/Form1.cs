using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifoPuffer
{
    public partial class Form1 : Form
    {
        FifoPuffer fp = new FifoPuffer();
        public Form1()
        {
            InitializeComponent();
        }

        private void puffererstellen_btn_Click(object sender, EventArgs e)
        {
            int eingabepuffergroesse = 0; 
            eingabepuffergroesse = Convert.ToInt32(numeric_puffergroesse.Value);
            
            fp.Puffergroesse = eingabepuffergroesse;
        }

        private void put_btn_Click(object sender, EventArgs e)
        {
           try
           {
                string[] zahlena;
                zahlena = new string[fp.Puffergroesse];
                zahlena = new string[] {eingabezah.Text };
                fp.Put(zahlena);
           }
           catch (Exception ex)
           {
                MessageBox.Show("Fehler: " + ex.Message);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ausgabe_txt.Text = "";
            fp.Get();
            foreach (String item in fp.Ausgabe)
            {
                ausgabe_txt.Text += item + ",";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ausgabe_txt.Clear();
        }
    }
}
