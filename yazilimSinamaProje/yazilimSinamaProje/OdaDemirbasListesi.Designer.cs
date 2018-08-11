namespace yazilimSinamaProje
{
    partial class OdaDemirbasListesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.aranacakOdaTxt = new System.Windows.Forms.TextBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.ciktiAlBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.durumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anaMenuyeDonBtn
            // 
            this.anaMenuyeDonBtn.Location = new System.Drawing.Point(70, 178);
            this.anaMenuyeDonBtn.Name = "anaMenuyeDonBtn";
            this.anaMenuyeDonBtn.Size = new System.Drawing.Size(88, 42);
            this.anaMenuyeDonBtn.TabIndex = 0;
            this.anaMenuyeDonBtn.Text = "ANA MENÜYE DÖN";
            this.anaMenuyeDonBtn.UseVisualStyleBackColor = true;
            this.anaMenuyeDonBtn.Click += new System.EventHandler(this.anaMenuyeDonBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oda Adı:";
            // 
            // aranacakOdaTxt
            // 
            this.aranacakOdaTxt.Location = new System.Drawing.Point(86, 24);
            this.aranacakOdaTxt.Name = "aranacakOdaTxt";
            this.aranacakOdaTxt.Size = new System.Drawing.Size(100, 20);
            this.aranacakOdaTxt.TabIndex = 2;
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(86, 50);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(57, 26);
            this.araBtn.TabIndex = 3;
            this.araBtn.Text = "ARA";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // ciktiAlBtn
            // 
            this.ciktiAlBtn.Location = new System.Drawing.Point(70, 130);
            this.ciktiAlBtn.Name = "ciktiAlBtn";
            this.ciktiAlBtn.Size = new System.Drawing.Size(88, 42);
            this.ciktiAlBtn.TabIndex = 4;
            this.ciktiAlBtn.Text = "ÇIKTI AL";
            this.ciktiAlBtn.UseVisualStyleBackColor = true;
            this.ciktiAlBtn.Visible = false;
            this.ciktiAlBtn.Click += new System.EventHandler(this.ciktiAlBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Durum:";
            // 
            // durumLbl
            // 
            this.durumLbl.AutoSize = true;
            this.durumLbl.Location = new System.Drawing.Point(83, 88);
            this.durumLbl.Name = "durumLbl";
            this.durumLbl.Size = new System.Drawing.Size(85, 13);
            this.durumLbl.TabIndex = 6;
            this.durumLbl.Text = "Arama Yapılmadı";
            // 
            // OdaDemirbasListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(213, 232);
            this.Controls.Add(this.durumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciktiAlBtn);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.aranacakOdaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anaMenuyeDonBtn);
            this.Name = "OdaDemirbasListesi";
            this.Text = "OdaDemirbasListesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anaMenuyeDonBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aranacakOdaTxt;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Button ciktiAlBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label durumLbl;
    }
}