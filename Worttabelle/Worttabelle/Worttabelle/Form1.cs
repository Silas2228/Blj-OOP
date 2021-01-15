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
        Parser ps = new Parser();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void words_btn_Click(object sender, EventArgs e)
        {
            ps.Parse(userinput_txt.Text);
            output_txt.Text = wt.PrintTab();
        }
    }
}
