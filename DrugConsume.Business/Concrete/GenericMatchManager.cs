using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DrugConsume.Business.Concrete
{
    public class GenericMatchManager
    {
        static readonly string _path = "C:/DrugConsume";
        static readonly string _fileName = "Matches.xml";
        readonly XmlDocument xmlDocument = new XmlDocument();
        XmlElement datas;

        public void SaveMatches(Dictionary<string,string> matches) {

            
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            if (File.Exists(_path + "/" + _fileName))
            {              
                xmlDocument.Load(_path + "/" + _fileName);
                datas = xmlDocument.ChildNodes[0] as XmlElement;
                

            }
            else
            {
                datas = xmlDocument.CreateElement("datas");
                xmlDocument.AppendChild(datas);
            }

            foreach (KeyValuePair<string, string> item in matches)
            {
                XmlElement match = xmlDocument.CreateElement("match");
               
                XmlAttribute generic1 = xmlDocument.CreateAttribute("generic1");
                generic1.Value = item.Key;
                match.Attributes.Append(generic1);

                XmlAttribute generic2 = xmlDocument.CreateAttribute("generic2");
                generic2.Value = item.Value;
                match.Attributes.Append(generic2);

                datas.AppendChild(match);

            }

            xmlDocument.Save(_path + "/" + _fileName);


        }
        public Dictionary<string, string> GetMatches()
        {
            if (!File.Exists(_path + "/" + _fileName))
            {
                return null;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(_path + "/" + _fileName);
            Dictionary<string,string> matches = new Dictionary<string,string>();
            foreach (XmlElement item in xmlDocument.ChildNodes[0].ChildNodes)
            {
                matches.Add(item.Attributes["generic1"].Value, item.Attributes["generic2"].Value);
            }
            
            return matches;
        }

    }
}
