using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camp_Renting_Manager
{
    public partial class FrmUrediSJ : Form
    {
        private SmjestajnaJedinica smjestajnaJedinica;
        public FrmUrediSJ(SmjestajnaJedinica SJ)
        {
            InitializeComponent();
            smjestajnaJedinica = SJ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            SmjestajnaJedinica SJ = new SmjestajnaJedinica {
                OznakaSJ = smjestajnaJedinica.OznakaSJ,
                Vrsta = CboVrsta.Text,
                Sektor = CboSektor.Text,
                Dostupna = smjestajnaJedinica.Dostupna,
                Kapacitet = NudKapacitet.Value.ToString()

            };
            Repozitoriji.SmjestajnaJedinicaRepozitorij.UpdateSmjestajnaJedinica(SJ);
            Close();
        }

        private void FrmUrediSJ_Load(object sender, EventArgs e)
        {
            if (smjestajnaJedinica.Vrsta == "Mobilna Kucica")
            {
                CboVrsta.SelectedIndex = 0;
            }
            else if (smjestajnaJedinica.Vrsta == "Šator")
            {
                CboVrsta.SelectedIndex = 2;
            }
            else if (smjestajnaJedinica.Vrsta == "Parcela")
            {
                CboVrsta.SelectedIndex = 1;
            }


            if(smjestajnaJedinica.Kapacitet=="Nije ograničen")
            {
                NudKapacitet.Value = 0;
            }
            else
            {
                NudKapacitet.Value = int.Parse(smjestajnaJedinica.Kapacitet);
            }
           
            TxtOznakaSJ.Text= smjestajnaJedinica.OznakaSJ.ToString();
            CboSektor.Text = smjestajnaJedinica.Sektor;
            CboVrsta_SelectedIndexChanged(this, e);
        }

        private void CboVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            if (CboVrsta.SelectedIndex == 0)
            {
                NudKapacitet.Enabled = true;
                NudKapacitet.Value = 1;
                NudKapacitet.Maximum = 6;
                NudKapacitet.Minimum = 1;
            }
            else if (CboVrsta.SelectedIndex == 2)
            {
                NudKapacitet.Enabled = true;
                NudKapacitet.Value = 1;
                NudKapacitet.Maximum = 8;
                NudKapacitet.Minimum = 1;
            }
            else if (CboVrsta.SelectedIndex == 1)
            {
                NudKapacitet.Enabled = false;
                NudKapacitet.Minimum = 0;
                NudKapacitet.Value = 0;
            }
        }
    }
    }

