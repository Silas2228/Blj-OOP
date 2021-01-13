namespace HelloWorldOOP
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
            this.HelloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloWorld
            // 
            this.HelloWorld.Location = new System.Drawing.Point(2, 2);
            this.HelloWorld.Name = "HelloWorld";
            this.HelloWorld.Size = new System.Drawing.Size(794, 446);
            this.HelloWorld.TabIndex = 0;
            this.HelloWorld.Text = "Press";
            this.HelloWorld.UseVisualStyleBackColor = true;
            this.HelloWorld.Click += new System.EventHandler(this.HelloWorld_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelloWorld;
    }
}

