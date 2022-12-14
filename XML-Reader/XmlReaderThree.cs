using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_Reader
{
    internal class XmlReaderThree
    {
        internal static void ReadXMLFileUsingXMLReader(string xml)
        {
            using (XmlReader xmlReader = XmlReader.Create(xml))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.IsStartElement())
                    {
                        switch (xmlReader.Name.ToString())
                        {
                            case "name":
                                Console.WriteLine("name: " + xmlReader.ReadString());
                                break;
                            case "lastName":
                                Console.WriteLine("lastName: " + xmlReader.ReadString());
                                break;
                            case "age":
                                Console.WriteLine("age: " + xmlReader.ReadString());
                                break;
                        }
                    }

                }

            }
        }
    }
}
