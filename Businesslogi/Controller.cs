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
        private static DatabaseHandler currentDatabaseInstance = DatabaseHandler.Instance();
        // private string DatabaseAdvokat currentDatabaseAdvokat = DatabaseAdvokat.Instance();

        public static void CreateSag(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer,
        string TimeEstimat, string SagsBeskrivelse, string InterneNoter, string KlientNr, int AdvokatId, int YdelsesTypeNr)
        {
            Sag @case = new Sag(Arbejdstitel, StartDato, SlutDato, Kørselstimer, TimeEstimat, SagsBeskrivelse, InterneNoter, KlientNr, AdvokatId, YdelsesTypeNr);
            currentDatabaseInstance.CreateSag(@case);
        }

        public static List<Sag> GetAllSag()
        {
             List<Sag> listToReturn = currentDatabaseInstance.GetAllSag();
            return listToReturn;
        }

        public static void UpdateSag(object objectToUpdate)
        {
            Sag @case = (Sag)objectToUpdate;
            currentDatabaseInstance.UpdateSag(@case);
        }


        public static void CreateKlient(String Navn, string Adresse, string TelefonNr)
        {
            Klient KL = new Klient(Navn, Adresse, TelefonNr);
            currentDatabaseInstance.CreateKlient(KL);
        }

        public static List<Klient> GetAllKlient()
        {
            List<Klient> GetClient = currentDatabaseInstance.KlientList();
            return GetClient;
        }


        public static List<YdelseList> GetAllYdelser()
        {
            List<YdelseList> ydelseLists = currentDatabaseInstance.Tjenesteydelse();
            return ydelseLists;
        }
        public static List<YdelseType> GetAllYdelseType()
        {
            List<YdelseType> ydT = currentDatabaseInstance.YdelseType();
            return ydT;
        }


        public static void CreateAdvokat(int AdvokatId, string advokatNavn)
        {
            Advokat ad = new Advokat(AdvokatId, advokatNavn);
            currentDatabaseInstance.CreateAdvokat(ad);
        }

        public static void AddSpecialToAdvokat(string specialName, int advokatId)
        {
            currentDatabaseInstance.AddSpecialToAdvokat(specialName, advokatId);
        }


        public static List<ListItems> GetAllItems()
        {
            List<ListItems> GetItems = currentDatabaseInstance.GetList();
            return GetItems;
        }

        public static List<Advokat> GetAllAdvokat()
        {
            List<Advokat> ad = currentDatabaseInstance.GetAllAdvokat();
            return ad;
        }

        public static List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)
        {
            return currentDatabaseInstance.GetAllAdvokatFromYdelse(ydelsesTypeNr);
        }


    }
}
