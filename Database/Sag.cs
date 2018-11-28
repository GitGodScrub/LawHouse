using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Sag
    {
        public string SagsNr { get; set; }
        public string Arbejdstitel { get; set; }
        public string StartDato { get; set; }
        public string SlutDato { get; set; }
        public string Kørselstimer { get; set; }
        public string TimeEstimat { get; set; }     
        public string SagsBeskrivelse { get; set; } 
        public string InterneNoter { get; set; }
        public string KlientNr { get; set; }
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public Sag() { }
        public Sag(string arbejdstitel, string startDato, string slutDato, string kørselstimer, string timeEstimat, string sagsBeskrivelse , string interneNoter, string klientNr, int advokatId, int ydelsesTypeNr)
        {
            Arbejdstitel = arbejdstitel;
            StartDato = startDato;
            SlutDato = slutDato;
            Kørselstimer = kørselstimer;
            TimeEstimat = timeEstimat;
            SagsBeskrivelse = sagsBeskrivelse;
            InterneNoter = interneNoter;
            KlientNr = klientNr;
            AdvokatId = advokatId;
            YdelsesTypeNr = ydelsesTypeNr;
        }
    }
}
