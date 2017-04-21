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
            int[] testArray = { 1, 2, 5, 9, 8, 5 };     // used for some of the algorithms below

            //int result = LargestInArray(testArray);
            //bool result = ContainsDuplicates(testArray);
            //Console.WriteLine("Result is: " + result);

            #region Call RandomizeArray

            //Console.WriteLine("Original Array: ");
            //foreach(int item in testArray)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();

            //RandomizeArray(testArray);
            #endregion

            // Call GreatestCommonDenominator
            // get  two values from the command line first
            Console.WriteLine("Enter a single integer value: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second integer value: ");
            int second = int.Parse(Console.ReadLine());

            int gcd = GreatestCommonDenominator(first, second);
            Console.WriteLine("The greatest common denominator of {0}, and {1} is: {2} ", first, second, gcd);
        }


        #region Methods that implement various numeric algorithms


        // Largest in array - change the data type for non-integer arrays
        // this algorithm will check all the values in a numeric array
        // and will return the largest value found
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

        // ContainsDuplicates will check an array to see if there are duplicate values
        // currently set to us an integer array but you can change the data type of the array
        // to check for others
        // If you use non-numerics such as char or string, you may need to rewrite the comparison logic
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

        // RandomizeArray takes an integer array and will randomize the values in the array
        // This method will also output the randomized array to a console window using a foreach construct
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

        // GreatestCommonDivisor - The greatest common divisor (GCD) of two integers 
        // is the largest integer that evenly divides both of the numbers.

        static int GreatestCommonDenominator(int a, int b)
        {
            
            while(b != 0)       // continue the loop until we reduce b to 0
            {
                int remainder = a % b;  // modulus operation to get remainder of a divided by b
                a = b;                  // swap a and b so we can continue the loop
                b = remainder;          // make b = to the remainder as that is what was left over from the modulus operation
            }

            return a;   // Once b has reached 0, that greatest common divisor is no present in a
        }
        #endregion
    }

}
