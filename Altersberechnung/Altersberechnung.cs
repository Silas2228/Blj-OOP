using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alterberechnung
{
    public partial class Form1 : Form
    {
        Alter ar = new Alter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Alterberechnen_btn_Click(object sender, EventArgs e)
        {
            DateTime userbirthdaydatetimepicker = userbirthday.Value;
            ar.AterBerechnen(userbirthdaydatetimepicker);
            
            if (radio_jahre.Checked == true)
            {
                age_txtbox.Text = ar.Year.ToString();
            }
            else if(radio_Monate.Checked == true)
            {
                age_txtbox.Text = ar.Month.ToString();
            }
            else if(radio_wochen.Checked == true)
            {
                age_txtbox.Text = ar.Weeks.ToString();
            }
            else if(radio_tage.Checked == true)
            {
                age_txtbox.Text = ar.Days.ToString();
            }


        }
    }
}
