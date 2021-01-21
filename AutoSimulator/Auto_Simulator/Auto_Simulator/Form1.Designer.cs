namespace Auto_Simulator
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
            this.Hupe_btn = new System.Windows.Forms.Button();
            this.MotorStarten_btn = new System.Windows.Forms.Button();
            this.Gas_btn = new System.Windows.Forms.Button();
            this.Bremsen_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gas_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hupe_btn
            // 
            this.Hupe_btn.Location = new System.Drawing.Point(187, 213);
            this.Hupe_btn.Name = "Hupe_btn";
            this.Hupe_btn.Size = new System.Drawing.Size(88, 42);
            this.Hupe_btn.TabIndex = 0;
            this.Hupe_btn.Text = "Hupe";
            this.Hupe_btn.UseVisualStyleBackColor = true;
            this.Hupe_btn.Click += new System.EventHandler(this.Hupe_btn_Click);
            // 
            // MotorStarten_btn
            // 
            this.MotorStarten_btn.Location = new System.Drawing.Point(187, 166);
            this.MotorStarten_btn.Name = "MotorStarten_btn";
            this.MotorStarten_btn.Size = new System.Drawing.Size(88, 40);
            this.MotorStarten_btn.TabIndex = 2;
            this.MotorStarten_btn.Text = "Motor Starten";
            this.MotorStarten_btn.UseVisualStyleBackColor = true;
            this.MotorStarten_btn.Click += new System.EventHandler(this.MotorStarten_btn_Click);
            // 
            // Gas_btn
            // 
            this.Gas_btn.Location = new System.Drawing.Point(425, 166);
            this.Gas_btn.Name = "Gas_btn";
            this.Gas_btn.Size = new System.Drawing.Size(107, 137);
            this.Gas_btn.TabIndex = 4;
            this.Gas_btn.Text = "Gas";
            this.Gas_btn.UseVisualStyleBackColor = true;
            this.Gas_btn.Click += new System.EventHandler(this.Gas_btn_Click);
            // 
            // Bremsen_btn
            // 
            this.Bremsen_btn.Location = new System.Drawing.Point(289, 166);
            this.Bremsen_btn.Name = "Bremsen_btn";
            this.Bremsen_btn.Size = new System.Drawing.Size(111, 137);
            this.Bremsen_btn.TabIndex = 6;
            this.Bremsen_btn.Text = "Bremse";
            this.Bremsen_btn.UseVisualStyleBackColor = true;
            this.Bremsen_btn.MouseHover += new System.EventHandler(this.Bremsen_btn_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(184, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 91);
            this.label1.TabIndex = 7;
            // 
            // gas_txt
            // 
            this.gas_txt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gas_txt.ForeColor = System.Drawing.Color.SpringGreen;
            this.gas_txt.Location = new System.Drawing.Point(196, 71);
            this.gas_txt.Name = "gas_txt";
            this.gas_txt.Size = new System.Drawing.Size(214, 66);
            this.gas_txt.TabIndex = 8;
            this.gas_txt.Text = "A";
            this.gas_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(432, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 66);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(276, 12);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(267, 21);
            this.comboBoxAutos.TabIndex = 10;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(187, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auto wählen";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(162, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gas_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bremsen_btn);
            this.Controls.Add(this.Gas_btn);
            this.Controls.Add(this.MotorStarten_btn);
            this.Controls.Add(this.Hupe_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hupe_btn;
        private System.Windows.Forms.Button MotorStarten_btn;
        private System.Windows.Forms.Button Gas_btn;
        private System.Windows.Forms.Button Bremsen_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gas_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

