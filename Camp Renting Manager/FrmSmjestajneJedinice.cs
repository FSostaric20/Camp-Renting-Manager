﻿using System;
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
    }
}