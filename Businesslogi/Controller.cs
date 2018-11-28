using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
 

namespace BusinessLogic
{

    public class Controller
    {
        //Eksempel: private IDatabase _myDataBase = BadDataBase();
        // BadDataBase : IDatabase
        // DummyDatabase : IDatabase
        //
        // 
        //
        //.Instance() pga det er en singleton
        //Before:  private static DatabaseHandler currentDatabaseInstance = DatabaseHandler.Instance();
        private static IDatabase currentDatabaseInstance = DatabaseHandler.Instance();
        //23
        public static void CreateAdvokat(int advokatId, string advokatNavn)
        {
            Advokat ad = new Advokat(advokatId, advokatNavn);
            currentDatabaseInstance.CreateAdvokat(ad);
        }
        public static void CreateSag(string arbejdstitel, string startDato, string slutDato, string kørselstimer,
        string timeEstimat, string sagsBeskrivelse, string interneNoter, int klientNr, int advokatId, int ydelsesTypeNr)
        {
            Sag @case = new Sag(arbejdstitel, startDato, slutDato, kørselstimer, timeEstimat, sagsBeskrivelse, interneNoter, klientNr, advokatId, ydelsesTypeNr);
            currentDatabaseInstance.CreateSag(@case);
        }
        public static void CreateKlient(string navn, string adresse, string telefonNr)
        {
            Klient kl = new Klient(navn, adresse, telefonNr);
            currentDatabaseInstance.CreateKlient(kl);
        }
        public static void CreateYdelse(string startDato, string ydelseBeskrivelse, string pris, string timer, int sagsNr, int advokatId)
        {
            Ydelse @ydelse = new Ydelse(startDato, ydelseBeskrivelse, pris, timer, sagsNr, advokatId);
            currentDatabaseInstance.CreateYdelse(@ydelse);
        }


        public static void UpdateSag(object objectToUpdate)
        {
            Sag @case = (Sag)objectToUpdate;
            currentDatabaseInstance.UpdateSag(@case);
        }
        public static void UpdateAdvokat(object objectToUpdate)
        {
            Advokat advokat = (Advokat)objectToUpdate;
            currentDatabaseInstance.UpdateAdvokat(advokat);
        }
        public static void UpdateKLient(object objectToUpdate)
        {
            Klient klient = (Klient)objectToUpdate;
            currentDatabaseInstance.UpdateKlient(klient);
        }

        public static List<Sag> GetAllSag()
        {
             List<Sag> listToReturn = currentDatabaseInstance.GetAllSag();
            return listToReturn;
        }
        public static List<Klient> GetAllKlient()
        {
            List<Klient> GetClient = currentDatabaseInstance.GetAllKlient();
            return GetClient;
        }
        public static List<Advokat> GetAllAdvokat()
        {
            List<Advokat> ad = currentDatabaseInstance.GetAllAdvokat();
            return ad;
        }

        public static List<Ydelse> GetAllYdelses()
        {
            List<Ydelse> Getydelses = currentDatabaseInstance.GetAllYdelse();
            return Getydelses;
        }


        public static void AddSpecialToAdvokat(string specialName, int advokatId)
        {
            currentDatabaseInstance.AddEfteruddannelseToAdvokat(specialName, advokatId);
        }

        public static List<YdelseList> GetAllYdelse()
        {
            List<YdelseList> ydelseLists = currentDatabaseInstance.GetAllTjenesteydelse();
            return ydelseLists;
        }
        public static List<YdelseType> GetAllYdelseType()
        {
            List<YdelseType> ydT = currentDatabaseInstance.GetAllYdelseType();
            return ydT;
        }


        public static List<ListItems> GetAllItems()
        {
            List<ListItems> GetItems = currentDatabaseInstance.GetAllList();
            return GetItems;
        }

       

        public static List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)
        {
            return currentDatabaseInstance.GetAllAdvokatFromYdelse(ydelsesTypeNr);
        }


    }
}
