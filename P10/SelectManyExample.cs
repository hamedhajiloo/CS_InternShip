using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P10
{
    public static class SelectManyExample
    {
        class PetOwner
        {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }

        public static void SelectManyEx2()
        {
            PetOwner[] petOwners =
            {
              new PetOwner { Name="Higa, Sidney", Pets = new List<string>{ "Scruffy", "Sam" } },
              new PetOwner { Name="Ashkenazi, Ronen",Pets = new List<string>{ "Walker", "Sugar" } },
              new PetOwner { Name="Price, Vernette", Pets = new List<string>{ "Scratches", "Diesel" } },
              new PetOwner { Name="Hines, Patrick",Pets = new List<string>{ "Dusty" } }
            };

            // Project the items in the array by appending the index 
            // of each PetOwner to each pet's name in that petOwner's 
            // array of pets.
            IEnumerable<string> query =
                petOwners.SelectMany((petOwner, index) =>
                                         petOwner.Pets.Select(pet => $"{index} : {pet}"));

            foreach (string pet in query)
            {
                Console.WriteLine(pet);
            }
        }
    }
}
