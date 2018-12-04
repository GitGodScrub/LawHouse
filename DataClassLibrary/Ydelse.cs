namespace DataClassLibrary
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
}
