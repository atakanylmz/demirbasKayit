namespace yazilimSinamaProje
{
    partial class OdaDemirbasIslem
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
            this.atamaGbx = new System.Windows.Forms.GroupBox();
            this.zimmetPersonelCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.atanacakDemirbasAdediTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atamaYapBtn = new System.Windows.Forms.Button();
            this.atanacakDemirbasIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anaMenuyeDonBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.aranacakOdaTxt = new System.Windows.Forms.TextBox();
            this.odaAraBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.atamaGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.atamaGbx);
            this.groupBox1.Controls.Add(this.anaMenuyeDonBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aranacakOdaTxt);
            this.groupBox1.Controls.Add(this.odaAraBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ODA ARAMA";
            // 
            // atamaGbx
            // 
            this.atamaGbx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.atamaGbx.Controls.Add(this.zimmetPersonelCmb);
            this.atamaGbx.Controls.Add(this.label5);
            this.atamaGbx.Controls.Add(this.atanacakDemirbasAdediTxt);
            this.atamaGbx.Controls.Add(this.label4);
            this.atamaGbx.Controls.Add(this.atamaYapBtn);
            this.atamaGbx.Controls.Add(this.atanacakDemirbasIdTxt);
            this.atamaGbx.Controls.Add(this.label2);
            this.atamaGbx.Location = new System.Drawing.Point(366, 68);
            this.atamaGbx.Name = "atamaGbx";
            this.atamaGbx.Size = new System.Drawing.Size(238, 150);
            this.atamaGbx.TabIndex = 8;
            this.atamaGbx.TabStop = false;
            this.atamaGbx.Text = "DEMİRBAŞ ATAMA";
            this.atamaGbx.Visible = false;
            // 
            // zimmetPersonelCmb
            // 
            this.zimmetPersonelCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zimmetPersonelCmb.FormattingEnabled = true;
            this.zimmetPersonelCmb.Items.AddRange(new object[] {
            "Ahmet",
            "Burak",
            "Cenk",
            "Ekrem",
            "Faruk",
            "Boş"});
            this.zimmetPersonelCmb.Location = new System.Drawing.Point(146, 77);
            this.zimmetPersonelCmb.Name = "zimmetPersonelCmb";
            this.zimmetPersonelCmb.Size = new System.Drawing.Size(86, 21);
            this.zimmetPersonelCmb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zimmetlenecek Personel:";
            // 
            // atanacakDemirbasAdediTxt
            // 
            this.atanacakDemirbasAdediTxt.Location = new System.Drawing.Point(146, 47);
            this.atanacakDemirbasAdediTxt.Name = "atanacakDemirbasAdediTxt";
            this.atanacakDemirbasAdediTxt.Size = new System.Drawing.Size(86, 20);
            this.atanacakDemirbasAdediTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Atanacak Demirbaş Adedi:";
            // 
            // atamaYapBtn
            // 
            this.atamaYapBtn.Location = new System.Drawing.Point(146, 115);
            this.atamaYapBtn.Name = "atamaYapBtn";
            this.atamaYapBtn.Size = new System.Drawing.Size(86, 29);
            this.atamaYapBtn.TabIndex = 7;
            this.atamaYapBtn.Text = "ATAMA YAP";
            this.atamaYapBtn.UseVisualStyleBackColor = true;
            this.atamaYapBtn.Click += new System.EventHandler(this.atamaYapBtn_Click);
            // 
            // atanacakDemirbasIdTxt
            // 
            this.atanacakDemirbasIdTxt.Location = new System.Drawing.Point(146, 17);
            this.atanacakDemirbasIdTxt.Name = "atanacakDemirbasIdTxt";
            this.atanacakDemirbasIdTxt.Size = new System.Drawing.Size(86, 20);
            this.atanacakDemirbasIdTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Atanacak Demirbaş Id:";
            // 
            // anaMenuyeDonBtn
            // 
            this.anaMenuyeDonBtn.Location = new System.Drawing.Point(502, 19);
            this.anaMenuyeDonBtn.Name = "anaMenuyeDonBtn";
            this.anaMenuyeDonBtn.Size = new System.Drawing.Size(102, 40);
            this.anaMenuyeDonBtn.TabIndex = 6;
            this.anaMenuyeDonBtn.Text = "ANA MENÜYE DÖN";
            this.anaMenuyeDonBtn.UseVisualStyleBackColor = true;
            this.anaMenuyeDonBtn.Click += new System.EventHandler(this.anaMenuyeDonBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odanın bulunduğu Departmandaki Stoklar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranacak Oda Adı:";
            // 
            // aranacakOdaTxt
            // 
            this.aranacakOdaTxt.Location = new System.Drawing.Point(126, 21);
            this.aranacakOdaTxt.Name = "aranacakOdaTxt";
            this.aranacakOdaTxt.Size = new System.Drawing.Size(149, 20);
            this.aranacakOdaTxt.TabIndex = 2;
            // 
            // odaAraBtn
            // 
            this.odaAraBtn.Location = new System.Drawing.Point(281, 19);
            this.odaAraBtn.Name = "odaAraBtn";
            this.odaAraBtn.Size = new System.Drawing.Size(79, 23);
            this.odaAraBtn.TabIndex = 3;
            this.odaAraBtn.Text = "ARA";
            this.odaAraBtn.UseVisualStyleBackColor = true;
            this.odaAraBtn.Click += new System.EventHandler(this.odaAraBtn_Click);
            // 
            // OdaDemirbasIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(639, 255);
            this.Controls.Add(this.groupBox1);
            this.Name = "OdaDemirbasIslem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.atamaGbx.ResumeLayout(false);
            this.atamaGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranacakOdaTxt;
        private System.Windows.Forms.Button odaAraBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox atanacakDemirbasIdTxt;
        private System.Windows.Forms.Button atamaYapBtn;
        private System.Windows.Forms.GroupBox atamaGbx;
        private System.Windows.Forms.TextBox atanacakDemirbasAdediTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button anaMenuyeDonBtn;
        private System.Windows.Forms.ComboBox zimmetPersonelCmb;
        private System.Windows.Forms.Label label5;
    }
}