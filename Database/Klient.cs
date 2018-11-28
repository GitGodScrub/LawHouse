using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Klient
    {
        public string KlientNr { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string TelefonNr { get; set; }
        public Klient() { }
        public Klient(string navn, string adresse, string telefonNr)
        {
            Navn = navn;
            Adresse = adresse;
            TelefonNr = telefonNr;
        }

    }
}
