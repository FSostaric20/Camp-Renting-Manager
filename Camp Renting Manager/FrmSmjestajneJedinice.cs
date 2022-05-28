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
    public partial class FrmSmjestajneJedinice : Form
    {
        public FrmSmjestajneJedinice()
        {
            InitializeComponent();
        }

        private void FrmSmjestajneJedinice_Load(object sender, EventArgs e)
        {
            DBLayer.DB.SetConfiguration("fsostaric20_DB", "fsostaric20", "vOze6ERT");
            ShowSmjestajneJedinice();
            cbxPretrazivanje.SelectedIndex = 0;
        }
        private void ShowSmjestajneJedinice()
        {
            List<SmjestajnaJedinica> smjestajneJedinice = Repozitoriji.SmjestajnaJedinicaRepozitorij.GetSmjestajneJedinice();
            DgvSmjestajneJedinice.DataSource = smjestajneJedinice;
        }

        private void BtnSj_Click(object sender, EventArgs e)
        {
            new FrmUnosSJ().ShowDialog();
        }

        private void BtnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            SmjestajnaJedinica SelectedSJ = DgvSmjestajneJedinice.CurrentRow.DataBoundItem as SmjestajnaJedinica;
            if (SelectedSJ != null)
            {
                Repozitoriji.SmjestajnaJedinicaRepozitorij.DeleteSmjestajnaJedinica(SelectedSJ);
            }
            ShowSmjestajneJedinice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmjestajnaJedinica SelectedSJ = DgvSmjestajneJedinice.CurrentRow.DataBoundItem as SmjestajnaJedinica;
            if (SelectedSJ != null)
            {
                FrmUrediSJ frmUrediSJ = new FrmUrediSJ(SelectedSJ);
                frmUrediSJ.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxDostupna_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cbxPretrazivanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            string Pretraga = txtPretraga.Text;
            if (cbxPretrazivanje.Text == "OznakaSJ")
            {
                cbxVrsta.Visible = false;
                cbxDostupna.Visible = false;
                cbxOgranicen.Visible = false;
                txtPretraga.Visible = true;
                cboSektor.Visible = false;
                for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                    if (Pretraga == "")
                    {
                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else if (Pretraga == DgvSmjestajneJedinice.Rows[i].Cells["OznakaSJ"].Value.ToString())
                    {

                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else
                    {
                        DgvSmjestajneJedinice.CurrentCell = null;
                        DgvSmjestajneJedinice.Rows[i].Visible = false;
                    }
            }
            else if (cbxPretrazivanje.Text == "Kapacitet")
            {
                cbxVrsta.Visible = false;
                cbxDostupna.Visible = false;
                cbxOgranicen.Visible = true;
                txtPretraga.Visible = true;
                cboSektor.Visible = false;
                if (cbxOgranicen.Checked == true)
                {
                    txtPretraga.ResetText();
                    txtPretraga.Enabled = false;
                    
                    for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                    {
                        if ("Nije ograničen" == DgvSmjestajneJedinice.Rows[i].Cells["Kapacitet"].Value.ToString())
                        {

                            DgvSmjestajneJedinice.Rows[i].Visible = true;
                        }
                        else
                        {
                            DgvSmjestajneJedinice.CurrentCell = null;
                            DgvSmjestajneJedinice.Rows[i].Visible = false;
                        }
                    }
                   
                }else{
                    txtPretraga.Enabled = true;
                    for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                        if (Pretraga == "")
                        {
                            DgvSmjestajneJedinice.Rows[i].Visible = true;
                        }
                        else if (Pretraga == DgvSmjestajneJedinice.Rows[i].Cells["Kapacitet"].Value.ToString())
                        {

                            DgvSmjestajneJedinice.Rows[i].Visible = true;
                        }
                        else
                        {
                            DgvSmjestajneJedinice.CurrentCell = null;
                            DgvSmjestajneJedinice.Rows[i].Visible = false;
                        }
                }


               
            }else if (cbxPretrazivanje.Text == "Vrsta")
            {
                cbxVrsta.Visible = true;
                cbxDostupna.Visible = false;
                cbxOgranicen.Visible = false;
                txtPretraga.Visible = false;
                cboSektor.Visible = false;
                for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                    if (cbxVrsta.Text == "")
                    {
                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else if (cbxVrsta.Text == DgvSmjestajneJedinice.Rows[i].Cells["Vrsta"].Value.ToString())
                    {

                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else
                    {
                        DgvSmjestajneJedinice.CurrentCell = null;
                        DgvSmjestajneJedinice.Rows[i].Visible = false;
                    }
            }else if (cbxPretrazivanje.Text == "Sektor")
            {
                cbxVrsta.Visible = false;
                cbxDostupna.Visible = false;
                cbxOgranicen.Visible = false;
                txtPretraga.Visible = false;
                cboSektor.Visible = true;
                for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                    if (cboSektor.Text == "")
                    {
                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else if (cboSektor.Text == DgvSmjestajneJedinice.Rows[i].Cells["Sektor"].Value.ToString())
                    {

                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }
                    else
                    {
                        DgvSmjestajneJedinice.CurrentCell = null;
                        DgvSmjestajneJedinice.Rows[i].Visible = false;
                    }
            }
            else if(cbxPretrazivanje.Text == "Dostupna")
            {
                cbxVrsta.Visible = false;
                cbxDostupna.Visible = true;
                cbxOgranicen.Visible = false;
                txtPretraga.Visible = false;
                cboSektor.Visible = false;
                cbxDostupna.Enabled = true;
                for (int i = 0; i < DgvSmjestajneJedinice.Rows.Count; i++)
                    if ( cbxDostupna.Checked==(bool)DgvSmjestajneJedinice.Rows[i].Cells["Dostupna"].Value)
                    {
                        DgvSmjestajneJedinice.Rows[i].Visible = true;
                    }else
                    {
                        DgvSmjestajneJedinice.CurrentCell = null;
                        DgvSmjestajneJedinice.Rows[i].Visible = false;
                    }
            }
            
            
            
        }

        private void cbxVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cbxOgranicen_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cboSektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
    }
}
