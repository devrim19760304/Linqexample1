using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace LINQ0
{
    internal class Program 
    {
        public static void Main(string[] args)
        {
            string[] names = new string[]
{                "Alice", "Bob", "Charlie", "David", "Emma",
                "Frank", "Grace", "Henry", "Isabella", "Jack",
                "Katie", "Liam", "Mia", "Noah", "Olivia",
                "Paul", "Quinn", "Ryan", "Sophia", "Tom",
                "Ursula", "Victor", "Wendy", "Xavier", "Yasmine",
                "Zachary", "Abigail", "Benjamin", "Charlotte", "Daniel",
                "Eleanor", "Felix", "Gabriella", "Harvey", "Ivy",
                "James", "Katherine", "Lucas", "Madeline", "Nathan",
                "Oscar", "Penelope", "Richard", "Samuel", "Theodore",
                "Uma", "Vincent", "William", "Xander", "Yvonne", "Zoe"
            };
            int[] numbers = { 15, 42, 3, 89, 56, 7, 12, 63, 90, 27, 48, 74, 31, 11, 55, 19, 67, 33, 80, 21 };
            IEnumerable<string> someNames=from nameA in names where nameA.Length>8 select nameA;
            IEnumerable<string> aPeople=from nameA in names where nameA.StartsWith("Ab") select nameA;
            var bPeople=from nameA in names where nameA.StartsWith("james") select nameA;

            
            
            foreach (var n in bPeople)
            {
                Console.WriteLine(n);
            }

            IEnumerable<int> smaller15=from smalls in numbers where smalls<15 && smalls>4 select smalls;
            Console.WriteLine("numbers smaller then 15 "+smaller15.Count());
            foreach(var n in smaller15)
            {
                Console.WriteLine(n);

            }

        }
        
    }
}
