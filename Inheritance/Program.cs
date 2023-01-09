using Microsoft.VisualBasic;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var robin = new Bird();
            robin.CanFly = true;
            robin.Migrate = true;
            robin.BeakLength = 1;
            robin.WingColor = "Brown";


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizzard = new Reptile();
            lizzard.IsScaly = true;
            lizzard.IsColdBlooded = true;
            lizzard.Habitat = "Desert";
            lizzard.CanRegenerateTail = true;

            var animals = new Animal[] { robin, lizzard };

            foreach(var animal in animals)
            {
                Console.WriteLine($"this animal is alive {animal.IsAlive}");
                Console.WriteLine($"this animal is {animal.Age} years old");
                Console.WriteLine($" this animal has {animal.LegCount} legs");
                Console.WriteLine($"this animal prefers the {animal.LandSeaAir}");
                Console.WriteLine("");
            }
            Console.WriteLine($"{lizzard.IsScaly}, {lizzard.LegCount}, {lizzard.Habitat}, {lizzard.CanRegenerateTail}");
        }
    }
}
