using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Reader
{
    internal static class XmlConverter<T>
    {
        private static XmlSerializer _serializer = null;

        static XmlConverter()
        {
            _serializer = new XmlSerializer(typeof(T));
        }
        public static T ToObject(string xml)
        {
            return (T)_serializer.Deserialize(new StringReader(xml));
        }
        public static string ToXML(T obj)
        {
            using (var memoryStream = new MemoryStream())
            {
                _serializer.Serialize(memoryStream, obj);

                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
