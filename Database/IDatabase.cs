using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDatabase
    {
        void CreateAdvokat(Advokat instanceAdvokat);
        void CreateSag(Sag instanceSag);
        void CreateKlient(Klient instanceKlient);
        void CreateYdelse(Ydelse instanceYdelse);

        void UpdateAdvokat(Advokat @advokat);
        void UpdateSag(Sag @case);
        void UpdateKlient(Klient @klient);
        void UpdateYdelse(Ydelse @ydelse);

        List<Sag> GetAllSag();
        List<Klient> GetAllKlient();
        List<Advokat> GetAllAdvokat();
        List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr);
        List<YdelseList> Tjenesteydelse();//changeMaybe
        List<YdelseType> YdelseType();//changeMaybe
        List<ListItems> GetList();//changeMaybe

        void AddSpecialeToAdvokat();
        void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId); //awaiting aproval
    }
}
