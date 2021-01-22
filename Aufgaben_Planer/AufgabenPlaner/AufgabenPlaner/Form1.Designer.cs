namespace AufgabenPlaner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titel_txtbox = new System.Windows.Forms.TextBox();
            this.note_txtbox = new System.Windows.Forms.TextBox();
            this.date_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isarchived_radiobtn = new System.Windows.Forms.RadioButton();
            this.state_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titel_txtbox
            // 
            this.titel_txtbox.Location = new System.Drawing.Point(12, 51);
            this.titel_txtbox.Name = "titel_txtbox";
            this.titel_txtbox.Size = new System.Drawing.Size(122, 20);
            this.titel_txtbox.TabIndex = 0;
            // 
            // note_txtbox
            // 
            this.note_txtbox.Location = new System.Drawing.Point(12, 99);
            this.note_txtbox.Name = "note_txtbox";
            this.note_txtbox.Size = new System.Drawing.Size(328, 20);
            this.note_txtbox.TabIndex = 4;
            // 
            // date_datetimepicker
            // 
            this.date_datetimepicker.Location = new System.Drawing.Point(140, 51);
            this.date_datetimepicker.Name = "date_datetimepicker";
            this.date_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.date_datetimepicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beschreibung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date ";
            // 
            // isarchived_radiobtn
            // 
            this.isarchived_radiobtn.AutoSize = true;
            this.isarchived_radiobtn.Location = new System.Drawing.Point(273, 76);
            this.isarchived_radiobtn.Name = "isarchived_radiobtn";
            this.isarchived_radiobtn.Size = new System.Drawing.Size(67, 17);
            this.isarchived_radiobtn.TabIndex = 9;
            this.isarchived_radiobtn.TabStop = true;
            this.isarchived_radiobtn.Text = "Archived";
            this.isarchived_radiobtn.UseVisualStyleBackColor = true;
            // 
            // state_combobox
            // 
            this.state_combobox.FormattingEnabled = true;
            this.state_combobox.Location = new System.Drawing.Point(12, 138);
            this.state_combobox.Name = "state_combobox";
            this.state_combobox.Size = new System.Drawing.Size(176, 21);
            this.state_combobox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "State";
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(198, 138);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(142, 23);
            this.Submit_btn.TabIndex = 12;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.state_combobox);
            this.Controls.Add(this.isarchived_radiobtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_datetimepicker);
            this.Controls.Add(this.note_txtbox);
            this.Controls.Add(this.titel_txtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titel_txtbox;
        private System.Windows.Forms.TextBox note_txtbox;
        private System.Windows.Forms.DateTimePicker date_datetimepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton isarchived_radiobtn;
        private System.Windows.Forms.ComboBox state_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Submit_btn;
    }
}

