namespace DataClassLib
{
    public class Klient
    {
        public int KlientNr { get; set; }
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
