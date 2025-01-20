using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

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
            // output the length of state --------------------- DONE
            Console.WriteLine("1 " + state.Length);
            // Concatenate the contents of city and landmark * don't forget to add a space --------------------- DONE
            Console.WriteLine($"2 {city} {landmark}");
            // output the first character of country --------------------- DONE
            Console.WriteLine("3 " + country[0]);
            // output a concatenation of the first and last characters of city --------------------- DONE
            Console.WriteLine($"4 {city[0]}{city[12]}");
            // output the substring of landmark starting at c and outputting to the end --------------------- DONE
            Console.WriteLine($"5 {landmark.Substring(landmark.IndexOf('c'))}");
            // output the substring of country starting at the first S and ending at the first A --------------------- DONE

            int i = 7;
            while (i<18)
            {
                Console.WriteLine($"{country[i]}");
                
                i++;
            }
            // output the position of f in California --------------------- DONE
            char searchChar = 'f';
            int position = state.IndexOf(searchChar);

            if (position != -1)
            {
                Console.WriteLine($"The position of {searchChar} in {state} is: {position+1}");
            }
            



            // Show your evidence of the program running in the Readme file
        }
    }
}
