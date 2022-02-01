namespace prjYLHafta7
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
            this.lbPersoneller = new System.Windows.Forms.ListBox();
            this.btnDosyayiOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPersoneller
            // 
            this.lbPersoneller.FormattingEnabled = true;
            this.lbPersoneller.Location = new System.Drawing.Point(12, 12);
            this.lbPersoneller.Name = "lbPersoneller";
            this.lbPersoneller.Size = new System.Drawing.Size(570, 251);
            this.lbPersoneller.TabIndex = 0;
            // 
            // btnDosyayiOku
            // 
            this.btnDosyayiOku.Location = new System.Drawing.Point(12, 269);
            this.btnDosyayiOku.Name = "btnDosyayiOku";
            this.btnDosyayiOku.Size = new System.Drawing.Size(75, 23);
            this.btnDosyayiOku.TabIndex = 1;
            this.btnDosyayiOku.Text = "Dosyayi Oku";
            this.btnDosyayiOku.UseVisualStyleBackColor = true;
            this.btnDosyayiOku.Click += new System.EventHandler(this.btnDosyayiOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 303);
            this.Controls.Add(this.btnDosyayiOku);
            this.Controls.Add(this.lbPersoneller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersoneller;
        private System.Windows.Forms.Button btnDosyayiOku;
    }
}

