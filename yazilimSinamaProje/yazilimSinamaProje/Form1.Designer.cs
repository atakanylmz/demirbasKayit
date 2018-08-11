namespace yazilimSinamaProje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yetkiChck = new System.Windows.Forms.CheckBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.kullaniciAdiTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sifreTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.yetkiChck);
            this.groupBox1.Controls.Add(this.girisBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEMİRBAŞ KAYIT VE GÖRÜNTÜLEME SİSTEMİ";
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(141, 71);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(131, 20);
            this.kullaniciAdiTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(141, 97);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(131, 20);
            this.sifreTxt.TabIndex = 3;
            this.sifreTxt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ŞİFRE:";
            // 
            // yetkiChck
            // 
            this.yetkiChck.AutoSize = true;
            this.yetkiChck.Location = new System.Drawing.Point(16, 137);
            this.yetkiChck.Name = "yetkiChck";
            this.yetkiChck.Size = new System.Drawing.Size(137, 17);
            this.yetkiChck.TabIndex = 1;
            this.yetkiChck.Text = "Yönetici olarak giriş yap";
            this.yetkiChck.UseVisualStyleBackColor = true;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(197, 131);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 0;
            this.girisBtn.Text = "GİRİŞ";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 229);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kullaniciAdiTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox yetkiChck;
        private System.Windows.Forms.Button girisBtn;
    }
}

