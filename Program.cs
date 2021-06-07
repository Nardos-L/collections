using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            //Create an array to hold integer values 0 through 9
            int[] numArray = new int[10];
            for (int nums = 0; nums < 10; nums++){
                numArray[nums] = nums;
                Console.WriteLine(numArray[nums]);
            }

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = {"Tim", "Martin", "Nikki","Sara"};

            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] lenArray = new bool[10] {true,false,true,false,true,false,true,false,true,false};

            //List of Flavors
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vannila");
            flavors.Add("Chocolate");
            flavors.Add("Cherry");
            flavors.Add("Rasberry");
            flavors.Add("Cream pie");

            //Output the length of this list after building it
            Console.WriteLine($"Length of list - {flavors.Count}");

            //Output the third flavor in the list, then remove this value
            Console.WriteLine($"Third list - {flavors[2]}");
            flavors.Remove(flavors[2]);
            Console.WriteLine($"Third list - {flavors[2]}");

            //Output the new length of the list (It should just be one fewer!)
            Console.WriteLine($"Length of list - {flavors.Count}");

            //User Info Dictionary
            //Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> user = new Dictionary<string, string>();

            //Add key/value pairs to this dictionary 
            
            for (int val = 0; val < 4; val++)
            {
                Random rand = new Random();
                user.Add(nameArray[val],flavors[rand.Next(0,4)]);               
                }

            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (KeyValuePair<string,string> oneUser in user)
            {
                Console.WriteLine(oneUser.Key + " " + oneUser.Value);
            }
        }
    }
}
