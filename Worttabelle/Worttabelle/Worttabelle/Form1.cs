using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worttabelle
{
    public partial class Form1 : Form
    {
        WordTab wt = new WordTab();
        public Form1()
        {
            InitializeComponent();
        }

        private void woerter_btn_Click(object sender, EventArgs e)
        {
            wt.Woerter = woerter_txt.Text;

        }
    }
}
