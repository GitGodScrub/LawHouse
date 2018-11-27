namespace DataAccess
{
    public class Advokat
    {
        public int AdvokatId { get; set; }
        public string Navn { get; set; }
        public string Efteruddannelse { get; set; }

        public Advokat() { }
        public Advokat(int AdvokatId, string navn)
        {
            this.AdvokatId = AdvokatId;
            this.Navn = navn;
        }
        public Advokat(int AdvokatId, string navn, string efteruddannelse)
        {
            this.AdvokatId = AdvokatId;
            this.Navn = navn;
            this.Efteruddannelse = efteruddannelse;
        }
    }
}