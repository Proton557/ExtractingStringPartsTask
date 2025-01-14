﻿using System.ComponentModel.DataAnnotations;

namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            // output the length of state
            Console.WriteLine(state.Length);
            // Concatenate the contents of city and landmark * don't forget to add a space
            Console.WriteLine($"{city} {landmark}");
            // output the first character of country
            Console.WriteLine(country[0]);
            // output a concatenation of the first and last characters of city
            Console.WriteLine($"{city[0]}{city[state.Length-1]}");
            // output the substring of landmark starting at c and outputting to the end
            Console.WriteLine(landmark[2]);
            // output the substring of country starting at the first S and ending at the first A

            // output the position of f in California
            //Console.WriteLine(state.IndexOf());
            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels


            

            // Show your evidence of the program running in the Readme file
        }
    }
}
