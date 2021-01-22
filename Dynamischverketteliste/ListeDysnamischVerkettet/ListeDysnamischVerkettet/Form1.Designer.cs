namespace ListeDysnamischVerkettet
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
            this.label1 = new System.Windows.Forms.Label();
            this.userzahl_txt = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Ascending_radio_btn = new System.Windows.Forms.RadioButton();
            this.Descending_radio_btn = new System.Windows.Forms.RadioButton();
            this.Get_btn = new System.Windows.Forms.Button();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zahl:";
            // 
            // userzahl_txt
            // 
            this.userzahl_txt.Location = new System.Drawing.Point(75, 29);
            this.userzahl_txt.Name = "userzahl_txt";
            this.userzahl_txt.Size = new System.Drawing.Size(100, 20);
            this.userzahl_txt.TabIndex = 1;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(182, 29);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Ascending_radio_btn
            // 
            this.Ascending_radio_btn.AutoSize = true;
            this.Ascending_radio_btn.Location = new System.Drawing.Point(40, 68);
            this.Ascending_radio_btn.Name = "Ascending_radio_btn";
            this.Ascending_radio_btn.Size = new System.Drawing.Size(75, 17);
            this.Ascending_radio_btn.TabIndex = 4;
            this.Ascending_radio_btn.TabStop = true;
            this.Ascending_radio_btn.Text = "Ascending";
            this.Ascending_radio_btn.UseVisualStyleBackColor = true;
            // 
            // Descending_radio_btn
            // 
            this.Descending_radio_btn.AutoSize = true;
            this.Descending_radio_btn.Location = new System.Drawing.Point(40, 91);
            this.Descending_radio_btn.Name = "Descending_radio_btn";
            this.Descending_radio_btn.Size = new System.Drawing.Size(82, 17);
            this.Descending_radio_btn.TabIndex = 5;
            this.Descending_radio_btn.TabStop = true;
            this.Descending_radio_btn.Text = "Descending";
            this.Descending_radio_btn.UseVisualStyleBackColor = true;
            // 
            // Get_btn
            // 
            this.Get_btn.Location = new System.Drawing.Point(182, 91);
            this.Get_btn.Name = "Get_btn";
            this.Get_btn.Size = new System.Drawing.Size(75, 20);
            this.Get_btn.TabIndex = 6;
            this.Get_btn.Text = "Get";
            this.Get_btn.UseVisualStyleBackColor = true;
            this.Get_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(40, 128);
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(217, 20);
            this.output_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zahlenspeicher leeren:";
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(182, 162);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 20);
            this.Clear_btn.TabIndex = 9;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 196);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.Get_btn);
            this.Controls.Add(this.Descending_radio_btn);
            this.Controls.Add(this.Ascending_radio_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.userzahl_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "yy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userzahl_txt;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.RadioButton Ascending_radio_btn;
        private System.Windows.Forms.RadioButton Descending_radio_btn;
        private System.Windows.Forms.Button Get_btn;
        private System.Windows.Forms.TextBox output_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear_btn;
    }
}

