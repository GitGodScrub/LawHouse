using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Singletone er blevet brugt nedenunder og i kontrolleren
    //A singleton is a convenient way for accessing the service from anywhere in the application code
    public class DatabaseHandler : IDatabase
    {
        private static DatabaseHandler _database = null;//By Daniella
        private DatabaseHandler() { }
        public static DatabaseHandler Instance()
        {
            if (_database == null)
            {
                _database = new DatabaseHandler();

            }
            return _database;
        }
        private void RunSqlCommand(string commandToRun) //By Daniella, refactored by Julius
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    try
                    {
                        conn.Open();
                        com.CommandText = commandToRun;
                        com.ExecuteNonQuery();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void CreateSag(Sag c)// By Daniella
        //Grunden til at der den her er fordi den tager en case og opretter det ud for properties
        {
            string sqlString = $"insert into Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , KlientNr, AdvokatId, YdelsesTypeNr )" + $"values('{c.Arbejdstitel}' , '{c.StartDato}' ,'{c.SlutDato}' ,'{c.Kørselstimer}' ,'{c.TimeEstimat}' , '{c.SagsBeskrivelse}',  '{c.InterneNoter}' , '{c.KlientNr}', {c.AdvokatId}, {c.YdelsesTypeNr})";
            RunSqlCommand(sqlString);
        }
        public void UpdateSag(Sag @case)// By Daniella, refactored by Julius
        {
            string sqlString =
                $"update Sag set Arbejdstitel = '{@case.Arbejdstitel}', StartDato = '{@case.StartDato}', SlutDato = '{@case.SlutDato}', Kørselstimer = '{@case.Kørselstimer}', TimeEstimat = '{@case.TimeEstimat}', SagsBeskrivelse = '{@case.SagsBeskrivelse}', InterneNoter = '{@case.InterneNoter}', KlientNr = '{@case.KlientNr}', AdvokatId = {@case.AdvokatId}, YdelsesTypeNr = {@case.YdelsesTypeNr}" +
                $"where SagsNr = {@case.SagsNr}";
            RunSqlCommand(sqlString);
        }

        public List<Sag> GetAllSag()// By Daniella
        {
            string sqlString = "select * from Sag " +
               "join Advokat on Sag.AdvokatID = Advokat.AdvokatId" +
            " join Klient on Sag.KlientNr = Klient.KlientNr";

            List<Sag> Alle = new List<Sag>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Sag @case = new Sag();
                            @case.SagsNr = sqld["SagsNr"].ToString();
                            @case.Arbejdstitel = sqld["Arbejdstitel"].ToString();
                            @case.StartDato = sqld["StartDato"].ToString();
                            @case.SlutDato = sqld["SlutDato"].ToString();
                            @case.Kørselstimer = sqld["Kørselstimer"].ToString();
                            @case.TimeEstimat = sqld["TimeEstimat"].ToString();
                            @case.SagsBeskrivelse = sqld["SagsBeskrivelse"].ToString();
                            @case.InterneNoter = sqld["InterneNoter"].ToString();
                            @case.KlientNr = sqld["Klientnr"].ToString();
                            @case.AdvokatId = Convert.ToInt32(sqld["AdvokatId"]);
                            @case.YdelsesTypeNr = Convert.ToInt32(sqld["YdelsesTypeNr"]);
                            Alle.Add(@case);
                        }
                    return Alle;
                }
            }

        }


        public List<Klient> GetAllKlient()// By Daniella
        {
            string sqlString = "select * from Klient";
            List<Klient> All = new List<Klient>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Klient @klient = new Klient();
                            @klient.KlientNr = sqld["KlientNr"].ToString();
                            @klient.Navn = sqld["Navn"].ToString();
                            @klient.Adresse = sqld["Adresse"].ToString();
                            @klient.TelefonNr = sqld["TelefonNr"].ToString();
                            All.Add(@klient);
                        }
                    return All;
                }
            }
        }


        public void CreateAdvokat(Advokat ad)// By Dennie
        {
            string sqlString = $"INSERT INTO Advokat(Navn) VALUES ({ad.AdvokatId} , {ad.Navn}')";
            RunSqlCommand(sqlString);
        }
        /* Når en advokat skal have tilføjet et speciale/efteruddannelse, skal man i vores database bare indtaste et "navn" på specialet + "advokat id'et", som skal have denne efteruddannelse.
             * Havde forstillet mig, at man i vores ViewListe skal kunne vælge "vis advokater" og derinde så tilføje efteruddannelse ud fra en "valgt" advokats id.
             - Dennie 
             */
        public void AddSpecialToAdvokat(string efteruddannelse, int advokatId)// // By Dennie
        {
            string sqlString = $"INSERT INTO Efteruddannelse(Navn, AdvokatId) VALUES ('{efteruddannelse}', {advokatId})";
            RunSqlCommand(sqlString);
        }

        public List<Advokat> GetAllAdvokat()// By Daniella
        {
            string sqlString = "select * from Advokat";
            List<Advokat> All = new List<Advokat>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Advokat @advokat = new Advokat();
                            @advokat.AdvokatId = Convert.ToInt32(sqld["AdvokatId"]);
                            @advokat.Navn = sqld["Navn"].ToString();
                            All.Add(@advokat);
                        }
                    return All;
                }
            }

        }

        public List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)// By Daniella
        {
            string sqlString = @"SELECT * FROM ADVOKAT
                                JOIN Tjenesteydelse ON Tjenesteydelse.AdvokatId = Advokat.AdvokatId
                                WHERE YdelsesTypeNr = " + ydelsesTypeNr;
            List<Advokat> All = new List<Advokat>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            Advokat @advokat = new Advokat();
                            @advokat.AdvokatId = Convert.ToInt32(sqld["AdvokatId"]);
                            @advokat.Navn = sqld["Navn"].ToString();
                            All.Add(@advokat);
                        }
                    return All;
                }
            }

        }


        public List<YdelseList> Tjenesteydelse()// By Daniella
        {
            string sqlString = "select * from Tjenesteydelse";
            List<YdelseList> All = new List<YdelseList>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            YdelseList ydelse = new YdelseList();
                            ydelse.AdvokatId = Convert.ToInt32(sqld["AdvokatId"]);
                            ydelse.YdelsesTypeNr = Convert.ToInt32(sqld["YdelsesTypeNr"]);
                            All.Add(ydelse);
                        }
                    return All;
                }
            }
        }

        public List<YdelseType> YdelseType()// By Daniella
        {
            string sqlString = "select * from YdelseType";
            List<YdelseType> All = new List<YdelseType>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            YdelseType ydelse = new YdelseType();
                            ydelse.YdelsesTypeNr = Convert.ToInt32(sqld["YdelsesTypeNr"]);
                            ydelse.YdelsesNavn = sqld["YdelsesNavn"].ToString();
                            All.Add(ydelse);
                        }
                    return All;
                }
            }
        }


        public List<ListItems> GetList()// By Daniella
        {
            string sqlString = "select * from List";
            List<ListItems> All = new List<ListItems>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            using (SqlCommand com = new SqlCommand(sqlString, conn))
            {
                conn.Open();
                using (SqlDataReader sqld = com.ExecuteReader())
                {
                    if (sqld.HasRows)
                        while (sqld.Read())
                        {
                            ListItems @list = new ListItems();
                            @list.ListID = sqld["ListID"].ToString();
                            @list.What_type = sqld["What_type"].ToString();
                            All.Add(@list);
                        }
                    return All;
                }
            }
        }

        public void CreateKlient(Klient KL)//By Thomas
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    conn.Open();

                    string sqlString = $"INSERT INTO KLient(Navn, Adresse, TelefonNr) VALUES ('{KL.Navn}', '{KL.Adresse}', '{KL.TelefonNr}')";

                    com.CommandText = sqlString;
                    com.ExecuteNonQuery();
                }
            }
        }
        //public void DeleteFromCase()
        //{

        //}
        //public void DeleteFromKlient()
        //{

        //}

        //public void DeleteFromAdvokat()
        //{

        //}

    }
}

