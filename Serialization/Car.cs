using System.Collections.Generic;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlRoot("SuperCar")]
    public class Car
    {
        public string Name { get; set; }
        public string Type { get; set; }

        [XmlIgnore]
        public double Capacity { get; set; }

        [XmlArray]
        public List<Owner> Owners { get; set; }
    }
}
