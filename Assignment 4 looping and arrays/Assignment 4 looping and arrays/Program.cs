//File: Assignment 4 looping and arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_looping_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int b = 0;
            int afact = 1;

            Console.Write("Please enter a number you wish to factor: ");
            string strNum = Console.ReadLine();

            int aNum = int.Parse(strNum);
            int[] numbers = new int[aNum];
            int[] fact = new int[aNum];
            
            while (x < aNum)
            {
                b = x + 1;
                numbers[x] = b;
                x++;
            }

            for (x = 0; x < aNum; x++)
            {
                afact = afact * (x + 1);
                fact[x] = afact;
            }

            x = 0;

            Console.WriteLine();
            Console.WriteLine("Factorials of 1 through {0}", aNum);
            Console.WriteLine();

            foreach (int y in numbers)
            {
                Console.WriteLine("{0}!   =   {1}", numbers[x], fact[x]);
                x++;
            }
            Console.ReadLine();
        }
    }
}
