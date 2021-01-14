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
            int eingabepuffergroesse = Convert.ToInt32(numeric_puffergroesse.Value);
            fp.Puffergroesse = eingabepuffergroesse;
        }

        private void put_btn_Click(object sender, EventArgs e)
        {
           try
           {
                int zahlen = Convert.ToInt32(eingabezah.Text);
                fp.Put(zahlen);
           }
           catch (Exception ex)
           {
                MessageBox.Show("Fehler: " + ex.Message);
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ausgabe_txt.Text = "";
            ausgabe_txt.Text = fp.Get(ausgabe_txt.Text);
            

        }
    }
}
