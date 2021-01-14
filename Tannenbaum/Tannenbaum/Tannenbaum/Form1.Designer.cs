namespace Tannenbaum
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stammbreite_txt = new System.Windows.Forms.TextBox();
            this.stammhoehe_txt = new System.Windows.Forms.TextBox();
            this.kronenhoehe_txt = new System.Windows.Forms.TextBox();
            this.zeichnen_btn = new System.Windows.Forms.Button();
            this.Zeichnung_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stammhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kronenhöhe";
            // 
            // stammbreite_txt
            // 
            this.stammbreite_txt.Location = new System.Drawing.Point(107, 9);
            this.stammbreite_txt.Name = "stammbreite_txt";
            this.stammbreite_txt.Size = new System.Drawing.Size(100, 20);
            this.stammbreite_txt.TabIndex = 3;
            // 
            // stammhoehe_txt
            // 
            this.stammhoehe_txt.Location = new System.Drawing.Point(107, 38);
            this.stammhoehe_txt.Name = "stammhoehe_txt";
            this.stammhoehe_txt.Size = new System.Drawing.Size(100, 20);
            this.stammhoehe_txt.TabIndex = 5;
            // 
            // kronenhoehe_txt
            // 
            this.kronenhoehe_txt.Location = new System.Drawing.Point(107, 69);
            this.kronenhoehe_txt.Name = "kronenhoehe_txt";
            this.kronenhoehe_txt.Size = new System.Drawing.Size(100, 20);
            this.kronenhoehe_txt.TabIndex = 6;
            // 
            // zeichnen_btn
            // 
            this.zeichnen_btn.Location = new System.Drawing.Point(213, 69);
            this.zeichnen_btn.Name = "zeichnen_btn";
            this.zeichnen_btn.Size = new System.Drawing.Size(99, 21);
            this.zeichnen_btn.TabIndex = 7;
            this.zeichnen_btn.Text = "Tanne zeichnen";
            this.zeichnen_btn.UseVisualStyleBackColor = true;
            this.zeichnen_btn.Click += new System.EventHandler(this.zeichnen_btn_Click);
            // 
            // Zeichnung_txt
            // 
            this.Zeichnung_txt.Location = new System.Drawing.Point(12, 109);
            this.Zeichnung_txt.Multiline = true;
            this.Zeichnung_txt.Name = "Zeichnung_txt";
            this.Zeichnung_txt.Size = new System.Drawing.Size(353, 329);
            this.Zeichnung_txt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.Zeichnung_txt);
            this.Controls.Add(this.zeichnen_btn);
            this.Controls.Add(this.kronenhoehe_txt);
            this.Controls.Add(this.stammhoehe_txt);
            this.Controls.Add(this.stammbreite_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stammbreite_txt;
        private System.Windows.Forms.TextBox stammhoehe_txt;
        private System.Windows.Forms.TextBox kronenhoehe_txt;
        private System.Windows.Forms.Button zeichnen_btn;
        private System.Windows.Forms.TextBox Zeichnung_txt;
    }
}

