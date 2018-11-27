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
        public Sag(string Arbejdstitel, string StartDato, string SlutDato, string Kørselstimer, string TimeEstimat, string SagsBeskrivelse , string InterneNoter, string KlientNr, int AdvokatId, int YdelsesTypeNr)
        {
            this.Arbejdstitel = Arbejdstitel;
            this.StartDato = StartDato;
            this.SlutDato = SlutDato;
            this.Kørselstimer = Kørselstimer;
            this.TimeEstimat = TimeEstimat;
            this.SagsBeskrivelse = SagsBeskrivelse;
            this.InterneNoter = InterneNoter;
            this.KlientNr = KlientNr;
            this.AdvokatId = AdvokatId;
            this.YdelsesTypeNr = YdelsesTypeNr;
        }
    }
}
