using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace DataAccess
{
    public class DummyDatabase : IDatabase // By Julius
    {
        public DummyDatabase()
        {
            xmlFileToUse = @"DummyDatabaseXML.xml";
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

                    case XmlNodeType.Element: //Tag, f.eks <Sag>
                        if (xReader.Name == $"<{tagToFind}>")
                        {
                            isInTag = true;
                        }
                        break;
                    case XmlNodeType.Text: //Content f.eks Petersplads 6
                        if (isInTag == true)
                        {
                            toReturn[numberOfPreviousInstances].Add(xReader.Value);
                        }
                        break;
                    case XmlNodeType.EndElement: //EndTag f.eks </Sag>
                        if (xReader.Name == $"</{tagToFind}>")
                        {
                            isInTag = false;
                            numberOfPreviousInstances++;
                        }
                        break;
                }
            }
            return toReturn;
        }

        public void AddEfteruddannelseToAdvokat(string efteruddannelse, int advokatId)
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
            throw new NotImplementedException();
        }

        public List<Klient> GetAllKlient()
        {
            throw new NotImplementedException();
        }

        public List<ListItems> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Sag> GetAllSag()
        {
            throw new NotImplementedException();
        }

        public List<YdelseList> GetAllTjenesteydelse()
        {
            throw new NotImplementedException();
        }

        public List<Ydelse> GetAllYdelse()
        {
            throw new NotImplementedException();
        }

        public List<YdelseType> GetAllYdelseType()
        {
            throw new NotImplementedException();
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
