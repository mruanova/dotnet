using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // printRandom();
            // printList();
            printDictionary();
        }

        static void printRandom()
        {
            // Console.WriteLine("The value of pi is " + 3.14159);
            // Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            // Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim"); 
            Random rand = new Random();
            for (int val = 0; val < 3; val++)
            {
                //Prints the next random value between 2 and 8
                Console.WriteLine('a' + rand.Next());
                Console.WriteLine('b' + rand.Next(20));
                Console.WriteLine('c' + rand.Next(2, 8));
                Console.WriteLine('d' + rand.NextDouble());
            }
        }
        static void printList()
        {
            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");
            //
            //Using our array of motorcycle manufacturers from before
            //we can easily loop through the list of them with a C-style for loop
            //this time, however, Count is the attribute for a number of items.
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }
            // Insert a new item between a specific index
            bikes.Insert(2, "Yamaha");
            //Removal from Generic List
            //Remove is a lot like Javascript array pop, but searches for a specified value
            //In this case we are removing all manufacturers located in Japan
            bikes.Remove("Suzuki");
            //bikes.Remove("Yamaha");
            bikes.RemoveAt(0); //RemoveAt has no return value however
                               //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }
        }
        static void printDictionary()
        {
            Dictionary<string, string> profile = new Dictionary<string, string>();
            //Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor Profile");
            Console.WriteLine("Name - " + profile["Name"]);
            Console.WriteLine("From - " + profile["Location"]);
            Console.WriteLine("Favorite Language - " + profile["Language"]);
            foreach (KeyValuePair<string, string> entry in profile)
            {
                Console.WriteLine("LOOP " + entry.Key + " - " + entry.Value);
            }
        }

        delegate int ScoreDelegate(PlayerStats stats);
        void onGameOver(PlayerStats[] allPlayersStats)
        {
            string playerNameMostKills = GetPlayerNameTopScore(allPlayersStats, stats => stats.kills);
            string playerNameMostFlags = GetPlayerNameTopScore(allPlayersStats, stats => stats.flags);
        }
        string GetPlayerNameTopScore(PlayerStats[] allPlayersStats, ScoreDelegate scoreCalculator)
        {
            string name = "";
            int bestScore = 0;
            foreach (PlayerStats stats in allPlayersStats)
            {
                int score = scoreCalculator(stats);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = stats.name;
                }
            }
            return name;
        }
    }
}
