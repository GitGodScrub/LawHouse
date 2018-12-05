using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLib;

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

        public void CreateSag(Sag @sag)// By Daniella
        {//Grunden til at der den her er fordi den tager en case og opretter det ud for properties
            string sqlString = $"INSERT INTO Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , KlientNr, AdvokatId, YdelsesTypeNr )" + $"values('{sag.Arbejdstitel}' , '{sag.StartDato}' ,'{sag.SlutDato}' ,'{sag.Kørselstimer}' ,'{sag.TimeEstimat}' , '{sag.SagsBeskrivelse}',  '{sag.InterneNoter}' , '{sag.KlientNr}', {sag.AdvokatId}, {sag.YdelsesTypeNr})";
            RunSqlCommand(sqlString);
        }
        public void UpdateSag(Sag @sag)// By Daniella, refactored by Julius
        {
            string sqlString =
                $"UPDATE Sag SET Arbejdstitel = '{sag.Arbejdstitel}', StartDato = '{sag.StartDato}', SlutDato = '{sag.SlutDato}', Kørselstimer = '{sag.Kørselstimer}', TimeEstimat = '{sag.TimeEstimat}', SagsBeskrivelse = '{sag.SagsBeskrivelse}', InterneNoter = '{sag.InterneNoter}', KlientNr = {sag.KlientNr}, AdvokatId = {sag.AdvokatId}, YdelsesTypeNr = {sag.YdelsesTypeNr}" +
                $"WHERE SagsNr = {sag.SagsNr}";
            RunSqlCommand(sqlString);
        }
        public List<Sag> GetAllSag()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Sag " +
                               "JOIN Advokat ON Sag.AdvokatID = Advokat.AdvokatId" +
                               " JOIN Klient ON Sag.KlientNr = Klient.KlientNr";
            List<Sag> listOfSag = new List<Sag>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Sag @sag = new Sag();
                @sag.SagsNr = Convert.ToInt32(x[0]);
                @sag.Arbejdstitel = x[1];
                @sag.StartDato = x[2];
                @sag.SlutDato = x[3];
                @sag.Kørselstimer = x[4];
                @sag.TimeEstimat = x[5];
                @sag.SagsBeskrivelse = x[6];
                @sag.InterneNoter = x[7];
                @sag.KlientNr = Convert.ToInt32(x[8]);
                @sag.AdvokatId = Convert.ToInt32(x[9]);
                @sag.YdelsesTypeNr = Convert.ToInt32(x[10]);
                listOfSag.Add(@sag);
            }
            return listOfSag;
        }

        public void CreateKlient(Klient @klient)//By Thomas
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = conn;
                    conn.Open();

                    string sqlString = $"INSERT INTO KLient(Navn, Adresse, TelefonNr) VALUES ('{klient.Navn}', '{klient.Adresse}', '{klient.TelefonNr}')";

                    com.CommandText = sqlString;
                    com.ExecuteNonQuery();
                }
            }
        }
        public void UpdateKlient(Klient KL) // By Thomas
        {
            string sqlString =
                $"UPDATE Klient SET Navn ='{KL.Navn}', Adresse = '{KL.Adresse}', TelefonNr = '{KL.TelefonNr}' " +
                $"WHERE KlientNr = {KL.KlientNr}";
            RunSqlCommand(sqlString);
        }
        public List<Klient> GetAllKlient()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Klient";
            List<Klient> listOfKlient = new List<Klient>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Klient @klient = new Klient();
                @klient.KlientNr = Convert.ToInt32(x[0]);
                @klient.Navn = x[1];
                @klient.Adresse = x[2];
                @klient.TelefonNr = x[3];
                listOfKlient.Add(@klient);
            }
            return listOfKlient;
        }


        public void CreateAdvokat(Advokat @advokat)// By Dennie
        {
            string sqlString = $"INSERT INTO Advokat(Navn) VALUES ('{advokat.Navn}')";
            RunSqlCommand(sqlString);
        }
        /* Når en advokat skal have tilføjet et speciale/efteruddannelse, skal man i vores database bare indtaste et "navn" på specialet + "advokat id'et", som skal have denne efteruddannelse.
             * Havde forstillet mig, at man i vores ViewListe skal kunne vælge "vis advokater" og derinde så tilføje efteruddannelse ud fra en "valgt" advokats id.
             - Dennie 
        */
        public void UpdateAdvokat(Advokat ad) // by Thomas
        {

            String sqlString =
                $"UPDATE Advokat SET Navn = '{ad.Navn}'" +
                 $"WHERE AdvokatID ={ad.AdvokatId}";
            RunSqlCommand(sqlString);

        }
        public List<Advokat> GetAllAdvokat()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Advokat";
            List<Advokat> listOfAdvokat = new List<Advokat>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Advokat @advokat = new Advokat();
                @advokat.AdvokatId = Convert.ToInt32(x[0]);
                @advokat.Navn = x[1];
                listOfAdvokat.Add(@advokat);
            }
            return listOfAdvokat;
        }

        public List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)// By Daniella //By Julius
        {
            string sqlString = @"SELECT * FROM ADVOKAT
                                JOIN Tjenesteydelse ON Tjenesteydelse.AdvokatId = Advokat.AdvokatId
                                WHERE YdelsesTypeNr = " + ydelsesTypeNr;
            List<Advokat> listOfAdvokat = new List<Advokat>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Advokat @advokat = new Advokat();
                @advokat.AdvokatId = Convert.ToInt32(x[0]);
                @advokat.Navn = x[1];
                listOfAdvokat.Add(@advokat);
            }
            return listOfAdvokat;
        }

        
        public List<Tjenesteydelse> GetAllTjenesteydelse()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Tjenesteydelse";
            List<Tjenesteydelse> listOfTjenesteydelse = new List<Tjenesteydelse>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Tjenesteydelse @tjenesteydelse = new Tjenesteydelse();
                @tjenesteydelse.AdvokatId = Convert.ToInt32(x[0]);
                @tjenesteydelse.YdelsesTypeNr = Convert.ToInt32(x[1]);
                listOfTjenesteydelse.Add(@tjenesteydelse);
            }
            return listOfTjenesteydelse;
        }

        public List<YdelseType> GetAllYdelseType()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM YdelseType";
            List<YdelseType> listOfYdelsetype = new List<YdelseType>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                YdelseType @ydelseType = new YdelseType();
                @ydelseType.YdelsesTypeNr = Convert.ToInt32(x[0]);
                @ydelseType.YdelsesNavn = x[1];
                listOfYdelsetype.Add(@ydelseType);
            }
            return listOfYdelsetype;
        }

        public List<ListItems> GetAllList()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM List";
            List<ListItems> listOfListItems = new List<ListItems>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                ListItems @listItems = new ListItems();
                @listItems.ListID = x[0];
                @listItems.What_type = x[1];
                listOfListItems.Add(@listItems);
            }
            return listOfListItems;
        }


        public void CreateYdelse(Ydelse @ydelse)
        {
            {
                string sqlString = $"INSERT INTO Ydelse( StartDato, YdelsesBeskrivelse, Pris, Timer, SagsNr, AdvokatId )" + $"values( '{ydelse.StartDato}' ,'{ydelse.YdelsesBeskrivelse}' ,'{ydelse.Pris}' ,'{ydelse.Timer}' , {ydelse.SagsNr}, {ydelse.AdvokatId})";
                RunSqlCommand(sqlString);
            }
        }
        public void UpdateYdelse(Ydelse ydelse)
        {
            string sqlString =
                $"UPDATE Ydelse SET Startdato = '{ydelse.StartDato}', YdelsesBeskrivelse ='{ydelse.YdelsesBeskrivelse}', Pris = '{ydelse.Pris}',Timer = '{ydelse.Timer}', SagsNr = {ydelse.SagsNr}, AdvokatId = {ydelse.AdvokatId}" +
                $"WHERE YdelsesNr ={ydelse.YdelsesNr}";
            RunSqlCommand(sqlString);
        }
        public List<Ydelse> GetAllYdelse()// By Daniella //By Julius
        {
            string sqlString = "SELECT * FROM Ydelse";
            List<Ydelse> listOfYdelse = new List<Ydelse>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Ydelse @ydelse = new Ydelse();
                @ydelse.YdelsesNr = Convert.ToInt32(x[0]);
                @ydelse.StartDato = x[1];
                @ydelse.YdelsesBeskrivelse = x[2];
                @ydelse.Pris = x[3];
                @ydelse.Timer = x[4];
                @ydelse.SagsNr = Convert.ToInt32(x[5]);
                @ydelse.AdvokatId = Convert.ToInt32(x[6]);
                listOfYdelse.Add(@ydelse);
            }
            return listOfYdelse;
        }

        public List<Efteruddannelse> GetAllEfteruddannelse()//By Julius
        {
            string sqlString = "SELECT * FROM Efteruddannelse";
            List<Efteruddannelse> listOfEfteruddannelse = new List<Efteruddannelse>();

            SqlReader sqRead = new SqlReader();
            List<List<string>> rawReadValue = sqRead.ReadThisLastTry(sqlString);

            foreach (List<string> x in rawReadValue)
            {
                Efteruddannelse @Efteruddannelse = new Efteruddannelse();
                @Efteruddannelse.AdvokatId = Convert.ToInt32(x[0]);
                @Efteruddannelse.Navn = x[1];
                listOfEfteruddannelse.Add(@Efteruddannelse);
            }
            return listOfEfteruddannelse;
        }


        public void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId)// By DAniella
        {
            string sqlString = $"INSERT INTO Efteruddannelse(Navn, AdvokatId) VALUES ('{efteruddannelse}', {advokatId})";
            RunSqlCommand(sqlString);
        }

        public void AddTjenestesydelseToAdvokat(int advokatId, int ydelsesTypeNr)//By Julius
        {
            string sqlString = $"INSERT INTO Tjenesteydelse(AdvokatId, YdelsesTypeNr) VALUES ('{advokatId}', {ydelsesTypeNr})";
            RunSqlCommand(sqlString);
        }
    }
}

