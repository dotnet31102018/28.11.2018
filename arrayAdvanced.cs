using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811today
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 9, 11 };
            float[] floatArray = { 1.1f, 4.4f, 5.5f, 8.8f };
            double[] doubleArray = new double[1000];
            string[] stringArray = new string[5];

            int[,] matrix = new int[3, 3]
            {
                { 4, 5, 6 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // jagged
            int[][] matrixJagged = new int[][] // array of arrays
                {
                 new int[] {0,1,2}, // 0
                 new int[] {3,4,5}, // 1
                 new int[] {6,7,8,9} // 2
                };
            
            Console.WriteLine( matrixJagged[0][2] ); // array number 0 , element at index 2 

            for (int i = 0; i < matrix.GetLength(0); i++) // run on all rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // for each row run on all columns
                {
                    Console.Write(i + ", ");
                    Console.WriteLine(j);
                    Console.WriteLine(matrix[i, j]); // matrix[ row, column ] = matrix [ i, j ]
                }
            }


            Convert.ToInt32(Console.ReadLine());

            int[] klum = new int[1000];
            Console.WriteLine(klum[123]);

            char[] shumdavar = new char[1000];
            Console.Write(shumdavar[123]);
            Console.WriteLine("after klum");


            Convert.ToInt32(Console.ReadLine());

            string[] stringArrayInline = { "Hello", ".net", "class" };

            Console.WriteLine(stringArrayInline [2]);

            char[] charArray = { 'a', 'b', 'c' };
            string text = "I am a string";  // charArray = { 'I',' ','a','m',' ','a',' ','s','t','r','i','n','g' }

            //stringArrayInline[0] = Console.ReadLine();

            Console.WriteLine("First element");
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            //Console.WriteLine(arr[3]); // this will blow up the program!!!!

            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write("Array int element at :");
                Console.WriteLine(i + 1);
                Console.WriteLine( arr [i] );
            }

            Console.WriteLine();

            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.Write("Array float element at :");
                Console.WriteLine(i + 1);
                Console.WriteLine(floatArray[i]);
            }

            // read array of 5 numbers and print the average
            int[] grades = { 0, 0, 0, 0, 0 };
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                // 1.
                //int number = Convert.ToInt32(Console.ReadLine());
                //grades[i] = number;

                // 2.
                grades[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + grades[i];
            }
            Console.WriteLine("Average = ");
            Console.WriteLine( sum / grades.Length);


            // read array of 100 numbers and print the average
            int[] grades100 = new int[100];
            for (int i = 0; i < grades100.Length; i++)
            {
                // 1.
                //int number = Convert.ToInt32(Console.ReadLine());
                //grades[i] = number;

                // 2.
                grades100[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + grades100[i];
            }
            Console.WriteLine("Average = ");
            Console.WriteLine(sum / grades100.Length);

            // dynamic size of array - by user input
            int len = Convert.ToInt32(Console.ReadLine());
            int[] gradesDynamicSize = new int[len];
        }
    }
}
