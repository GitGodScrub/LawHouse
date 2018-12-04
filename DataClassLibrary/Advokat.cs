namespace DataClassLibrary
{
    public class Advokat //Dennie
    {
        public int AdvokatId { get; set; }
        public string Navn { get; set; }
        public string Efteruddannelse { get; set; }

        public Advokat() { }

        public Advokat(string navn)
        {
            Navn = navn;
        }
        public Advokat(int advokatId, string navn)
        {
            AdvokatId = advokatId;
            Navn = navn;
        }
        public Advokat(int advokatId, string navn, string efteruddannelse)
        {
            AdvokatId = advokatId;
            Navn = navn;
            Efteruddannelse = efteruddannelse;
        }
    }
}