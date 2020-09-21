/* 
 Author: Brett Hartman
 Date: 9/19/20
 Comments: This C# Console application code is for TechProject 3B.
           It demonstrates the use of Arrays.
*/
using System;

namespace TechProject3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below is an array with 25 elements.");
            Console.WriteLine("Each value of the elements is listed.");

            // Define and populate an array
            int[] manual = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            // Display each value in the array
            foreach(int i in manual)
            {
                Console.WriteLine("Element Value = " + i);
            }
        } // End Main
    } // End Class
} // End Namespace
