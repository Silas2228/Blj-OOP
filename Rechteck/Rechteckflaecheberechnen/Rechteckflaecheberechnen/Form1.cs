using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechteckflaecheberechnen
{
    public partial class Form1 : Form
    {
        Rechteck rt = new Rechteck();

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Berechnen_Click(object sender, EventArgs e)
        {
            double hoehe = Convert.ToDouble(hoehe_txt.Text);
            double breite = Convert.ToDouble(breite_txt.Text);
            rt.berechnenflaeche(hoehe, breite);
            flaeche_txt.Text = rt.Fleache.ToString();

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
