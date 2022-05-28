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
            this.BtnUredi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDostupna = new System.Windows.Forms.CheckBox();
            this.cbxPretrazivanje = new System.Windows.Forms.ComboBox();
            this.cbxOgranicen = new System.Windows.Forms.CheckBox();
            this.cbxVrsta = new System.Windows.Forms.ComboBox();
            this.cboSektor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmjestajneJedinice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSmjestajneJedinice
            // 
            this.DgvSmjestajneJedinice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSmjestajneJedinice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSmjestajneJedinice.Location = new System.Drawing.Point(12, 52);
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
            this.BtnObrisi.Location = new System.Drawing.Point(12, 594);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(151, 37);
            this.BtnObrisi.TabIndex = 4;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(12, 551);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(151, 37);
            this.BtnUredi.TabIndex = 5;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(243, 26);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(167, 20);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pretraživanje po:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxDostupna
            // 
            this.cbxDostupna.AutoSize = true;
            this.cbxDostupna.Enabled = false;
            this.cbxDostupna.Location = new System.Drawing.Point(243, 28);
            this.cbxDostupna.Name = "cbxDostupna";
            this.cbxDostupna.Size = new System.Drawing.Size(72, 17);
            this.cbxDostupna.TabIndex = 8;
            this.cbxDostupna.Text = "Dostupna";
            this.cbxDostupna.UseVisualStyleBackColor = true;
            this.cbxDostupna.CheckedChanged += new System.EventHandler(this.cbxDostupna_CheckedChanged);
            // 
            // cbxPretrazivanje
            // 
            this.cbxPretrazivanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPretrazivanje.FormattingEnabled = true;
            this.cbxPretrazivanje.Items.AddRange(new object[] {
            "OznakaSJ",
            "Kapacitet",
            "Vrsta",
            "Sektor",
            "Dostupna"});
            this.cbxPretrazivanje.Location = new System.Drawing.Point(94, 26);
            this.cbxPretrazivanje.Name = "cbxPretrazivanje";
            this.cbxPretrazivanje.Size = new System.Drawing.Size(121, 21);
            this.cbxPretrazivanje.TabIndex = 10;
            this.cbxPretrazivanje.SelectedIndexChanged += new System.EventHandler(this.cbxPretrazivanje_SelectedIndexChanged);
            // 
            // cbxOgranicen
            // 
            this.cbxOgranicen.AutoSize = true;
            this.cbxOgranicen.Location = new System.Drawing.Point(416, 28);
            this.cbxOgranicen.Name = "cbxOgranicen";
            this.cbxOgranicen.Size = new System.Drawing.Size(96, 17);
            this.cbxOgranicen.TabIndex = 11;
            this.cbxOgranicen.Text = "Nije Ograničen";
            this.cbxOgranicen.UseVisualStyleBackColor = true;
            this.cbxOgranicen.CheckedChanged += new System.EventHandler(this.cbxOgranicen_CheckedChanged);
            // 
            // cbxVrsta
            // 
            this.cbxVrsta.AutoCompleteCustomSource.AddRange(new string[] {
            "Mobilna Kucica",
            "Parcela",
            "Šator"});
            this.cbxVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVrsta.FormattingEnabled = true;
            this.cbxVrsta.Items.AddRange(new object[] {
            "Mobilna Kucica",
            "Parcela",
            "Šator"});
            this.cbxVrsta.Location = new System.Drawing.Point(243, 25);
            this.cbxVrsta.Name = "cbxVrsta";
            this.cbxVrsta.Size = new System.Drawing.Size(121, 21);
            this.cbxVrsta.TabIndex = 12;
            this.cbxVrsta.SelectedIndexChanged += new System.EventHandler(this.cbxVrsta_SelectedIndexChanged);
            // 
            // cboSektor
            // 
            this.cboSektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSektor.FormattingEnabled = true;
            this.cboSektor.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "D1",
            "D2",
            "D3"});
            this.cboSektor.Location = new System.Drawing.Point(243, 25);
            this.cboSektor.Name = "cboSektor";
            this.cboSektor.Size = new System.Drawing.Size(121, 21);
            this.cboSektor.TabIndex = 13;
            this.cboSektor.SelectedIndexChanged += new System.EventHandler(this.cboSektor_SelectedIndexChanged);
            // 
            // FrmSmjestajneJedinice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 644);
            this.Controls.Add(this.cboSektor);
            this.Controls.Add(this.cbxVrsta);
            this.Controls.Add(this.cbxOgranicen);
            this.Controls.Add(this.cbxPretrazivanje);
            this.Controls.Add(this.cbxDostupna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.BtnUredi);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSmjestajneJedinice;
        private System.Windows.Forms.Button BtnSj;
        private System.Windows.Forms.Button BtnRezervacija;
        private System.Windows.Forms.Button BtnOdjava;
        private System.Windows.Forms.Button BtnObrisi;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxDostupna;
        private System.Windows.Forms.ComboBox cbxPretrazivanje;
        private System.Windows.Forms.CheckBox cbxOgranicen;
        private System.Windows.Forms.ComboBox cbxVrsta;
        private System.Windows.Forms.ComboBox cboSektor;
    }
}

