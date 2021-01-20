using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Simulator
{
    public partial class Form1 : Form
    {
        Auto Auto = new Auto();
        public Form1()
        {
            InitializeComponent();
            comboBoxAutos.Items.Add("Porsche 250 Ps");
            comboBoxAutos.Items.Add("Opel 90 Ps");
            comboBoxAutos.Items.Add("Ferrari 370 Ps");
        }

        private void Gas_btn_Click(object sender, EventArgs e)
        {

          while(true)
          {
                Auto.GibGas();
                gas_txt.Text = Auto.AktuelleGeschwindigkeit.ToString();
                Application.DoEvents();
          }
 
        }

        private void Bremsen_btn_Click(object sender, EventArgs e)
        {
            Auto.Bremse();
            Application.DoEvents();
        }

        private void Hupe_btn_Click(object sender, EventArgs e)
        {
            Auto.Hupe();
        }

        private void MotorStarten_btn_Click(object sender, EventArgs e)
        {
            bool starten = true;
            Auto.StarteMotor(starten);
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string auto;
            auto = comboBoxAutos.Text;
            Auto.Marke = auto;
        }
    }
}
