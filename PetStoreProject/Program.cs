using System;
using System.Collections.Generic;

namespace PetStoreProject {

    public class Program { 

        static void Main(string[] args) {

            //creating an instance of each one
            //newest way to create 
            Parrot parrot = new Parrot() {
                Inventory = 17,
                Sound = "Sqak",
                Price = 3000,
                Longevity = 60

            };
            HedgeHog hedgeHog = new HedgeHog() {
                Inventory = 3,
                Sound = "Sqeak",
                Price = 200,
                CuteLevel = "Ultimate"

            };
            Hampster hampster = new Hampster() {
                Inventory = 200,
                Sound = "Squeak 'em",
                Price = 10,
                Color = "Dirty Brown"

            };

            List<IPetAnimal> animals = new List<IPetAnimal>();

            animals.Add(parrot);
            animals.Add(hedgeHog);
            animals.Add(hampster);

            decimal total = 0;
            foreach(IPetAnimal a in animals) {
                decimal value = a.Price * a.Inventory;
                total += value;
                Console.WriteLine($"All {a.GetType().Name}s will net {value:c}");

            }
            Console.WriteLine($"Total vale is {total:c}");


         
        }
    }
}
