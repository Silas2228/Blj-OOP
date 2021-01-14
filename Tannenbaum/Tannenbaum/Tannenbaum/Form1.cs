using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        Tanne t = new Tanne();
        public Form1()
        {
            InitializeComponent();
        }

        private void zeichnen_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int stammbreitetxt = Convert.ToInt32(stammbreite_txt.Text);
                int stammhoehetxt = Convert.ToInt32(stammhoehe_txt.Text);
                int kronenhoehetxt = Convert.ToInt32(kronenhoehe_txt.Text);

                if(stammbreitetxt != 0 || stammhoehetxt != 0 || kronenhoehetxt != 0)
                { 
                    t.Stammbreite = stammbreitetxt;
                    t.Stammhoehe = stammhoehetxt;
                    t.Kronenhoehe = kronenhoehetxt;
                    t.Zeichnen();
                    Zeichnung_txt.Text = t.Zeichnung; 
                }
                else
                {
                    MessageBox.Show("Der Wert darf nicht bei 0 liegen.");
                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
