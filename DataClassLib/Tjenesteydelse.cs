namespace DataClassLib
{
    public class Tjenesteydelse
    //Daniella

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
}