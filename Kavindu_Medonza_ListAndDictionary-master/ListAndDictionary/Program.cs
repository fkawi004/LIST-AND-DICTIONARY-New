﻿using System.Xml.Linq;

namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            Console.WriteLine("Enter Name");
            var name=Console.ReadLine();
            // TODO 2: Validate if the person already exists in the personList.
            if (personList.Contains(name))
            {
                Console.WriteLine($"{name} already exists in the personList.");
            }
            else
            {
                
                personList.Add(name);
                Console.WriteLine($"{name} added to personList.");
            }
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            if (personAgeDictionary.ContainsKey(name))
            {
                Console.WriteLine($"{name} already exists in personAgeDictionary.");
            }
            else
            {
                Console.WriteLine($"Enter age for {name}: ");
                int age = Convert.ToInt32(Console.ReadLine());
                personAgeDictionary.Add(name, age);
                Console.WriteLine($"{name} added to personAgeDictionary with age {age}.");
            }
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            Console.WriteLine("Enter the name to remove: ");
            var nameToRemove = Console.ReadLine();
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            if (personList.Contains(nameToRemove))
            {
                personList.Remove(nameToRemove);
                Console.WriteLine($"{nameToRemove} removed from personList.");
            }
            else
            {
                Console.WriteLine($"{nameToRemove} not found in personList.");
            }
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.
            if (personAgeDictionary.ContainsKey(nameToRemove))
            {
                personAgeDictionary.Remove(nameToRemove);
                Console.WriteLine($"{nameToRemove} removed from personAgeDictionary.");
            }
            else
            {
                Console.WriteLine($"{nameToRemove} not found in personAgeDictionary.");
            }
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            Console.WriteLine("Enter the name to find: ");
            var nameToFind = Console.ReadLine();
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            if (personList.Contains(nameToFind))
            {
                Console.WriteLine($"{nameToFind} found in personList.");
            }
            else
            {
                Console.WriteLine($"{nameToFind} not found in personList.");
            }
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.
            if (personAgeDictionary.ContainsKey(nameToFind))
            {
                Console.WriteLine($"{nameToFind} found in personAgeDictionary with age {personAgeDictionary[nameToFind]}.");
            }
            else
            {
                Console.WriteLine($"{nameToFind} not found in personAgeDictionary.");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            Console.WriteLine("Persons in personList:");
            foreach (var person in personList)
            {
                Console.WriteLine(person);
            }
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            Console.WriteLine("\nPersons in personAgeDictionary:");
            foreach (var kvp in personAgeDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} years old");
            }
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.
            if (personList.Count == 0)
            {
                Console.WriteLine("personList is empty.");
            }

            if (personAgeDictionary.Count == 0)
            {
                Console.WriteLine("personAgeDictionary is empty.");
            }
        }
    }
}
