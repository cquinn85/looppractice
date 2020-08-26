using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Practice_loops
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x) ;
            }

            var myArray = new int[] { 2, 4, 6, 8, 10 };

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
