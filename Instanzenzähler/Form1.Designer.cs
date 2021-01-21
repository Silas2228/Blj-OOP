namespace Instanzenzähler
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
            this.Createinstance_btn = new System.Windows.Forms.Button();
            this.Resetinstance_btn = new System.Windows.Forms.Button();
            this.counterinstance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Createinstance_btn
            // 
            this.Createinstance_btn.Location = new System.Drawing.Point(55, 53);
            this.Createinstance_btn.Name = "Createinstance_btn";
            this.Createinstance_btn.Size = new System.Drawing.Size(215, 23);
            this.Createinstance_btn.TabIndex = 0;
            this.Createinstance_btn.Text = "Create instance of C";
            this.Createinstance_btn.UseVisualStyleBackColor = true;
            this.Createinstance_btn.Click += new System.EventHandler(this.Createinstance_btn_Click);
            // 
            // Resetinstance_btn
            // 
            this.Resetinstance_btn.Location = new System.Drawing.Point(55, 83);
            this.Resetinstance_btn.Name = "Resetinstance_btn";
            this.Resetinstance_btn.Size = new System.Drawing.Size(215, 23);
            this.Resetinstance_btn.TabIndex = 1;
            this.Resetinstance_btn.Text = "Reset instance counter";
            this.Resetinstance_btn.UseVisualStyleBackColor = true;
            this.Resetinstance_btn.Click += new System.EventHandler(this.Resetinstance_btn_Click);
            // 
            // counterinstance
            // 
            this.counterinstance.Location = new System.Drawing.Point(416, 50);
            this.counterinstance.Name = "counterinstance";
            this.counterinstance.Size = new System.Drawing.Size(35, 20);
            this.counterinstance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(277, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count of instances:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counterinstance);
            this.Controls.Add(this.Resetinstance_btn);
            this.Controls.Add(this.Createinstance_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Createinstance_btn;
        private System.Windows.Forms.Button Resetinstance_btn;
        private System.Windows.Forms.TextBox counterinstance;
        private System.Windows.Forms.Label label1;
    }
}

