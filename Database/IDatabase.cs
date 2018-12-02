using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDatabase
    {
        void CreateAdvokat(Advokat @advokat);
        void CreateSag(Sag @sag);
        void CreateKlient(Klient @klient);
        void CreateYdelse(Ydelse @ydelse);

        void UpdateAdvokat(Advokat @advokat);
        void UpdateSag(Sag @sag);
        void UpdateKlient(Klient @klient);
        void UpdateYdelse(Ydelse @ydelse);

        List<Sag> GetAllSag();
        List<Klient> GetAllKlient();
        List<Advokat> GetAllAdvokat();
        List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr);
        List<YdelseList> GetAllTjenesteydelse();
        List<YdelseType> GetAllYdelseType();
        List<Ydelse> GetAllYdelse();
        List<ListItems> GetAllList();

        //void AddTjenestesydelseToAdvokat();
        void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId); //awaiting aproval
    }
}
