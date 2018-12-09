using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassLib;

namespace DataAccess
{
    public interface IDatabase
    {
        void CreateAdvokat(Advokat advokat);
        void CreateSag(Sag sag);
        void CreateKlient(Klient klient);
        void CreateYdelse(Ydelse ydelse);

        void UpdateAdvokat(Advokat advokat);
        void UpdateSag(Sag sag);
        void UpdateKlient(Klient klient);
        void UpdateYdelse(Ydelse ydelse);

        List<Advokat> GetAllAdvokat();
        List<Sag> GetAllSag();
        List<Klient> GetAllKlient();
        List<Ydelse> GetAllYdelse();

        List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr);
        List<Tjenesteydelse> GetAllTjenesteydelse();
        List<YdelseType> GetAllYdelseType();
        List<ListItems> GetAllList();
        List<Efteruddannelse> GetAllEfteruddannelse();

        void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId);
        void AddTjenestesydelseToAdvokat(int advokatId, int ydelsesTypeNr);
    }
}
