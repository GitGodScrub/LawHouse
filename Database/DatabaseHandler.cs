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

        private void RunSqlCommand(string commandToRun, SqlCommand com) //By Daniella, refactored by Julius
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using ( com )
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

        public void CreateSag(Sag sag)// By Daniella
        {//Grunden til at der den her er fordi den tager en case og opretter det ud for properties
            string sqlString = $"INSERT INTO Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter , KlientNr, AdvokatId, YdelsesTypeNr )" + $"values(@Arbejdstitel , @Startdato , @SlutDato , @Kørselstimer , @TimeEstimat ,  @SagsBeskrivelse,   @InterneNoter ,  @KlientNr,  @AdvokatId,  @YdelsesTypeNr)";
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnString))
            {
                using (SqlCommand com = new SqlCommand(sqlString,conn))
                {
                    conn.Open();
                    com.Parameters.Add(new SqlParameter("Arbejdstitel", sag.Arbejdstitel));
                    com.Parameters.Add(new SqlParameter("Startdato", sag.StartDato));
                    com.Parameters.Add(new SqlParameter("SlutDato", sag.SlutDato));
                    com.Parameters.Add(new SqlParameter("Kørselstimer", sag.Kørselstimer));
                    com.Parameters.Add(new SqlParameter("TimeEstimat", sag.TimeEstimat));
                    com.Parameters.Add(new SqlParameter("SagsBeskrivelse", sag.SagsBeskrivelse));
                    com.Parameters.Add(new SqlParameter("InterneNoter", sag.InterneNoter));
                    com.Parameters.Add(new SqlParameter("KlientNr", sag.KlientNr));
                    com.Parameters.Add(new SqlParameter("AdvokatId", sag.AdvokatId));
                    com.Parameters.Add(new SqlParameter("YdelsesTypeNr", sag.YdelsesTypeNr));
                    com.ExecuteNonQuery();
                }
            }
                  //  RunSqlCommand(sqlString);
        }
        public void UpdateSag(Sag sag )// By Daniella, refactored by Julius
        {
            string sqlString =
                $"UPDATE Sag SET Arbejdstitel = @Arbejdstitel, StartDato = @StartDato , SlutDato = @SlutDato , Kørselstimer = @Kørselstimer , TimeEstimat = @TimeEstimat , SagsBeskrivelse = @SagsBeskrivelse , InterneNoter = @InterneNoter , KlientNr = @KlientNr , AdvokatId = @AdvokatId , YdelsesTypeNr = @YdelsesTypeNr " +
                $"WHERE SagsNr = {sag.SagsNr}";
            SqlCommand com = new SqlCommand();
            com.Parameters.Add(new SqlParameter("Arbejdstitel", sag.Arbejdstitel));
            com.Parameters.Add(new SqlParameter("Startdato", sag.StartDato));
            com.Parameters.Add(new SqlParameter("SlutDato", sag.SlutDato));
            com.Parameters.Add(new SqlParameter("Kørselstimer", sag.Kørselstimer));
            com.Parameters.Add(new SqlParameter("TimeEstimat", sag.TimeEstimat));
            com.Parameters.Add(new SqlParameter("SagsBeskrivelse", sag.SagsBeskrivelse));
            com.Parameters.Add(new SqlParameter("InterneNoter", sag.InterneNoter));
            com.Parameters.Add(new SqlParameter("KlientNr", sag.KlientNr));
            com.Parameters.Add(new SqlParameter("AdvokatId", sag.AdvokatId));
            com.Parameters.Add(new SqlParameter("YdelsesTypeNr", sag.YdelsesTypeNr));
            RunSqlCommand(sqlString, com);
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

        public void CreateKlient(Klient klient)//By Thomas
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO KLient(Navn, Adresse, TelefonNr) VALUES (@Navn , @Adresse , @TelefonNr)";
            RunSqlCommand(sqlString, com);
          
        }
        public void UpdateKlient(Klient klient) // By Thomas
        {
            SqlCommand com = new SqlCommand();
            string sqlString =
                $"UPDATE Klient SET Navn =@Navn, Adresse = @Adresse, TelefonNr = @TelefonNr " +
                $"WHERE KlientNr = {klient.KlientNr}";
            RunSqlCommand(sqlString, com);
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


        public void CreateAdvokat(Advokat advokat)// By Dennie
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO Advokat(Navn) VALUES (@Navn)";
            RunSqlCommand(sqlString, com);
        }
        /* Når en advokat skal have tilføjet et speciale/efteruddannelse, skal man i vores database bare indtaste et "navn" på specialet + "advokat id'et", som skal have denne efteruddannelse.
             * Havde forstillet mig, at man i vores ViewListe skal kunne vælge "vis advokater" og derinde så tilføje efteruddannelse ud fra en "valgt" advokats id.
             - Dennie 
        */
        public void UpdateAdvokat(Advokat advokat) // by Thomas
        {
            SqlCommand com = new SqlCommand();
            String sqlString =
                $"UPDATE Advokat SET Navn = @Navn" +
                 $"WHERE AdvokatID =@AdvokatId";
            RunSqlCommand(sqlString, com);

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


        public void CreateYdelse(Ydelse ydelse)
        {
            {
                SqlCommand com = new SqlCommand();
                string sqlString = $"INSERT INTO Ydelse( StartDato, YdelsesBeskrivelse, Pris, Timer, SagsNr, AdvokatId )" + $"values( @StartDato , @YdelsesBeskrivelse ,@ydelse.Pris  ,@Timer , @SagsNr , @AdvokatId )";
                RunSqlCommand(sqlString, com);
            }
        }
        public void UpdateYdelse(Ydelse ydelse)
        {
            SqlCommand com = new SqlCommand();
            string sqlString =
                $"UPDATE Ydelse SET Startdato = @StartDato , YdelsesBeskrivelse =@YdelsesBeskrivelse , Pris = @Pris ,Timer = @Timer , SagsNr = @SagsNr , AdvokatId = @AdvokatId " +
                $"WHERE YdelsesNr ={ydelse.YdelsesNr}";
            RunSqlCommand(sqlString, com);
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
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO Efteruddannelse(Navn, AdvokatId) VALUES (@efteruddannelse, @advokatId)";
            RunSqlCommand(sqlString, com);
        }

        public void AddTjenestesydelseToAdvokat(int advokatId, int ydelsesTypeNr)//By Julius
        {
            SqlCommand com = new SqlCommand();
            string sqlString = $"INSERT INTO Tjenesteydelse(AdvokatId, YdelsesTypeNr) VALUES (@advokatId, @ydelsesTypeNr)";
            RunSqlCommand(sqlString, com);
        }
    }
}

