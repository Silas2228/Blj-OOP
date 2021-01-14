namespace Worttabelle
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
            this.woerter_txt = new System.Windows.Forms.TextBox();
            this.woerter_btn = new System.Windows.Forms.Button();
            this.ausgabewoerter_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // woerter_txt
            // 
            this.woerter_txt.Location = new System.Drawing.Point(13, 13);
            this.woerter_txt.Multiline = true;
            this.woerter_txt.Name = "woerter_txt";
            this.woerter_txt.Size = new System.Drawing.Size(409, 167);
            this.woerter_txt.TabIndex = 0;
            // 
            // woerter_btn
            // 
            this.woerter_btn.Location = new System.Drawing.Point(428, 82);
            this.woerter_btn.Name = "woerter_btn";
            this.woerter_btn.Size = new System.Drawing.Size(125, 28);
            this.woerter_btn.TabIndex = 1;
            this.woerter_btn.Text = "button1";
            this.woerter_btn.UseVisualStyleBackColor = true;
            this.woerter_btn.Click += new System.EventHandler(this.woerter_btn_Click);
            // 
            // ausgabewoerter_txt
            // 
            this.ausgabewoerter_txt.Location = new System.Drawing.Point(12, 186);
            this.ausgabewoerter_txt.Multiline = true;
            this.ausgabewoerter_txt.Name = "ausgabewoerter_txt";
            this.ausgabewoerter_txt.ReadOnly = true;
            this.ausgabewoerter_txt.Size = new System.Drawing.Size(410, 197);
            this.ausgabewoerter_txt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ausgabewoerter_txt);
            this.Controls.Add(this.woerter_btn);
            this.Controls.Add(this.woerter_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox woerter_txt;
        private System.Windows.Forms.Button woerter_btn;
        private System.Windows.Forms.TextBox ausgabewoerter_txt;
    }
}

