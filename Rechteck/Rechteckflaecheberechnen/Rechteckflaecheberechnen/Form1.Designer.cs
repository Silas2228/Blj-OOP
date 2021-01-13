namespace Rechteckflaecheberechnen
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
            this.breite_txt = new System.Windows.Forms.TextBox();
            this.hoehe_txt = new System.Windows.Forms.TextBox();
            this.Berechnen = new System.Windows.Forms.Button();
            this.Breite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flaeche_txt = new System.Windows.Forms.TextBox();
            this.Beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // breite_txt
            // 
            this.breite_txt.Location = new System.Drawing.Point(243, 57);
            this.breite_txt.Name = "breite_txt";
            this.breite_txt.Size = new System.Drawing.Size(177, 20);
            this.breite_txt.TabIndex = 0;
            // 
            // hoehe_txt
            // 
            this.hoehe_txt.Location = new System.Drawing.Point(243, 98);
            this.hoehe_txt.Name = "hoehe_txt";
            this.hoehe_txt.Size = new System.Drawing.Size(177, 20);
            this.hoehe_txt.TabIndex = 1;
            // 
            // Berechnen
            // 
            this.Berechnen.Location = new System.Drawing.Point(474, 93);
            this.Berechnen.Name = "Berechnen";
            this.Berechnen.Size = new System.Drawing.Size(145, 23);
            this.Berechnen.TabIndex = 2;
            this.Berechnen.Text = "Berechnen";
            this.Berechnen.UseVisualStyleBackColor = true;
            this.Berechnen.Click += new System.EventHandler(this.Berechnen_Click);
            // 
            // Breite
            // 
            this.Breite.AutoSize = true;
            this.Breite.Location = new System.Drawing.Point(160, 57);
            this.Breite.Name = "Breite";
            this.Breite.Size = new System.Drawing.Size(34, 13);
            this.Breite.TabIndex = 3;
            this.Breite.Text = "Breite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Höhe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fläche";
            // 
            // flaeche_txt
            // 
            this.flaeche_txt.Location = new System.Drawing.Point(243, 141);
            this.flaeche_txt.Name = "flaeche_txt";
            this.flaeche_txt.Size = new System.Drawing.Size(177, 20);
            this.flaeche_txt.TabIndex = 6;
            // 
            // Beenden
            // 
            this.Beenden.Location = new System.Drawing.Point(474, 137);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(145, 23);
            this.Beenden.TabIndex = 7;
            this.Beenden.Text = "Beenden";
            this.Beenden.UseVisualStyleBackColor = true;
            this.Beenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.flaeche_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Breite);
            this.Controls.Add(this.Berechnen);
            this.Controls.Add(this.hoehe_txt);
            this.Controls.Add(this.breite_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox breite_txt;
        private System.Windows.Forms.TextBox hoehe_txt;
        private System.Windows.Forms.Button Berechnen;
        private System.Windows.Forms.Label Breite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flaeche_txt;
        private System.Windows.Forms.Button Beenden;
    }
}

