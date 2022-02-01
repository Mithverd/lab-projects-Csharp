namespace prjHafta11
{
    partial class frmChat
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
            this.components = new System.ComponentModel.Container();
            this.txtMesajlar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMesajlar
            // 
            this.txtMesajlar.BackColor = System.Drawing.SystemColors.Window;
            this.txtMesajlar.Location = new System.Drawing.Point(12, 12);
            this.txtMesajlar.Multiline = true;
            this.txtMesajlar.Name = "txtMesajlar";
            this.txtMesajlar.ReadOnly = true;
            this.txtMesajlar.Size = new System.Drawing.Size(522, 342);
            this.txtMesajlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesaj:";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(56, 360);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(478, 20);
            this.txtMesaj.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 392);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesajlar);
            this.KeyPreview = true;
            this.Name = "frmChat";
            this.Text = "Chat";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmChat_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesajlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Timer timer1;
    }
}

