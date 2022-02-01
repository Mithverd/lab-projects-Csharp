namespace prjHafta12Lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDoviz1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.cbDoviz2 = new System.Windows.Forms.ComboBox();
            this.txtAdet1 = new System.Windows.Forms.TextBox();
            this.txtPariteDolar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPariteEuro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Döviz 1:";
            // 
            // cbDoviz1
            // 
            this.cbDoviz1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoviz1.FormattingEnabled = true;
            this.cbDoviz1.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Türk Lirası"});
            this.cbDoviz1.Location = new System.Drawing.Point(62, 22);
            this.cbDoviz1.Name = "cbDoviz1";
            this.cbDoviz1.Size = new System.Drawing.Size(147, 21);
            this.cbDoviz1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Döviz 2:";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(62, 132);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(147, 23);
            this.btnTopla.TabIndex = 8;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sonuç:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(66, 171);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 10;
            // 
            // cbDoviz2
            // 
            this.cbDoviz2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoviz2.FormattingEnabled = true;
            this.cbDoviz2.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Türk Lirası"});
            this.cbDoviz2.Location = new System.Drawing.Point(62, 79);
            this.cbDoviz2.Name = "cbDoviz2";
            this.cbDoviz2.Size = new System.Drawing.Size(147, 21);
            this.cbDoviz2.TabIndex = 11;
            // 
            // txtAdet1
            // 
            this.txtAdet1.Location = new System.Drawing.Point(62, 49);
            this.txtAdet1.Name = "txtAdet1";
            this.txtAdet1.Size = new System.Drawing.Size(147, 20);
            this.txtAdet1.TabIndex = 12;
            // 
            // txtPariteDolar
            // 
            this.txtPariteDolar.Location = new System.Drawing.Point(54, 22);
            this.txtPariteDolar.Name = "txtPariteDolar";
            this.txtPariteDolar.Size = new System.Drawing.Size(90, 20);
            this.txtPariteDolar.TabIndex = 14;
            this.txtPariteDolar.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dolar:";
            // 
            // txtAdet2
            // 
            this.txtAdet2.Location = new System.Drawing.Point(62, 106);
            this.txtAdet2.Name = "txtAdet2";
            this.txtAdet2.Size = new System.Drawing.Size(147, 20);
            this.txtAdet2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Adet 2:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPariteEuro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPariteDolar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pariteler";
            // 
            // txtPariteEuro
            // 
            this.txtPariteEuro.Location = new System.Drawing.Point(54, 48);
            this.txtPariteEuro.Name = "txtPariteEuro";
            this.txtPariteEuro.Size = new System.Drawing.Size(90, 20);
            this.txtPariteEuro.TabIndex = 16;
            this.txtPariteEuro.Text = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Euro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDoviz1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAdet2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAdet1);
            this.groupBox2.Controls.Add(this.btnTopla);
            this.groupBox2.Controls.Add(this.cbDoviz2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblSonuc);
            this.groupBox2.Location = new System.Drawing.Point(173, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 196);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 215);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDoviz1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ComboBox cbDoviz2;
        private System.Windows.Forms.TextBox txtAdet1;
        private System.Windows.Forms.TextBox txtPariteDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPariteEuro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

