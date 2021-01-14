namespace FifoPuffer
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
            this.numeric_puffergroesse = new System.Windows.Forms.NumericUpDown();
            this.puffererstellen_btn = new System.Windows.Forms.Button();
            this.eingabezah = new System.Windows.Forms.TextBox();
            this.put_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ausgabe_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_puffergroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_puffergroesse
            // 
            this.numeric_puffergroesse.Location = new System.Drawing.Point(24, 22);
            this.numeric_puffergroesse.Name = "numeric_puffergroesse";
            this.numeric_puffergroesse.Size = new System.Drawing.Size(120, 20);
            this.numeric_puffergroesse.TabIndex = 1;
            // 
            // puffererstellen_btn
            // 
            this.puffererstellen_btn.Location = new System.Drawing.Point(166, 22);
            this.puffererstellen_btn.Name = "puffererstellen_btn";
            this.puffererstellen_btn.Size = new System.Drawing.Size(132, 20);
            this.puffererstellen_btn.TabIndex = 2;
            this.puffererstellen_btn.Text = "Puffer erstellen";
            this.puffererstellen_btn.UseVisualStyleBackColor = true;
            this.puffererstellen_btn.Click += new System.EventHandler(this.puffererstellen_btn_Click);
            // 
            // eingabezah
            // 
            this.eingabezah.Location = new System.Drawing.Point(24, 49);
            this.eingabezah.Name = "eingabezah";
            this.eingabezah.Size = new System.Drawing.Size(120, 20);
            this.eingabezah.TabIndex = 3;
            // 
            // put_btn
            // 
            this.put_btn.Location = new System.Drawing.Point(166, 49);
            this.put_btn.Name = "put_btn";
            this.put_btn.Size = new System.Drawing.Size(132, 19);
            this.put_btn.TabIndex = 4;
            this.put_btn.Text = "Put";
            this.put_btn.UseVisualStyleBackColor = true;
            this.put_btn.Click += new System.EventHandler(this.put_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ausgabe_txt
            // 
            this.ausgabe_txt.Location = new System.Drawing.Point(166, 112);
            this.ausgabe_txt.Name = "ausgabe_txt";
            this.ausgabe_txt.Size = new System.Drawing.Size(132, 20);
            this.ausgabe_txt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ausgabe_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.put_btn);
            this.Controls.Add(this.eingabezah);
            this.Controls.Add(this.puffererstellen_btn);
            this.Controls.Add(this.numeric_puffergroesse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_puffergroesse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_puffergroesse;
        private System.Windows.Forms.Button puffererstellen_btn;
        private System.Windows.Forms.TextBox eingabezah;
        private System.Windows.Forms.Button put_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ausgabe_txt;
    }
}

