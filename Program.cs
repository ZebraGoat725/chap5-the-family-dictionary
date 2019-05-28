using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "bo"},
                {"age", "33"}
            });

            myFamily.Add("pet", new Dictionary<string, string>(){
                {"name", "dog"},
                {"age", "1"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
                // Krista is my sister and is 42 years old
                // foreach(KeyValuePair <string, string> member in familyMember.Value){
                //     Console.WriteLine(member["name"]); 
                // }
            }
        }
    }
}
