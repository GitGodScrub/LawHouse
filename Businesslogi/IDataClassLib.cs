using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataClassLib;

namespace BusinessLogic
{
   public interface IDataClassLib
    {
        void Advokat(Advokat advokat);
        void Efteruddannelse(Efteruddannelse efteruddannelse);
        void Klient(Klient klient);
        void ListItems(ListItems listItems);
        void Sag(Sag sag);
        void Tjenesteydelse(Tjenesteydelse tjenesteydelse);
        void Ydelse(Ydelse ydelse);
        void YdelseType(YdelseType ydelseType);
    }
}
