namespace yazilimSinamaProje
{
    partial class AnaMenu
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
            this.personelDemirbasBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odaDemirbasListeBtn = new System.Windows.Forms.Button();
            this.odaTanimlamaBtn = new System.Windows.Forms.Button();
            this.StokKaydiBtn = new System.Windows.Forms.Button();
            this.odaDemirbasIslemBtn = new System.Windows.Forms.Button();
            this.demirbasAramaListelemeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personelDemirbasBtn
            // 
            this.personelDemirbasBtn.Location = new System.Drawing.Point(30, 40);
            this.personelDemirbasBtn.Name = "personelDemirbasBtn";
            this.personelDemirbasBtn.Size = new System.Drawing.Size(140, 60);
            this.personelDemirbasBtn.TabIndex = 0;
            this.personelDemirbasBtn.Text = "PERSONEL ÜZERİNDEKİ DEMİRBAŞ";
            this.personelDemirbasBtn.UseVisualStyleBackColor = true;
            this.personelDemirbasBtn.Click += new System.EventHandler(this.personelDemirbasBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.odaDemirbasListeBtn);
            this.groupBox1.Controls.Add(this.odaTanimlamaBtn);
            this.groupBox1.Controls.Add(this.StokKaydiBtn);
            this.groupBox1.Controls.Add(this.odaDemirbasIslemBtn);
            this.groupBox1.Controls.Add(this.demirbasAramaListelemeBtn);
            this.groupBox1.Controls.Add(this.personelDemirbasBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEM SEÇİNİZ";
            // 
            // odaDemirbasListeBtn
            // 
            this.odaDemirbasListeBtn.Location = new System.Drawing.Point(390, 140);
            this.odaDemirbasListeBtn.Name = "odaDemirbasListeBtn";
            this.odaDemirbasListeBtn.Size = new System.Drawing.Size(140, 60);
            this.odaDemirbasListeBtn.TabIndex = 5;
            this.odaDemirbasListeBtn.Text = "ODA DEMİRBAŞ LİSTESİ";
            this.odaDemirbasListeBtn.UseVisualStyleBackColor = true;
            this.odaDemirbasListeBtn.Click += new System.EventHandler(this.odaDemirbasListeBtn_Click);
            // 
            // odaTanimlamaBtn
            // 
            this.odaTanimlamaBtn.Location = new System.Drawing.Point(390, 40);
            this.odaTanimlamaBtn.Name = "odaTanimlamaBtn";
            this.odaTanimlamaBtn.Size = new System.Drawing.Size(140, 60);
            this.odaTanimlamaBtn.TabIndex = 4;
            this.odaTanimlamaBtn.Text = "ODA TANIMLAMA";
            this.odaTanimlamaBtn.UseVisualStyleBackColor = true;
            this.odaTanimlamaBtn.Click += new System.EventHandler(this.odaTanimlamaBtn_Click);
            // 
            // StokKaydiBtn
            // 
            this.StokKaydiBtn.Location = new System.Drawing.Point(210, 140);
            this.StokKaydiBtn.Name = "StokKaydiBtn";
            this.StokKaydiBtn.Size = new System.Drawing.Size(140, 60);
            this.StokKaydiBtn.TabIndex = 3;
            this.StokKaydiBtn.Text = "STOK KAYDI";
            this.StokKaydiBtn.UseVisualStyleBackColor = true;
            this.StokKaydiBtn.Click += new System.EventHandler(this.StokKaydiBtn_Click);
            // 
            // odaDemirbasIslemBtn
            // 
            this.odaDemirbasIslemBtn.Location = new System.Drawing.Point(30, 140);
            this.odaDemirbasIslemBtn.Name = "odaDemirbasIslemBtn";
            this.odaDemirbasIslemBtn.Size = new System.Drawing.Size(140, 60);
            this.odaDemirbasIslemBtn.TabIndex = 2;
            this.odaDemirbasIslemBtn.Text = "ODA DEMİRBAŞ İŞLEMLERİ";
            this.odaDemirbasIslemBtn.UseVisualStyleBackColor = true;
            this.odaDemirbasIslemBtn.Click += new System.EventHandler(this.odaDemirbasIslemBtn_Click);
            // 
            // demirbasAramaListelemeBtn
            // 
            this.demirbasAramaListelemeBtn.Location = new System.Drawing.Point(210, 40);
            this.demirbasAramaListelemeBtn.Name = "demirbasAramaListelemeBtn";
            this.demirbasAramaListelemeBtn.Size = new System.Drawing.Size(140, 60);
            this.demirbasAramaListelemeBtn.TabIndex = 1;
            this.demirbasAramaListelemeBtn.Text = "DEMİRBAŞ ARAMA VE LİSTELEME";
            this.demirbasAramaListelemeBtn.UseVisualStyleBackColor = true;
            this.demirbasAramaListelemeBtn.Click += new System.EventHandler(this.demirbasAramaListelemeBtn_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 263);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personelDemirbasBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button odaDemirbasListeBtn;
        private System.Windows.Forms.Button odaTanimlamaBtn;
        private System.Windows.Forms.Button StokKaydiBtn;
        private System.Windows.Forms.Button odaDemirbasIslemBtn;
        private System.Windows.Forms.Button demirbasAramaListelemeBtn;
    }
}