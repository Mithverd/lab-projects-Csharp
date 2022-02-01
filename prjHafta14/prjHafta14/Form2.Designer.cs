namespace prjHafta14
{
    partial class Form2
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
            this.btnIslemGecmisiniGoster = new System.Windows.Forms.Button();
            this.lblSonBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKayitlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIslemGecmisiniGoster
            // 
            this.btnIslemGecmisiniGoster.Location = new System.Drawing.Point(343, 410);
            this.btnIslemGecmisiniGoster.Name = "btnIslemGecmisiniGoster";
            this.btnIslemGecmisiniGoster.Size = new System.Drawing.Size(129, 23);
            this.btnIslemGecmisiniGoster.TabIndex = 7;
            this.btnIslemGecmisiniGoster.Text = "İşlem Geçmişini Göster";
            this.btnIslemGecmisiniGoster.UseVisualStyleBackColor = true;
            this.btnIslemGecmisiniGoster.Click += new System.EventHandler(this.btnIslemGecmisiniGoster_Click);
            // 
            // lblSonBakiye
            // 
            this.lblSonBakiye.AutoSize = true;
            this.lblSonBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonBakiye.Location = new System.Drawing.Point(120, 413);
            this.lblSonBakiye.Name = "lblSonBakiye";
            this.lblSonBakiye.Size = new System.Drawing.Size(0, 16);
            this.lblSonBakiye.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Son Bakiye:";
            // 
            // lbKayitlar
            // 
            this.lbKayitlar.FormattingEnabled = true;
            this.lbKayitlar.Location = new System.Drawing.Point(12, 12);
            this.lbKayitlar.Name = "lbKayitlar";
            this.lbKayitlar.Size = new System.Drawing.Size(460, 394);
            this.lbKayitlar.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 443);
            this.Controls.Add(this.btnIslemGecmisiniGoster);
            this.Controls.Add(this.lblSonBakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKayitlar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIslemGecmisiniGoster;
        private System.Windows.Forms.Label lblSonBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKayitlar;
    }
}