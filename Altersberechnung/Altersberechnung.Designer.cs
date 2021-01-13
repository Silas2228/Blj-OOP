namespace Alterberechnung
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
            this.radio_jahre = new System.Windows.Forms.RadioButton();
            this.radio_Monate = new System.Windows.Forms.RadioButton();
            this.radio_wochen = new System.Windows.Forms.RadioButton();
            this.radio_tage = new System.Windows.Forms.RadioButton();
            this.userbirthday = new System.Windows.Forms.DateTimePicker();
            this.age_txtbox = new System.Windows.Forms.TextBox();
            this.Alterberechnen_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_jahre
            // 
            this.radio_jahre.AutoSize = true;
            this.radio_jahre.Location = new System.Drawing.Point(56, 39);
            this.radio_jahre.Name = "radio_jahre";
            this.radio_jahre.Size = new System.Drawing.Size(51, 17);
            this.radio_jahre.TabIndex = 0;
            this.radio_jahre.TabStop = true;
            this.radio_jahre.Text = "Jahre";
            this.radio_jahre.UseVisualStyleBackColor = true;
            // 
            // radio_Monate
            // 
            this.radio_Monate.AutoSize = true;
            this.radio_Monate.Location = new System.Drawing.Point(148, 39);
            this.radio_Monate.Name = "radio_Monate";
            this.radio_Monate.Size = new System.Drawing.Size(61, 17);
            this.radio_Monate.TabIndex = 1;
            this.radio_Monate.TabStop = true;
            this.radio_Monate.Text = "Monate";
            this.radio_Monate.UseVisualStyleBackColor = true;
            // 
            // radio_wochen
            // 
            this.radio_wochen.AutoSize = true;
            this.radio_wochen.Location = new System.Drawing.Point(239, 39);
            this.radio_wochen.Name = "radio_wochen";
            this.radio_wochen.Size = new System.Drawing.Size(66, 17);
            this.radio_wochen.TabIndex = 2;
            this.radio_wochen.TabStop = true;
            this.radio_wochen.Text = "Wochen";
            this.radio_wochen.UseVisualStyleBackColor = true;
            // 
            // radio_tage
            // 
            this.radio_tage.AutoSize = true;
            this.radio_tage.Location = new System.Drawing.Point(330, 39);
            this.radio_tage.Name = "radio_tage";
            this.radio_tage.Size = new System.Drawing.Size(50, 17);
            this.radio_tage.TabIndex = 3;
            this.radio_tage.TabStop = true;
            this.radio_tage.Text = "Tage";
            this.radio_tage.UseVisualStyleBackColor = true;
            // 
            // userbirthday
            // 
            this.userbirthday.Location = new System.Drawing.Point(56, 89);
            this.userbirthday.Name = "userbirthday";
            this.userbirthday.Size = new System.Drawing.Size(200, 20);
            this.userbirthday.TabIndex = 4;
            // 
            // age_txtbox
            // 
            this.age_txtbox.Location = new System.Drawing.Point(56, 141);
            this.age_txtbox.Name = "age_txtbox";
            this.age_txtbox.Size = new System.Drawing.Size(200, 20);
            this.age_txtbox.TabIndex = 5;
            // 
            // Alterberechnen_btn
            // 
            this.Alterberechnen_btn.Location = new System.Drawing.Point(278, 89);
            this.Alterberechnen_btn.Name = "Alterberechnen_btn";
            this.Alterberechnen_btn.Size = new System.Drawing.Size(102, 23);
            this.Alterberechnen_btn.TabIndex = 6;
            this.Alterberechnen_btn.Text = "Berechne";
            this.Alterberechnen_btn.UseVisualStyleBackColor = true;
            this.Alterberechnen_btn.Click += new System.EventHandler(this.Alterberechnen_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alterberechnen_btn);
            this.Controls.Add(this.age_txtbox);
            this.Controls.Add(this.userbirthday);
            this.Controls.Add(this.radio_tage);
            this.Controls.Add(this.radio_wochen);
            this.Controls.Add(this.radio_Monate);
            this.Controls.Add(this.radio_jahre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_jahre;
        private System.Windows.Forms.RadioButton radio_Monate;
        private System.Windows.Forms.RadioButton radio_wochen;
        private System.Windows.Forms.RadioButton radio_tage;
        private System.Windows.Forms.DateTimePicker userbirthday;
        private System.Windows.Forms.TextBox age_txtbox;
        private System.Windows.Forms.Button Alterberechnen_btn;
    }
}

