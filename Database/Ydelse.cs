﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Ydelse
    {
        public int YdelsesTypeNr { get; set; }
        public string StartDato { get; set; }
        public string YdelseBeskrivelse { get; set; }
        public string Pris { get; set; }
        public string Timer { get; set; }
        public int SagsNr { get; set; }
        public int AdvokatID { get; set; }

        public Ydelse() { }

        public Ydelse( string startDato, string ydelseBeskrivelse, string pris, string timer, int sagsNr, int advokatID)
        {
           
            StartDato = startDato;
            YdelseBeskrivelse = ydelseBeskrivelse;
            Pris = pris;
            Timer = timer;
            SagsNr = sagsNr;
            AdvokatID = advokatID;
        }
    }

     
    public class YdelseList
    {
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public YdelseList() { }
        public YdelseList(int advokatId, int ydelsesTypeNr)
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
