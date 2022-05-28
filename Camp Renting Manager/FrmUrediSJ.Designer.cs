namespace Camp_Renting_Manager
{
    partial class FrmUrediSJ
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
            this.TxtOznakaSJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.CboVrsta = new System.Windows.Forms.ComboBox();
            this.CboSektor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NudKapacitet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudKapacitet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOznakaSJ
            // 
            this.TxtOznakaSJ.Enabled = false;
            this.TxtOznakaSJ.Location = new System.Drawing.Point(45, 70);
            this.TxtOznakaSJ.Name = "TxtOznakaSJ";
            this.TxtOznakaSJ.Size = new System.Drawing.Size(135, 20);
            this.TxtOznakaSJ.TabIndex = 0;
            this.TxtOznakaSJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka smještajne jedinice:";
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(105, 216);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(75, 23);
            this.BtnSpremi.TabIndex = 2;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(282, 216);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(75, 23);
            this.BtnOdustani.TabIndex = 3;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // CboVrsta
            // 
            this.CboVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVrsta.FormattingEnabled = true;
            this.CboVrsta.Items.AddRange(new object[] {
            "Mobilna Kucica",
            "Parcela",
            "Šator"});
            this.CboVrsta.Location = new System.Drawing.Point(282, 69);
            this.CboVrsta.Name = "CboVrsta";
            this.CboVrsta.Size = new System.Drawing.Size(153, 21);
            this.CboVrsta.TabIndex = 4;
            this.CboVrsta.SelectedIndexChanged += new System.EventHandler(this.CboVrsta_SelectedIndexChanged);
            // 
            // CboSektor
            // 
            this.CboSektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSektor.FormattingEnabled = true;
            this.CboSektor.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "D1",
            "D2",
            "D3"});
            this.CboSektor.Location = new System.Drawing.Point(282, 144);
            this.CboSektor.Name = "CboSektor";
            this.CboSektor.Size = new System.Drawing.Size(153, 21);
            this.CboSektor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vrsta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kapacitet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sektor:";
            // 
            // NudKapacitet
            // 
            this.NudKapacitet.Location = new System.Drawing.Point(45, 145);
            this.NudKapacitet.Name = "NudKapacitet";
            this.NudKapacitet.Size = new System.Drawing.Size(135, 20);
            this.NudKapacitet.TabIndex = 10;
            // 
            // FrmUrediSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 309);
            this.Controls.Add(this.NudKapacitet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboSektor);
            this.Controls.Add(this.CboVrsta);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOznakaSJ);
            this.Name = "FrmUrediSJ";
            this.Text = "Uredi smještajnu jedinicu";
            this.Load += new System.EventHandler(this.FrmUrediSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudKapacitet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOznakaSJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.ComboBox CboVrsta;
        private System.Windows.Forms.ComboBox CboSektor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudKapacitet;
    }
}