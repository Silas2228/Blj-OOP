namespace ReisezeitErdeMond
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
            this.radio_btn_stunden = new System.Windows.Forms.RadioButton();
            this.radio_btn_tagen = new System.Windows.Forms.RadioButton();
            this.geschwindigkeit_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.berechnen_btn = new System.Windows.Forms.Button();
            this.ausgabe_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reise Zeit Erde-Mond";
            // 
            // radio_btn_stunden
            // 
            this.radio_btn_stunden.AutoSize = true;
            this.radio_btn_stunden.Location = new System.Drawing.Point(15, 54);
            this.radio_btn_stunden.Name = "radio_btn_stunden";
            this.radio_btn_stunden.Size = new System.Drawing.Size(76, 17);
            this.radio_btn_stunden.TabIndex = 1;
            this.radio_btn_stunden.TabStop = true;
            this.radio_btn_stunden.Text = "in Stunden";
            this.radio_btn_stunden.UseVisualStyleBackColor = true;
            // 
            // radio_btn_tagen
            // 
            this.radio_btn_tagen.AutoSize = true;
            this.radio_btn_tagen.Location = new System.Drawing.Point(119, 54);
            this.radio_btn_tagen.Name = "radio_btn_tagen";
            this.radio_btn_tagen.Size = new System.Drawing.Size(67, 17);
            this.radio_btn_tagen.TabIndex = 2;
            this.radio_btn_tagen.TabStop = true;
            this.radio_btn_tagen.Text = "in Tagen";
            this.radio_btn_tagen.UseVisualStyleBackColor = true;
            // 
            // geschwindigkeit_txt
            // 
            this.geschwindigkeit_txt.Location = new System.Drawing.Point(5, 116);
            this.geschwindigkeit_txt.Name = "geschwindigkeit_txt";
            this.geschwindigkeit_txt.Size = new System.Drawing.Size(181, 20);
            this.geschwindigkeit_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geschwindigkeit";
            // 
            // berechnen_btn
            // 
            this.berechnen_btn.Location = new System.Drawing.Point(8, 152);
            this.berechnen_btn.Name = "berechnen_btn";
            this.berechnen_btn.Size = new System.Drawing.Size(75, 23);
            this.berechnen_btn.TabIndex = 5;
            this.berechnen_btn.Text = "berechnen";
            this.berechnen_btn.UseVisualStyleBackColor = true;
            this.berechnen_btn.Click += new System.EventHandler(this.berechnen_btn_Click);
            // 
            // ausgabe_txt
            // 
            this.ausgabe_txt.Location = new System.Drawing.Point(5, 182);
            this.ausgabe_txt.Name = "ausgabe_txt";
            this.ausgabe_txt.Size = new System.Drawing.Size(181, 20);
            this.ausgabe_txt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 228);
            this.Controls.Add(this.ausgabe_txt);
            this.Controls.Add(this.berechnen_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geschwindigkeit_txt);
            this.Controls.Add(this.radio_btn_tagen);
            this.Controls.Add(this.radio_btn_stunden);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_btn_stunden;
        private System.Windows.Forms.RadioButton radio_btn_tagen;
        private System.Windows.Forms.TextBox geschwindigkeit_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button berechnen_btn;
        private System.Windows.Forms.TextBox ausgabe_txt;
    }
}

