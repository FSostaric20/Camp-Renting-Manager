namespace Camp_Renting_Manager
{
    partial class FrmSmjestajneJedinice
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
            this.DgvSmjestajneJedinice = new System.Windows.Forms.DataGridView();
            this.BtnSj = new System.Windows.Forms.Button();
            this.BtnRezervacija = new System.Windows.Forms.Button();
            this.BtnOdjava = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmjestajneJedinice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSmjestajneJedinice
            // 
            this.DgvSmjestajneJedinice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSmjestajneJedinice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSmjestajneJedinice.Location = new System.Drawing.Point(12, 12);
            this.DgvSmjestajneJedinice.Name = "DgvSmjestajneJedinice";
            this.DgvSmjestajneJedinice.Size = new System.Drawing.Size(826, 450);
            this.DgvSmjestajneJedinice.TabIndex = 0;
            // 
            // BtnSj
            // 
            this.BtnSj.Location = new System.Drawing.Point(687, 508);
            this.BtnSj.Name = "BtnSj";
            this.BtnSj.Size = new System.Drawing.Size(151, 37);
            this.BtnSj.TabIndex = 1;
            this.BtnSj.Text = "Nova smještajna jedinica";
            this.BtnSj.UseVisualStyleBackColor = true;
            this.BtnSj.Click += new System.EventHandler(this.BtnSj_Click);
            // 
            // BtnRezervacija
            // 
            this.BtnRezervacija.Location = new System.Drawing.Point(687, 551);
            this.BtnRezervacija.Name = "BtnRezervacija";
            this.BtnRezervacija.Size = new System.Drawing.Size(151, 37);
            this.BtnRezervacija.TabIndex = 2;
            this.BtnRezervacija.Text = "Nova rezervacija";
            this.BtnRezervacija.UseVisualStyleBackColor = true;
            // 
            // BtnOdjava
            // 
            this.BtnOdjava.Location = new System.Drawing.Point(687, 594);
            this.BtnOdjava.Name = "BtnOdjava";
            this.BtnOdjava.Size = new System.Drawing.Size(151, 37);
            this.BtnOdjava.TabIndex = 3;
            this.BtnOdjava.Text = "Odjava";
            this.BtnOdjava.UseVisualStyleBackColor = true;
            this.BtnOdjava.Click += new System.EventHandler(this.BtnOdjava_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Location = new System.Drawing.Point(12, 508);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(151, 37);
            this.BtnObrisi.TabIndex = 4;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // FrmSmjestajneJedinice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 644);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnOdjava);
            this.Controls.Add(this.BtnRezervacija);
            this.Controls.Add(this.BtnSj);
            this.Controls.Add(this.DgvSmjestajneJedinice);
            this.Name = "FrmSmjestajneJedinice";
            this.Text = "Pregled smještajnih jedinica";
            this.Activated += new System.EventHandler(this.FrmSmjestajneJedinice_Load);
            this.Load += new System.EventHandler(this.FrmSmjestajneJedinice_Load);
            this.Enter += new System.EventHandler(this.FrmSmjestajneJedinice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmjestajneJedinice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSmjestajneJedinice;
        private System.Windows.Forms.Button BtnSj;
        private System.Windows.Forms.Button BtnRezervacija;
        private System.Windows.Forms.Button BtnOdjava;
        private System.Windows.Forms.Button BtnObrisi;
    }
}

