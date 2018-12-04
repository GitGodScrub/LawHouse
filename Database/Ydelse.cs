using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Ydelse
    {
        public int YdelsesNr { get; set; }
        public string StartDato { get; set; }
        public string YdelsesBeskrivelse { get; set; }
        public string Pris { get; set; }
        public string Timer { get; set; }
        public int SagsNr { get; set; }
        public int AdvokatId { get; set; }

        public Ydelse() { }

        public Ydelse( string startDato, string ydelsesBeskrivelse, string pris, string timer, int sagsNr, int advokatId)
        {
           
            StartDato = startDato;
            YdelsesBeskrivelse = ydelsesBeskrivelse;
            Pris = pris;
            Timer = timer;
            SagsNr = sagsNr;
            AdvokatId = advokatId;
        }
    }

     
    public class Tjenesteydelse
    {
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public Tjenesteydelse() { }
        public Tjenesteydelse(int advokatId, int ydelsesTypeNr)
        {
            AdvokatId = advokatId;
            YdelsesTypeNr = ydelsesTypeNr;
        }
    }
    public class YdelseType
    {
        public int YdelsesTypeNr { get; set; }
        public string YdelsesNavn { get; set; }

        public YdelseType() { }
        public YdelseType(int ydelsesTypeNr, string ydelsesNavn)
        {
            YdelsesNavn = ydelsesNavn;
            YdelsesTypeNr = ydelsesTypeNr;

        }
    }
}
