using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenPlaner
{
    public partial class Form1 : Form
    {
        Task taskitem = new Task();
        TaskState state;
        public Form1()
        {
            InitializeComponent();
            state_combobox.Items.Add(new TaskState("Todo"));
            state_combobox.Items.Add(new TaskState("InProgress"));
            state_combobox.Items.Add(new TaskState("Done"));
            state_combobox.Items.Add(new TaskState("Archived"));
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            titel_txtbox.Text = taskitem.Titel;
            note_txtbox.Text = taskitem.Beschreibung;
            date_datetimepicker.Value = taskitem.DueDate;
            isarchived_radiobtn.Checked = taskitem.IsArchived;

        }
    }
}
