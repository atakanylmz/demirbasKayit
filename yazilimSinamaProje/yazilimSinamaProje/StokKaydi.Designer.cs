namespace yazilimSinamaProje
{
    partial class StokKaydi
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
            this.anaMenuyeDonBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.departmanAdCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.demirbasTurCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.demirbasAdetTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.demirbasFiyatTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.demirbasAdTxt = new System.Windows.Forms.TextBox();
            this.fakulteAdCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anaMenuyeDonBtn
            // 
            this.anaMenuyeDonBtn.Location = new System.Drawing.Point(477, 160);
            this.anaMenuyeDonBtn.Name = "anaMenuyeDonBtn";
            this.anaMenuyeDonBtn.Size = new System.Drawing.Size(92, 34);
            this.anaMenuyeDonBtn.TabIndex = 0;
            this.anaMenuyeDonBtn.Text = "ANA MENÜYE DÖN";
            this.anaMenuyeDonBtn.UseVisualStyleBackColor = true;
            this.anaMenuyeDonBtn.Click += new System.EventHandler(this.anaMenuyeDonBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.kaydetBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.departmanAdCmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.demirbasTurCmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.demirbasAdetTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.demirbasFiyatTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.demirbasAdTxt);
            this.groupBox1.Controls.Add(this.fakulteAdCmb);
            this.groupBox1.Controls.Add(this.anaMenuyeDonBtn);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEMİRBAŞ KAYIT";
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(330, 160);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(92, 34);
            this.kaydetBtn.TabIndex = 16;
            this.kaydetBtn.Text = "KAYDET";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departman Adı:";
            // 
            // departmanAdCmb
            // 
            this.departmanAdCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmanAdCmb.FormattingEnabled = true;
            this.departmanAdCmb.Location = new System.Drawing.Point(417, 37);
            this.departmanAdCmb.Name = "departmanAdCmb";
            this.departmanAdCmb.Size = new System.Drawing.Size(152, 21);
            this.departmanAdCmb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Demirbaş Türü:";
            // 
            // demirbasTurCmb
            // 
            this.demirbasTurCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demirbasTurCmb.FormattingEnabled = true;
            this.demirbasTurCmb.Items.AddRange(new object[] {
            "Monitör",
            "Klavye",
            "Fare",
            "Masa",
            "Sandalye",
            "Projektör"});
            this.demirbasTurCmb.Location = new System.Drawing.Point(417, 77);
            this.demirbasTurCmb.Name = "demirbasTurCmb";
            this.demirbasTurCmb.Size = new System.Drawing.Size(152, 21);
            this.demirbasTurCmb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fakülte Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Demirbaş Adeti:";
            // 
            // demirbasAdetTxt
            // 
            this.demirbasAdetTxt.Location = new System.Drawing.Point(100, 117);
            this.demirbasAdetTxt.Name = "demirbasAdetTxt";
            this.demirbasAdetTxt.Size = new System.Drawing.Size(152, 20);
            this.demirbasAdetTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Demirbaş Fiyatı:";
            // 
            // demirbasFiyatTxt
            // 
            this.demirbasFiyatTxt.Location = new System.Drawing.Point(100, 77);
            this.demirbasFiyatTxt.Name = "demirbasFiyatTxt";
            this.demirbasFiyatTxt.Size = new System.Drawing.Size(152, 20);
            this.demirbasFiyatTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demirbaş Adı:";
            // 
            // demirbasAdTxt
            // 
            this.demirbasAdTxt.Location = new System.Drawing.Point(100, 37);
            this.demirbasAdTxt.Name = "demirbasAdTxt";
            this.demirbasAdTxt.Size = new System.Drawing.Size(152, 20);
            this.demirbasAdTxt.TabIndex = 3;
            // 
            // fakulteAdCmb
            // 
            this.fakulteAdCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fakulteAdCmb.FormattingEnabled = true;
            this.fakulteAdCmb.Items.AddRange(new object[] {
            "Teknoloji",
            "Mühendislik"});
            this.fakulteAdCmb.Location = new System.Drawing.Point(100, 157);
            this.fakulteAdCmb.Name = "fakulteAdCmb";
            this.fakulteAdCmb.Size = new System.Drawing.Size(152, 21);
            this.fakulteAdCmb.TabIndex = 4;
            this.fakulteAdCmb.SelectedValueChanged += new System.EventHandler(this.fakulteAdCmb_SelectedValueChanged);
            // 
            // StokKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 230);
            this.Controls.Add(this.groupBox1);
            this.Name = "StokKaydi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button anaMenuyeDonBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox demirbasAdTxt;
        private System.Windows.Forms.ComboBox fakulteAdCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox demirbasAdetTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox demirbasFiyatTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmanAdCmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox demirbasTurCmb;
    }
}