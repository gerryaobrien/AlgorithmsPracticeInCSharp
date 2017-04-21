using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 5, 9, 8, 5 };
            //int result = LargestInArray(testArray);
            //bool result = ContainsDuplicates(testArray);
            //Console.WriteLine("Result is: " + result);

            Console.WriteLine("Original Array: ");
            foreach(int item in testArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            RandomizeArray(testArray);
        }

        // Largest in array - change the data type for non-integer arrays
        static int LargestInArray(int[] vals)
        {
            int largest = vals[0];

            for(int i = 1; i < vals.Length; i++)
            {
                if(vals[i] > largest)
                {
                    largest = vals[i];
                }
            }

            return largest;
        }

        static bool ContainsDuplicates(int[] vals)
        {
            bool result = false;

            for(int i = 0; i < vals.Length; i++)
            {
                for(int j = 0; j < vals.Length; j++)
                {
                    if (i != j)
                    {
                        if(vals[i] == vals[j])
                        {
                            result = true;
                        }
                    }
                }
            }

            return result;
        }

        static void RandomizeArray(int[] vals)
        {
            int max = vals.Length;
            int temp = 0;

            for(int i = 0; i < vals.Length - 1; i++)
            {
                Random rnd = new Random(DateTime.Now.Second);
                int j = rnd.Next(1, vals.Length);
                temp = vals[i];
                vals[i] = vals[j];
                vals[j] = temp;
            }

            Console.WriteLine("Randomized array: ");
            foreach(int item in vals)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

    }

}
