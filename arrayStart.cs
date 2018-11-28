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
            float[] floatArray;
            double[] doubleArray;
            string[] stringArray;

            Console.WriteLine("First element");
            Console.WriteLine(   arr[0]  );
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            //Console.WriteLine(arr[3]); // this will blow up the program!!!!

            for (int i = 0; i < arr.Length ; i++)
            {
                Console.Write("Array element at :");
                Console.WriteLine(i + 1);
                Console.WriteLine( arr [i] );
            }

            


        }
    }
}
