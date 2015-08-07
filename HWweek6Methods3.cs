using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWweek6Methods3  //Write a method that takes a string and returns the number of vowels in the string.
                           // You may assume that all the letters are lowercase. You can treat "y" as a consonant.
{
    class Program   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting Vowels. Please enter a word.");
            int count = Vowels(System.Console.ReadLine());//taking the user STRING of words(system.console.readline),... 
                     //then passing it to the METHOD of (Vowels), then ...returning that as an INTEGER(int count). 
            Console.WriteLine(count);
            Console.ReadLine();
        }

        static int Vowels(string words) // Method that accepts a string and returns an int 
        {
            int countvowels = 0;
            foreach (Char vowel in words)
            {
                if (vowel=='a'|| vowel=='e'|| vowel=='i' || vowel=='o'||vowel=='u')
                {
                    countvowels++;
                }
            }

            return countvowels;
        }

	

    }
}
