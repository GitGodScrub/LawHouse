using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DummyDatabase : IDatabase
    {
        public void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId)
        {
            throw new NotImplementedException();
        }

        public void CreateAdvokat(Advokat advokat)
        {
            throw new NotImplementedException();
        }

        public void CreateKlient(Klient klient)
        {
            throw new NotImplementedException();
        }

        public void CreateSag(Sag sag)
        {
            throw new NotImplementedException();
        }

        public void CreateYdelse(Ydelse ydelse)
        {
            throw new NotImplementedException();
        }

        public List<Advokat> GetAllAdvokat()
        {
            throw new NotImplementedException();
        }

        public List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)
        {
            throw new NotImplementedException();
        }

        public List<Klient> GetAllKlient()
        {
            throw new NotImplementedException();
        }

        public List<ListItems> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Sag> GetAllSag()
        {
            throw new NotImplementedException();
        }

        public List<YdelseList> GetAllTjenesteydelse()
        {
            throw new NotImplementedException();
        }

        public List<Ydelse> GetAllYdelse()
        {
            throw new NotImplementedException();
        }

        public List<YdelseType> GetAllYdelseType()
        {
            throw new NotImplementedException();
        }

        public void UpdateAdvokat(Advokat advokat)
        {
            throw new NotImplementedException();
        }

        public void UpdateKlient(Klient klient)
        {
            throw new NotImplementedException();
        }

        public void UpdateSag(Sag sag)
        {
            throw new NotImplementedException();
        }

        public void UpdateYdelse(Ydelse ydelse)
        {
            throw new NotImplementedException();
        }
    }
}
