using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a Random generator [ will be used all over the program!!!! ]
            Random randomGenerator = new Random();

            // ========================================== Example 1
            // == dynamic size single dimensional array
            // == filling the array with random numbers
            // how to create an array in dynamic size and fill it with random numbers

            Console.WriteLine("Example 1:");

            // 1. get a number from the user
            Console.WriteLine("Please enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());

            // 2. create a one dimensional array with the input size
            int[] arrayInDynamicSize = new int[size];

            // 3. fill the array with random numbers between 1-500 using the random generator
            for (int i = 0; i < arrayInDynamicSize.Length; i++)
            {
                arrayInDynamicSize[i] = randomGenerator.Next(0, 501);
            }

            // 5. print the array
            for (int i = 0; i < arrayInDynamicSize.Length; i++)
            {
                Console.WriteLine(arrayInDynamicSize[i]);
            }

            // ========================================== Example 2
            // == placing random values in a 2 dimensioanl array matrix [between 0 and 1]

            Console.WriteLine("Example 2:");

            int[,] theMatrix = new int[2,8]; // 2 rows and 8 columns, fixed size
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    theMatrix[i, j] = randomGenerator.Next(0, 2);
                }
            }

            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    Console.Write("[" + i + "," + j + "]: ");
                    Console.WriteLine(theMatrix[i, j]);
                }
            }

            // ========================================== Example 3
            // == create jagged array in dynamic size [user input] and dynamic inner size [user input]
            // == and fill it with random numbers (1-1000)

            Console.WriteLine("Example 3:");

            Console.WriteLine("Please enter the jagged number of rows:");
            int sizeJagged = Convert.ToInt32(Console.ReadLine());

            // create the jagged array rows
            int[][] thejaggedArray = new int[sizeJagged][];
            for (int i = 0; i < thejaggedArray.GetLength(0); i++)
            {
                Console.WriteLine("Please enter the size of COLUMNS for row number " + i + " [zero-based]:");
                int sizeJaggedInnerArray = Convert.ToInt32(Console.ReadLine());

                // create the inner jagged array
                thejaggedArray[i] = new int[sizeJaggedInnerArray];

                // fill with random numbers
                for (int j = 0; j < thejaggedArray[i].Length; j++)
                {
                    thejaggedArray[i][j] = randomGenerator.Next(0, 1000) + 1;
                }

                Console.WriteLine("row number " + i + " [zero-based] has been filled with ranodm numbers between 1-1000");
            }

            // print
            for (int i = 0; i < thejaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < thejaggedArray[i].Length; j++)
                {
                    Console.Write("[" + i + "," + j + "]: ");
                    Console.WriteLine(thejaggedArray[i][j]);
                }
            }



        }
    }
}
