using System;
using System.Collections.Generic;

namespace Serialization
{
    internal class Program
    {
        private static void Main()
        {
            var carOwners = new List<Owner>
            {
                new Owner("Patryk", "Git"),
                new Owner("Mateusz", "Wajgoda"),
                new Owner("Krzysztof", "Modżajto"),
                new Owner("Inny", "Modżajto")
            };

            var car = new Car()
            {
                Name = "Fiat",
                Type = "Sedan",
                Capacity = 1.4,
                Owners = carOwners
            };

            Serializer.Serialize(car, "serializedCar.xml");
            Serializer.Serialize(carOwners, "serializedCarOwners.xml");
            Console.WriteLine("Serialized. Press key to read the file");
            Console.ReadKey();

            Serializer.ReadSerializedFile("serializedCarOwners.xml");
            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
