using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Reader
{
    internal class XmlReaderTwo
    {
        internal static void ReadXmlWithXmlSerializer()
        {
            MemoryStream ms = new MemoryStream();
            ms.Position = 0;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(string));
            var xml = (string)xmlSerializer.Deserialize(ms);
        }
    }
}
