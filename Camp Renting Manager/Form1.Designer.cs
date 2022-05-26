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
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmjestajneJedinice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSmjestajneJedinice
            // 
            this.DgvSmjestajneJedinice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSmjestajneJedinice.Location = new System.Drawing.Point(12, 12);
            this.DgvSmjestajneJedinice.Name = "DgvSmjestajneJedinice";
            this.DgvSmjestajneJedinice.Size = new System.Drawing.Size(1050, 585);
            this.DgvSmjestajneJedinice.TabIndex = 0;
            // 
            // FrmSmjestajneJedinice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 751);
            this.Controls.Add(this.DgvSmjestajneJedinice);
            this.Name = "FrmSmjestajneJedinice";
            this.Text = "Pregled smještajnih jedinica";
            this.Load += new System.EventHandler(this.FrmSmjestajneJedinice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSmjestajneJedinice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSmjestajneJedinice;
    }
}

