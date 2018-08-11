namespace yazilimSinamaProje
{
    partial class PersonelDemirbas
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
            this.araBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personelAdTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // anaMenuyeDonBtn
            // 
            this.anaMenuyeDonBtn.Location = new System.Drawing.Point(267, 14);
            this.anaMenuyeDonBtn.Name = "anaMenuyeDonBtn";
            this.anaMenuyeDonBtn.Size = new System.Drawing.Size(96, 37);
            this.anaMenuyeDonBtn.TabIndex = 0;
            this.anaMenuyeDonBtn.Text = "ANA MENÜYE DÖN";
            this.anaMenuyeDonBtn.UseVisualStyleBackColor = true;
            this.anaMenuyeDonBtn.Click += new System.EventHandler(this.anaMenuyeDonBtn_Click);
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(186, 14);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(75, 23);
            this.araBtn.TabIndex = 1;
            this.araBtn.Text = "ARA";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel Ad:";
            // 
            // personelAdTxt
            // 
            this.personelAdTxt.Location = new System.Drawing.Point(80, 16);
            this.personelAdTxt.Name = "personelAdTxt";
            this.personelAdTxt.Size = new System.Drawing.Size(100, 20);
            this.personelAdTxt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // PersonelDemirbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(385, 242);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.personelAdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.anaMenuyeDonBtn);
            this.Name = "PersonelDemirbas";
            this.Text = "PERSONEL ÜZERİNDEKİ DEMİRBAŞLAR";
            this.Load += new System.EventHandler(this.PersonelDemirbas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anaMenuyeDonBtn;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personelAdTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}