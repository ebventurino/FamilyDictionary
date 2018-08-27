using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "40" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Tim" }, { "age", "32" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Mom" }, { "age", "65" } });

            foreach (var familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Key}'s name is {familyMember.Value["name"]} and their age is {familyMember.Value["age"]}");
            }
        }
    }
}
