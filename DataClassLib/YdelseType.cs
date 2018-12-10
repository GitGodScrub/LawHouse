namespace DataClassLib
{
    public class YdelseType
        //Daniella
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