using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instanzenzähler
{
    public partial class Form1 : Form
    {
        C instance = new C();
        public Form1()
        {
            InitializeComponent();
        }

        private void Createinstance_btn_Click(object sender, EventArgs e)
        {
            counterinstance.Text = "0";
            counterinstance.Text = C.CreateInstance().ToString();
        }

        private void Resetinstance_btn_Click(object sender, EventArgs e)
        {
            counterinstance.Text = C.ResetInstance().ToString();
        }
    }
}
