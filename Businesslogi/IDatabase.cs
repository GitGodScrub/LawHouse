using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    interface IDatabase
    {
        void CreateAdvokat(Advokat instanceAdvokat);
        void CreateSag(Sag instanceSag);
        void CreateKlient(Klient instanceKlient);
        void CreateYdelse(Ydelse instanceYdelse);
        void UpdateAdvokat(Advokat @case);
        void UpdateSag(Sag @case);
        void UpdateKlient(Klient)
        void UpdateSag(Sag @case);







        void List<Sag> GetAllSag();
        void List<Klient> KlientList();
        void List<Advokat> GetAllSag();
        void List<Advokat> GetAllAdvokatFromYdelse();







    }
}
