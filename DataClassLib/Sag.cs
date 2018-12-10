namespace DataClassLib
{
    public class Sag
    //Daniella

    {
        public int SagsNr { get; set; }
        public string Arbejdstitel { get; set; }
        public string StartDato { get; set; }
        public string SlutDato { get; set; }
        public string Kørselstimer { get; set; }
        public string TimeEstimat { get; set; }     
        public string SagsBeskrivelse { get; set; } 
        public string InterneNoter { get; set; }
        public int KlientNr { get; set; }
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public Sag() { }
        public Sag(string arbejdstitel, string startDato, string slutDato, string kørselstimer, string timeEstimat, string sagsBeskrivelse , string interneNoter, int klientNr, int advokatId, int ydelsesTypeNr)
        {//Daniella
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
