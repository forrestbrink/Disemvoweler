using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //call our function
            Disemvoweler("Nickelback is Logan's favorite band.  Their songwriting can't be beat!  Dark Horse is his favorite album.");

            //get some input from the user
            //get a string to disemvowel from the user
            Console.WriteLine("Enter a sentence to disemvowel.");
            //place the user's input into a string
            string input = Console.ReadLine();
            //call the disemvoweler with their input
            Disemvoweler(input);

            //keep the console open
            Console.ReadKey();
        }

        //Takes out the vowels and spaces of a string and pronts out the original and disemvoweled version
        static void Disemvoweler(string input)
        {
            //declare an output variable
            string output = string.Empty;
            //declare a variable to hold vowels
            string vowels = string.Empty;

            //loop over each letter of the string
            for (int i = 0; i < input.Length; i++)
            {
                //put the current letter into a variable
                string letter = input[i].ToString();
                //determine if the letter is a vowel
                if ("aeiou".Contains(letter.ToLower()))
                {
                    //its a vowel, add it to vowels
                    vowels += letter;
                }
                else if (letter == " ")
                {
                    //its a space, do nothing
                }
                else
                {
                    //not a vowel or space, add it to the output
                    output += letter;
                }
            }
            //looped through all the letters
            //time to print the output
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + output);
            Console.WriteLine("Vowels: " + vowels);
        }
    }
}
