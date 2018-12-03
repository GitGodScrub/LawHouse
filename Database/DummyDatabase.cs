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
        //Virker ikke
    {
        public DummyDatabase()
        {
            xmlFileToUse = @"DummyDatabaseXML.xml";
            xReader = new XmlTextReader(xmlFileToUse);
        }
        private XmlTextReader xReader;
        private string xmlFileToUse;
        private List<string> xmlReadAndReturnContent(string tagToFind)
        {
            List<string> toReturn = new List<string>();

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
                        break;
                    case XmlNodeType.Text: //Content f.eks Petersplads 6
                        toReturn.Add(xReader.Value);
                        break;
                    case XmlNodeType.EndElement: //EndTag f.eks </Sag>
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
            throw new NotImplementedException();
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
