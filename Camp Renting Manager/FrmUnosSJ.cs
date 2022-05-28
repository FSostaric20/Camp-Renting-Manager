using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camp_Renting_Manager.Repozitoriji;

namespace Camp_Renting_Manager
{
    public partial class FrmUnosSJ : Form
    {
        public FrmUnosSJ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            string Kapacitet = nudKapacitet.Value.ToString();
            if (cboSektor.Text == "")
            {
                MessageBox.Show("Nije odabran sektor", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
            SmjestajnaJedinicaRepozitorij.InsertSmjestajnaJedinica(cboSektor.Text, cboVrsta.Text, Kapacitet);
            this.Close();
        }

        private void cboVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVrsta.SelectedIndex == 0)
            {
                nudKapacitet.Enabled = true;
                nudKapacitet.Value = 1;
                nudKapacitet.Maximum = 6;
                nudKapacitet.Minimum = 1;
            }
            else if (cboVrsta.SelectedIndex == 2)
            {
                nudKapacitet.Enabled = true;
                nudKapacitet.Value = 1;
                nudKapacitet.Maximum = 8;
                nudKapacitet.Minimum = 1;
            }
            else if (cboVrsta.SelectedIndex == 1)
            {
                nudKapacitet.Enabled = false;
                nudKapacitet.Minimum = 0;
                nudKapacitet.Value = 0;
            }
        }

        private void FrmUnosSJ_Load(object sender, EventArgs e)
        {
            cboVrsta.SelectedIndex = 0;
            cboVrsta_SelectedIndexChanged(this,e);
        }
    }
}
