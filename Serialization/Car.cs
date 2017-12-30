using System.Collections.Generic;
using System.Xml.Serialization;

namespace Serialization
{
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Capacity { get; set; }

        [XmlElement]
        public List<Owner> Owners { get; set; }
    }
}
