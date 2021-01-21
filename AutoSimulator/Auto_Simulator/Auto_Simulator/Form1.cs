using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Auto_Simulator
{
    public partial class Form1 : Form
    {
        Auto car;
        public Form1()
        {
            InitializeComponent();
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));
        }

        private void Gas_btn_Click(object sender, EventArgs e)
        {

          while(true)
          {
                car.GibGas();
                car.GangSchaltung();
                Thread.Sleep(150);
                gas_txt.Text = car.AktuelleGeschwindigkeit.ToString();
                label3.Text = car.Gang.ToString();
                Application.DoEvents();
                
          }
            
        }

        private void Hupe_btn_Click(object sender, EventArgs e)
        {
            car.Hupe();
        }

        private void MotorStarten_btn_Click(object sender, EventArgs e)
        {
            bool starten = true;
            label2.BackColor = System.Drawing.Color.Green;
            try
            {
                    car.StarteMotor(starten);   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            
        }
        private void FarbeMotor()
        {
            label2.BackColor = System.Drawing.Color.Black;
        }
        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            car = comboBoxAutos.SelectedItem as Auto;

        }


        private void Bremsen_btn_MouseHover(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    car.Bremse();
                    Thread.Sleep(150);
                    Application.DoEvents();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }
    }
}
