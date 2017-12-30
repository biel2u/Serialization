using System.Xml.Serialization;

namespace Serialization
{
    public class Owner
    {
        public string FirstName { get; set; }

        [XmlElement("Surname")]
        public string LastName { get; set; }

        public Owner(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        private Owner()
        {
        }
    }    
}
