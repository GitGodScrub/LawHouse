using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new Usings under this comment
using System.Xml;
using System.Xml.XPath;
using System.IO;
using System.Reflection;
using DataClassLib;

namespace DataAccess
{
    public partial class DummyDatabase : IDatabase // By Julius
    {
        public DummyDatabase()//i know how this works, i think -Julius
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            //Relativ position ://Lawhouse2//lawhouse//bin//debug
            //Vi vil her hen ://Lawhouse2//Database//DummyDatabaseXML.xml
            path = System.IO.Directory.GetParent(path).FullName;// ://Lawhouse2//lawhouse//bin
            path = System.IO.Directory.GetParent(path).FullName;// ://Lawhouse2//lawhouse
            path = System.IO.Directory.GetParent(path).FullName;// ://Lawhouse2
            string filename = Path.Combine(path, @"Database\\DummyDatabaseXML.xml");// ://Lawhouse2//Database//DummyDatabaseXML.xml
            xmlFileToUse = filename;
            xReader = new XmlTextReader(xmlFileToUse);
        }
        private XmlTextReader xReader;
        private string xmlFileToUse;

        private List<List<string>> xmlReadAndReturnContent(string tagToFind)
        {
            List<List<string>> toReturn = new List<List<string>>();

            bool isInTag = false;
            int numberOfPreviousInstances = 0;

            while (xReader.Read())
            {
                switch (xReader.NodeType)
                {
                    case XmlNodeType.XmlDeclaration://skip
                        break;
                    case XmlNodeType.Comment://skip
                        break;
                    case XmlNodeType.CDATA://skip
                        break;

                    case XmlNodeType.Element: //Tag, f.eks <Sag> //fik fejl her pga $"<{tagToFind}>", siden det er værdien .Name man kigger på
                        if (xReader.Name == $"{tagToFind}")
                        {
                            isInTag = true;
                        }
                        break;
                    case XmlNodeType.Text: //Content f.eks Petersplads 6
                        if (isInTag == true)
                        {
                            if (toReturn.Count <= numberOfPreviousInstances)//laver en ny liste så man kan putte værdier ind på den
                            {
                                toReturn.Add(new List<string>());
                            }
                            toReturn[numberOfPreviousInstances].Add(xReader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement: //EndTag f.eks </Sag>
                        if (xReader.Name == $"{tagToFind}")
                        {
                            isInTag = false;
                            numberOfPreviousInstances++;
                        }
                        break;
                }
            }
            return toReturn;
        }

        public List<Efteruddannelse> GetAllEfteruddannelse()
        {
            throw new NotImplementedException();
        }

        public void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId)
        {
            throw new NotImplementedException();
        }

        public void AddTjenestesydelseToAdvokat(int advokatId, int ydelsesTypeNr)
        {
            throw new NotImplementedException();
        }

        public void CreateAdvokat(Advokat advokat)
        {
            throw new NotImplementedException();
        }

        public void CreateKlient(Klient klient)
        {
            throw new NotImplementedException();
        }

        public void CreateSag(Sag sag)
        {
            throw new NotImplementedException();
        }

        public void CreateYdelse(Ydelse ydelse)
        {
            throw new NotImplementedException();
        }

        public List<Advokat> GetAllAdvokat()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("Advokat");
            List<Advokat> listToReturn = new List<Advokat>();

            foreach (List<string> i in unrefinedXmlData)
            {
                Advokat @advokat = new Advokat();
                @advokat.AdvokatId = Convert.ToInt32(i[0]);
                @advokat.Navn = i[1];
                listToReturn.Add(@advokat);
            }
            return listToReturn;
        }

        public List<Advokat> GetAllAdvokatFromYdelse(int ydelsesTypeNr)
        {
            List<Advokat> listOfAllAdvokat = GetAllAdvokat();
            List<Advokat> listToReturn = new List<Advokat>();
            List<Tjenesteydelse> allTjenesteydelse = GetAllTjenesteydelse();

            List<int> tjenesteydelseTilknyttedeAdvokatId = new List<int>();

            foreach (Tjenesteydelse y in allTjenesteydelse)
            {
                if (y.YdelsesTypeNr == ydelsesTypeNr)
                {
                    tjenesteydelseTilknyttedeAdvokatId.Add(y.AdvokatId);
                }
            }

            foreach (Advokat x in listOfAllAdvokat)
            {
                if (tjenesteydelseTilknyttedeAdvokatId.Contains(x.AdvokatId))
                {
                    listToReturn.Add(x);
                }
            }
            return listToReturn;
        }

        public List<Klient> GetAllKlient()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("Klient");
            List<Klient> listToReturn = new List<Klient>();

            foreach (List<string> i in unrefinedXmlData)
            {
                Klient @klient = new Klient();
                @klient.KlientNr = Convert.ToInt32(i[0]);
                @klient.Navn = i[1];
                @klient.Adresse = i[2];
                @klient.TelefonNr = i[3];
                listToReturn.Add(@klient);
            }
            return listToReturn;
        }

        public List<ListItems> GetAllList()
        {
            List<ListItems> listToReturn = new List<ListItems>();

            ListItems @list = new ListItems();
            @list.ListID = "1";
            @list.What_type = "Sag";
            listToReturn.Add(@list);

            @list = new ListItems();
            @list.ListID = "2";
            @list.What_type = "Klient";
            listToReturn.Add(@list);

            @list = new ListItems();
            @list.ListID = "3";
            @list.What_type = "Advokat";
            listToReturn.Add(@list);

            @list = new ListItems();
            @list.ListID = "4";
            @list.What_type = "Ydelse";
            listToReturn.Add(@list);

            return listToReturn;
        }

        public List<Sag> GetAllSag()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("Sag");
            List<Sag> listToReturn = new List<Sag>();

            foreach (List<string> i in unrefinedXmlData)
            {
                Sag @sag = new Sag();
                @sag.SagsNr = Convert.ToInt32(i[0]);
                @sag.Arbejdstitel = i[1];
                @sag.StartDato = i[2];
                @sag.SlutDato = i[3];
                @sag.Kørselstimer = i[4];
                @sag.TimeEstimat = i[5];
                @sag.SagsBeskrivelse = i[6];
                @sag.InterneNoter = i[7];
                @sag.KlientNr = Convert.ToInt32(i[8]);
                @sag.AdvokatId = Convert.ToInt32(i[9]);
                @sag.YdelsesTypeNr = Convert.ToInt32(i[10]);
                listToReturn.Add(@sag);
            }
            return listToReturn;
        }

        public List<Tjenesteydelse> GetAllTjenesteydelse()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("Tjenesteydelse");
            List<Tjenesteydelse> listToReturn = new List<Tjenesteydelse>();

            foreach (List<string> i in unrefinedXmlData)
            {
                Tjenesteydelse @tjenesteydelse = new Tjenesteydelse();
                @tjenesteydelse.AdvokatId = Convert.ToInt32(i[0]);
                @tjenesteydelse.YdelsesTypeNr = Convert.ToInt32(i[1]);
                listToReturn.Add(@tjenesteydelse);
            }
            return listToReturn;
        }

        public List<Ydelse> GetAllYdelse()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("Ydelse");
            List<Ydelse> listToReturn = new List<Ydelse>();

            foreach (List<string> i in unrefinedXmlData)
            {
                Ydelse @ydelse = new Ydelse();
                @ydelse.YdelsesNr = Convert.ToInt32(i[0]);
                @ydelse.StartDato = i[1];
                @ydelse.YdelsesBeskrivelse = i[2];
                @ydelse.Pris = i[3];
                @ydelse.Timer = i[4];
                @ydelse.SagsNr = Convert.ToInt32(i[5]);
                @ydelse.AdvokatId = Convert.ToInt32(i[6]);
                listToReturn.Add(@ydelse);
            }
            return listToReturn;
        }

        public List<YdelseType> GetAllYdelseType()
        {
            List<List<string>> unrefinedXmlData = xmlReadAndReturnContent("YdelseType");
            List<YdelseType> listToReturn = new List<YdelseType>();

            foreach (List<string> i in unrefinedXmlData)
            {
                YdelseType @ydelseType = new YdelseType();
                @ydelseType.YdelsesTypeNr = Convert.ToInt32(i[0]);
                @ydelseType.YdelsesNavn = i[1];
                listToReturn.Add(@ydelseType);
            }
            return listToReturn;
        }

        public void UpdateAdvokat(Advokat advokat)
        {
            throw new NotImplementedException();
        }

        public void UpdateKlient(Klient klient)
        {
            throw new NotImplementedException();
        }

        public void UpdateSag(Sag sag)
        {
            throw new NotImplementedException();
        }

        public void UpdateYdelse(Ydelse ydelse)
        {
            throw new NotImplementedException();
        }
    }
}
