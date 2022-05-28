namespace Camp_Renting_Manager
{
    partial class FrmUnosSJ
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
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKapacitet = new System.Windows.Forms.NumericUpDown();
            this.cboVrsta = new System.Windows.Forms.ComboBox();
            this.cboSektor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(110, 217);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(87, 36);
            this.BtnSpremi.TabIndex = 0;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(316, 217);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(87, 36);
            this.BtnOdustani.TabIndex = 1;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kapacitet:";
            // 
            // nudKapacitet
            // 
            this.nudKapacitet.Location = new System.Drawing.Point(76, 133);
            this.nudKapacitet.Name = "nudKapacitet";
            this.nudKapacitet.Size = new System.Drawing.Size(120, 20);
            this.nudKapacitet.TabIndex = 8;
            // 
            // cboVrsta
            // 
            this.cboVrsta.FormattingEnabled = true;
            this.cboVrsta.Items.AddRange(new object[] {
            "Mobilna Kucica",
            "Parcela",
            "Šator"});
            this.cboVrsta.Location = new System.Drawing.Point(76, 57);
            this.cboVrsta.Name = "cboVrsta";
            this.cboVrsta.Size = new System.Drawing.Size(121, 21);
            this.cboVrsta.TabIndex = 9;
            this.cboVrsta.SelectedIndexChanged += new System.EventHandler(this.cboVrsta_SelectedIndexChanged);
            // 
            // cboSektor
            // 
            this.cboSektor.FormattingEnabled = true;
            this.cboSektor.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "D1",
            "D2",
            "D3"});
            this.cboSektor.Location = new System.Drawing.Point(316, 57);
            this.cboSektor.Name = "cboSektor";
            this.cboSektor.Size = new System.Drawing.Size(121, 21);
            this.cboSektor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vrsta Smještajne jedinice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sektor: ";
            // 
            // FrmUnosSJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 294);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSektor);
            this.Controls.Add(this.cboVrsta);
            this.Controls.Add(this.nudKapacitet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Name = "FrmUnosSJ";
            this.Text = "Unos nove smještajne jedinice";
            this.Load += new System.EventHandler(this.FrmUnosSJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKapacitet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKapacitet;
        private System.Windows.Forms.ComboBox cboVrsta;
        private System.Windows.Forms.ComboBox cboSektor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}