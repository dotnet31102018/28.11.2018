using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summary2811
{
    class Program
    {
        static void Main(string[] args)
        {

            // do while

           int sum = 0;

            // read a number from the user
            int x = int.Parse ( Console.ReadLine() ); // Convert.ToInt32
            // while the numebr is bigger than zero
            while ( x > 0)
            {
                sum = sum + x;
                x = int.Parse(Console.ReadLine()); // Convert.ToInt32
            }

            do
            {
                x = int.Parse(Console.ReadLine()); // Convert.ToInt32
                if ( x > 0)
                {
                    sum = sum + x;
                }
            }
            while (x > 0);

            // break continue
            int number = 0;
            int sumGrade = 0;
            
            {
                number = int.Parse(Console.ReadLine()); // Convert.ToInt32

                if (number == -1)
                {
                    break; // if number is -1 exit the loop!
                }

                if (number == 0)
                {
                    continue; // will stop the current iteration and skip to next one
                }

                sumGrade = sumGrade + number;
            }

            // after loop
            Console.Write("SumsumGrade = ");
            Console.WriteLine(sumGrade);
            Console.WriteLine("I'm out!");
        }
    }
}
