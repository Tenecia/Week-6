using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWweek6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool prime = Truefalse(num);
            System.Console.WriteLine(prime);
            Console.ReadLine();

        }

        static bool Truefalse(int userNumber)
        {

            //Console.WriteLine("Please enter a Number");
            // int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int a = 2; a <= userNumber / 2; a++)
            {
                if (userNumber % a == 0)
                {
                    return false;
                }

            }
            return true;

        }



    }
}
