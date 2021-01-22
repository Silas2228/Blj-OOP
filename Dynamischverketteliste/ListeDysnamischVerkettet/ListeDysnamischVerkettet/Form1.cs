using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeDysnamischVerkettet
{
    public partial class Form1 : Form
    {
        ZahlenSpeicher zs = new ZahlenSpeicher();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(userzahl_txt.Text))
            {
                MessageBox.Show("Bitte eine Zahl eingeben!");
            }
            else
            {
                try
                {
                    zs.Add(Convert.ToInt32(userzahl_txt.Text));
                    userzahl_txt.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void Get_btn_Click(object sender, EventArgs e)
        {
           if(Ascending_radio_btn.Checked == true)
           {
                SortOrder order = SortOrder.Ascending;
                output_txt.Text = zs.Get((ZahlenSpeicher.SortOrder)order);
           }
           else
           {
                SortOrder order = SortOrder.Descending;
                output_txt.Text =  zs.Get((ZahlenSpeicher.SortOrder)order);
           }
            
        }
    }
}
