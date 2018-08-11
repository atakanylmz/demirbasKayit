namespace yazilimSinamaProje
{
    partial class OdaTanimlama
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
            this.label3 = new System.Windows.Forms.Label();
            this.departmanCmb = new System.Windows.Forms.ComboBox();
            this.anaMenuyeDonBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odaAdiTxt = new System.Windows.Forms.TextBox();
            this.odaSorumlusuCmb = new System.Windows.Forms.ComboBox();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.departmanCmb);
            this.groupBox1.Controls.Add(this.anaMenuyeDonBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.odaAdiTxt);
            this.groupBox1.Controls.Add(this.odaSorumlusuCmb);
            this.groupBox1.Controls.Add(this.kaydetBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODA TANIMLAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departman:";
            // 
            // departmanCmb
            // 
            this.departmanCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmanCmb.FormattingEnabled = true;
            this.departmanCmb.Items.AddRange(new object[] {
            "Yazılım",
            "Mekatronik",
            "Elektronik",
            "Makine"});
            this.departmanCmb.Location = new System.Drawing.Point(130, 117);
            this.departmanCmb.Name = "departmanCmb";
            this.departmanCmb.Size = new System.Drawing.Size(146, 21);
            this.departmanCmb.TabIndex = 6;
            // 
            // anaMenuyeDonBtn
            // 
            this.anaMenuyeDonBtn.Location = new System.Drawing.Point(176, 156);
            this.anaMenuyeDonBtn.Name = "anaMenuyeDonBtn";
            this.anaMenuyeDonBtn.Size = new System.Drawing.Size(100, 34);
            this.anaMenuyeDonBtn.TabIndex = 5;
            this.anaMenuyeDonBtn.Text = "ANA MENÜYE DÖN";
            this.anaMenuyeDonBtn.UseVisualStyleBackColor = true;
            this.anaMenuyeDonBtn.Click += new System.EventHandler(this.anaMenuyeDonBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oda Sorumlusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oda Adı:";
            // 
            // odaAdiTxt
            // 
            this.odaAdiTxt.Location = new System.Drawing.Point(130, 37);
            this.odaAdiTxt.Name = "odaAdiTxt";
            this.odaAdiTxt.Size = new System.Drawing.Size(146, 20);
            this.odaAdiTxt.TabIndex = 2;
            // 
            // odaSorumlusuCmb
            // 
            this.odaSorumlusuCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odaSorumlusuCmb.FormattingEnabled = true;
            this.odaSorumlusuCmb.Items.AddRange(new object[] {
            "Ahmet",
            "Burak",
            "Cenk",
            "Ekrem",
            "Faruk",
            "Boş"});
            this.odaSorumlusuCmb.Location = new System.Drawing.Point(130, 77);
            this.odaSorumlusuCmb.Name = "odaSorumlusuCmb";
            this.odaSorumlusuCmb.Size = new System.Drawing.Size(146, 21);
            this.odaSorumlusuCmb.TabIndex = 1;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(33, 156);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(100, 34);
            this.kaydetBtn.TabIndex = 0;
            this.kaydetBtn.Text = "KAYDET";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // OdaTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 236);
            this.Controls.Add(this.groupBox1);
            this.Name = "OdaTanimlama";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button anaMenuyeDonBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odaAdiTxt;
        private System.Windows.Forms.ComboBox odaSorumlusuCmb;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmanCmb;
    }
}