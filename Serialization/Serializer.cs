using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    public static class Serializer
    {
        public static void Serialize<T>(T objectToSerialize, string @fileName)
        {
            var serialize = new XmlSerializer(objectToSerialize.GetType());

            using (var writer = new StreamWriter(fileName))
            {
                serialize.Serialize(writer, objectToSerialize);
            }
        }

        public static void XmlReader(string @fileName)
        {
            var xmlFile = XDocument.Load(fileName);

            xmlFile.Descendants("Owner")
                .Select(
                    m => new Owner(m.Element("FirstName").Value, m.Element("Surname").Value))
                .Where(m => m.LastName == "Modżajto")
                .ToList()
                .ForEach(m => { Console.WriteLine("Owner: {0} {1} ", m.FirstName, m.LastName); });
        }
    }
}
