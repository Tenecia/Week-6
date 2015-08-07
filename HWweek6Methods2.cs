using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWweek6Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a Double");
            double number1 = double.Parse(Console.ReadLine()); // string to double 
            Console.WriteLine("Give me an Int");
            int number2 = int.Parse(Console.ReadLine());  // string to int 
            double result = Decimals(number1, number2); // calling your Method (Decimals) and passing parameters (number1,number2).
            Console.WriteLine(result); // Printing to the console
            Console.ReadLine();
        }
        //Write a Method that accepts a string of numbers as double and also an integer. Return Type double after the strings signifigant digits have been chopped by the number specified by the int.
        static double Decimals(double number1, int number2)
        {
            return Math.Round(number1, number2); // calling in to dot net framework to "Round" ( number1,number2)
        }

    }


}
