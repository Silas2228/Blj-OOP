using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReisezeitErdeMond
{
    public partial class Form1 : Form
    {
        Reisedauer rs = new Reisedauer();
        public Form1()
        {
            InitializeComponent();
        }

        private void berechnen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(geschwindigkeit_txt.Text == "" || geschwindigkeit_txt.Text == "0")
                {
                    MessageBox.Show("Bitte geben Sie eine Zahl ein!");
                }
                else
                {
                    if (radio_btn_stunden.Checked == true)
                    {
                        double usergeschwindigkeit = Convert.ToDouble(geschwindigkeit_txt.Text);
                        rs.BerechneDauer(usergeschwindigkeit);
                        ausgabe_txt.Text = rs.Zeit.ToString();
                    }
                    else if (radio_btn_tagen.Checked == true)
                    {
                        double usergeschwindigkeit = Convert.ToDouble(geschwindigkeit_txt.Text);
                        rs.BerechneDauer(usergeschwindigkeit);
                        rs.Zeit = rs.Zeit / 24;
                        ausgabe_txt.Text = rs.Zeit.ToString();
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Bitte geben Sie eine Zahl ein.");
            }

        }
    }
}
