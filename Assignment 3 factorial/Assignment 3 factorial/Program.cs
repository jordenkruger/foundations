// File: Assignment 3 factorial
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int fact = 1;
            int bNum = 0;
            int aNum = 1;
            bool flag = true;

            while (flag = true)
            {
                Console.Write("Enter a whole number of 10 or less: ");
                string str = Console.ReadLine();

                // In case user enters something that doesn't look like an integer
                try
                {
                    aNum = int.Parse(str);
                }
                catch (FormatException e)
                {   
                    //User gets a do over for entering gibberish
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.ReadLine();
                    continue;
                }

                bNum = aNum;

                //Factorials of 0 = 1
                if (bNum == 0)
                {
                    bNum = 1;
                }
                //Number to be factored must be within range(positive and non-negative would help)
                if (bNum >= 1 && bNum <= 10)
                {   
                    //Factor away little buddy
                    while (x <= bNum)
                    {
                        fact = fact * x;
                        x++;
                    }
                    //Show output of number factored
                    Console.WriteLine("The factorial of {0} is {1}.", aNum, fact);
                    Console.ReadLine();
                }
                else
                {
                    //User gets a do over for numbers entered out of range
                    Console.WriteLine("Number entered is out of range:");
                    Console.WriteLine();
                    continue;
                }
                //exit the loop
                break;
            }
            //Stop looping
            flag = true;
        }
    }
}
