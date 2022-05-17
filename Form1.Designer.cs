namespace kisayol2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxexefile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonexe = new System.Windows.Forms.Button();
            this.buttonkisayol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxexefile
            // 
            this.textBoxexefile.Location = new System.Drawing.Point(323, 105);
            this.textBoxexefile.Name = "textBoxexefile";
            this.textBoxexefile.Size = new System.Drawing.Size(185, 27);
            this.textBoxexefile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya yeri";
            // 
            // buttonexe
            // 
            this.buttonexe.Location = new System.Drawing.Point(551, 108);
            this.buttonexe.Name = "buttonexe";
            this.buttonexe.Size = new System.Drawing.Size(94, 29);
            this.buttonexe.TabIndex = 2;
            this.buttonexe.Text = "exe dosya";
            this.buttonexe.UseVisualStyleBackColor = true;
            this.buttonexe.Click += new System.EventHandler(this.buttonexe_Click);
            // 
            // buttonkisayol
            // 
            this.buttonkisayol.Location = new System.Drawing.Point(343, 196);
            this.buttonkisayol.Name = "buttonkisayol";
            this.buttonkisayol.Size = new System.Drawing.Size(142, 29);
            this.buttonkisayol.TabIndex = 3;
            this.buttonkisayol.Text = "kisayol oluştur";
            this.buttonkisayol.UseVisualStyleBackColor = true;
            this.buttonkisayol.Click += new System.EventHandler(this.buttonkisayol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonkisayol);
            this.Controls.Add(this.buttonexe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxexefile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxexefile;
        private Label label1;
        private Button buttonexe;
        private Button buttonkisayol;
    }
}