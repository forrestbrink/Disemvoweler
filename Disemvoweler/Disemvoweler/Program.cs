using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call our Disemvoweler function
            Disemvoweler("Nickelback is my favorite band.  Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby.  I make the functions and I make the calls.");

            Console.ReadKey();
        }
       //Create function Disemvoweler 
        //with string input
        static void Disemvoweler(string input)
        {
            string lower = input.ToLower();
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";
            string onlyVowels = string.Empty;
           //create a loop 
            for (int i = 0; i <= input.Length; i++)
            {
                if (!(vowels.Contains(input[i])));
                {
                    onlyVowels += input[i];
                }
            }
           //print out the original phrase
            Console.WriteLine("Original: " + input);
           //print the disemvoweled version
            Console.WriteLine("Disemvoweled: " + onlyVowels);
        }
    }
}
