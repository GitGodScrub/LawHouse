using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class YdelseList
    {
        public int AdvokatId { get; set; }
        public int YdelsesTypeNr { get; set; }

        public YdelseList() { }
        public YdelseList(int AdvokatId, int YdelsesTypeNr)
        {
            this.AdvokatId = AdvokatId;
            this.YdelsesTypeNr = YdelsesTypeNr;
        }
    }
    public class YdelseType
    {
        public int YdelsesTypeNr { get; set; }
        public string YdelsesNavn { get; set; }

        public YdelseType () { }
        public YdelseType(int YdelsesTypeNr,string YdelsesNavn)
        {
            this.YdelsesNavn = YdelsesNavn;
            this.YdelsesTypeNr = YdelsesTypeNr;

        }
    }
}
