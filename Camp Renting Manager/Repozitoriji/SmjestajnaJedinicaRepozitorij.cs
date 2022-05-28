using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp_Renting_Manager.Repozitoriji
{
    public class SmjestajnaJedinicaRepozitorij
    {
        
        public static SmjestajnaJedinica GetSmjestajnaJedinica(int id)
        {
            SmjestajnaJedinica smjestajnaJedinica = null;
            DBLayer.DB.SetConfiguration("fsostaric20_DB", "fsostaric20", "vOze6ERT");
            string sql = $"SELECT * FROM SmjestajneJedinice WHERE OznakaSJ = {id}";
            DBLayer.DB.OpenConnection();
            var reader = DBLayer.DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                smjestajnaJedinica = CreateObject(reader);
                reader.Close();
            }
            DBLayer.DB.CloseConnection();
            return smjestajnaJedinica;
        }

        public static List<SmjestajnaJedinica> GetSmjestajneJedinice()
        {
            List<SmjestajnaJedinica> SmjestajneJedinice = new List<SmjestajnaJedinica>();
            string sql = "SELECT * FROM SmjestajneJedinice";
            DBLayer.DB.OpenConnection();
            var reader = DBLayer.DB.GetDataReader(sql);
            while (reader.Read())
            {
                SmjestajnaJedinica smjestajnaJedinica = CreateObject(reader);
                SmjestajneJedinice.Add(smjestajnaJedinica);
                
            }
            reader.Close();
            DBLayer.DB.CloseConnection();
            return SmjestajneJedinice;
        }

        private static SmjestajnaJedinica CreateObject(SqlDataReader reader)
        {
            int oznakaSJ = int.Parse(reader["OznakaSJ"].ToString());
            string kapacitet;
            if (reader["Kapacitet"].ToString() == "" || reader["Kapacitet"].ToString() == "0")
            {
                kapacitet = "Nije ograničen";

            }
            else {
                kapacitet = reader["Kapacitet"].ToString();
            }
            
            string vrsta = reader["Vrsta"].ToString();
            string sektor = reader["Sektor"].ToString();
            bool dostupna = (bool)reader["Dostupna"];
            var smjestajnaJedinica =new SmjestajnaJedinica
            {
                OznakaSJ = oznakaSJ,
                Kapacitet = kapacitet,
                Vrsta = vrsta,
                Sektor = sektor,
                Dostupna = dostupna
            };
            return smjestajnaJedinica;

        }
        
        public static void InsertSmjestajnaJedinica(string Sektor, string Vrsta, string Kapacitet)
        {
            string sql ="";
            int kap = int.Parse(Kapacitet);
            int NajvecaOznaka = 1;
            bool Dostupna = true;
            List<SmjestajnaJedinica> popis = GetSmjestajneJedinice();
            foreach(SmjestajnaJedinica smjestajnajedinica in popis)
            {
                NajvecaOznaka++;
            }
            if (kap != 0)
            {
                sql += $"INSERT INTO SmjestajneJedinice (OznakaSJ,Kapacitet,Vrsta,Sektor,Dostupna) VALUES ('{NajvecaOznaka}','{kap}','{Vrsta}','{Sektor}',+'{Dostupna}')";
            }
            else
            {
                
                sql = $"INSERT INTO SmjestajneJedinice (OznakaSJ,Kapacitet,Vrsta,Sektor,Dostupna) VALUES ('{NajvecaOznaka}','','{Vrsta}','{Sektor}',+'{Dostupna}')";
            }
            
            
            DBLayer.DB.OpenConnection();
            DBLayer.DB.ExecuteCommand(sql);
            DBLayer.DB.CloseConnection();
        }

        public static void DeleteSmjestajnaJedinica(SmjestajnaJedinica SJ)
        {
            int ID = SJ.OznakaSJ;
            string sql = $"DELETE FROM SmjestajneJedinice WHERE OznakaSJ = {ID}";
            DBLayer.DB.OpenConnection();
            DBLayer.DB.ExecuteCommand(sql);
            DBLayer.DB.CloseConnection();
        }
    }
}
