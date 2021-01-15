using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WortTabelle
{
    public partial class Form1 : Form
    {
        WortTab wt = new WortTab();
  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void words_btn_Click(object sender, EventArgs e)
        {

            WortTab wt = new WortTab();
            Parser ps = new Parser(wt);
            ps.Parse(userinput_txt.Text);

            output_txt.Text = wt.GetTab();
            //wt.PrintTab(output_txt);
        }
    }
}
