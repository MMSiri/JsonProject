using System;
using System.Collections.Generic;
using System.Text.Json;


namespace JsonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var guys = new List<Guy>()
            {
                new Guy() { Name = "Bob", Clothes = new Outfit() { Top = "t-shirt", Bottom = "jeans" }, Hair = new HairStyle() { Colour = HairColour.Red, Length = 3.5f } },
                new Guy() { Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" }, Hair = new HairStyle() { Colour = HairColour.Gray, Length = 2.7f } },
            };

            var jsonString = JsonSerializer.Serialize(guys);
            Console.WriteLine(jsonString);

            var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
            foreach (var guy in copyOfGuys)
            {
                Console.WriteLine("I deserialised this guy: {0}", guy);
            }
        }
    }
}
