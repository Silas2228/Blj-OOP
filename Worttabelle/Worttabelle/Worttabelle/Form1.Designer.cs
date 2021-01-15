namespace WortTabelle
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
            this.output_txt = new System.Windows.Forms.TextBox();
            this.userinput_txt = new System.Windows.Forms.TextBox();
            this.words_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(12, 196);
            this.output_txt.Multiline = true;
            this.output_txt.Name = "output_txt";
            this.output_txt.ReadOnly = true;
            this.output_txt.Size = new System.Drawing.Size(326, 183);
            this.output_txt.TabIndex = 0;
            // 
            // userinput_txt
            // 
            this.userinput_txt.Location = new System.Drawing.Point(12, 12);
            this.userinput_txt.Multiline = true;
            this.userinput_txt.Name = "userinput_txt";
            this.userinput_txt.Size = new System.Drawing.Size(326, 175);
            this.userinput_txt.TabIndex = 1;
            // 
            // words_btn
            // 
            this.words_btn.Location = new System.Drawing.Point(344, 170);
            this.words_btn.Name = "words_btn";
            this.words_btn.Size = new System.Drawing.Size(122, 50);
            this.words_btn.TabIndex = 2;
            this.words_btn.Text = "Wörter zählen";
            this.words_btn.UseVisualStyleBackColor = true;
            this.words_btn.Click += new System.EventHandler(this.words_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wort-Tabelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.words_btn);
            this.Controls.Add(this.userinput_txt);
            this.Controls.Add(this.output_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output_txt;
        private System.Windows.Forms.TextBox userinput_txt;
        private System.Windows.Forms.Button words_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

