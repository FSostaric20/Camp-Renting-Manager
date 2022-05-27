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
        }
        private void ShowSmjestajneJedinice()
        {
            List<SmjestajnaJedinica> smjestajneJedinice = Repozitoriji.SmjestajnaJedinicaRepozitorij.GetSmjestajneJedinice();
            DgvSmjestajneJedinice.DataSource = smjestajneJedinice;
        }
    }
}
