using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Reader
{
    public class XmlReaderOne
    {
        public static void ReadXmlWithStream(string xml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));

            using (FileStream xmlReader = new FileStream(xml, FileMode.Open))
            {
                var res = (string)xmlSerializer.Deserialize(xmlReader);
            }
        }
    }
}
