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
            string sql = "SELECT * FROM Students";
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
            int kapacitet = int.Parse(reader["Kapacitet"].ToString());
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
    }
}
