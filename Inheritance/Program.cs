using System;
using System.Collections.Generic;
using System.Reflection;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE
            // give this class 4 members that all Animals have in common DONE


            // Create a class Bird DONE
            // give this class 4 members that are specific to Bird DONE
            // Set this class to inherit from your Animal Class DONE

            // Create a class Reptile DONE
            // give this class 4 members that are specific to Reptile DONE
            // Set this class to inherit from your Animal Class DONE




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values  DONE
             */
            var tweety = new Bird(); 
            tweety.Name = "Tweety";
            tweety.Age = 30;
            tweety.AnimalType = "Parakeet";
            tweety.DoesMigrateInWinter = false;
            tweety.BirdSound = "Tweet Tweet Tweet";
            tweety.MakeBirdSound();
            tweety.DoesFly = true;
            tweety.IsWild = false;
            tweety.IsDomestic = true;

            DisplayProperties(tweety);


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var aligator = new Reptile();
            aligator.Name = "Alfie";
            aligator.Age = 9;
            aligator.AnimalType = "Large Reptile";
            aligator.TypeOfSkin = "Dry, scaley, protective";
            aligator.GoesInWater = true;
            aligator.InZoo = false;
            aligator.IsWild = true;

            foreach (var property in GetProperties(aligator))
            {
                Console.WriteLine($"{property.Key}: {property.Value}");
            }
        }

        public static void DisplayProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                Console.WriteLine($"{property.Name}: {value}");
            }
        }

        public static IEnumerable<KeyValuePair<string, object>> GetProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                yield return new KeyValuePair<string, object>(property.Name, value);
            }
        }
    }
}
