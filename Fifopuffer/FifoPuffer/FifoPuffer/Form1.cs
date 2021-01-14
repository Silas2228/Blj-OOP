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
            int b = 0;
            b++;
            
            string eingabezahlen = Convert.ToString(eingabezah);
            if (string.IsNullOrEmpty(eingabezahlen))
            {
                MessageBox.Show("Die Zahl konnte nicht in den Puffer gelegt werden.");
            }
            else 
            {
                try
                {
                    fp.Put(eingabezahlen, b);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Fehler" + ex.Message);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ausgabe_txt.Text = "";
            if(fp.Eingabe != null)
            {
                foreach (string num in fp.Eingabe)
                {
                    ausgabe_txt.Text += num + ",";
                } 
            }
            else
            {
                MessageBox.Show("Der Puffer ist leer");
            }

        }
    }
}
