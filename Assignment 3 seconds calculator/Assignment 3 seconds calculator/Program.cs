//File:  Assignment 3 seconds calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_seconds_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNum = 1;
            int day = 86400;
            int hour = 3600;
            int min = 60;
            int sec = 1;
            int Days = 0;
            int Hours = 0;
            int Mins = 0;
            int Secs = 0;
            bool flag = true;

            while (flag == true)
            {

                Console.Write("Enter a positive whole number for seconds to be converted: ");
                string str = Console.ReadLine();

                try
                {
                    aNum = int.Parse(str);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.ReadLine();
                    continue;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter a positive value of {0} or less", Int32.MaxValue);
                    Console.ReadLine();
                    continue;
                }
                if (aNum < 0)
                {
                    Console.WriteLine("Negative numbers are not allowed");
                    Console.ReadLine();
                    continue;
                }
                else
                {
                    Days = aNum / day;
                    int dRem = (aNum % day);
                    if (dRem != 0)
                    {
                        Hours = dRem / hour;
                    }
                    //Hours = ((aNum % day) / hour);
                    int hRem = (dRem % hour);
                    if (hRem != 0)
                    {
                        Mins = hRem / min;
                    }
                    //Mins = (((aNum % day) % hour) / min);
                    int mRem = (hRem % min);
                    if (mRem != 0)
                    {
                        Secs = mRem / sec;
                    }
                    //Secs = (((aNum % day) / hour) % min / sec);

                    Console.WriteLine("{0} equals {1} days, {2} hours, {3} mins and {4} secs.", aNum, Days, Hours, Mins, Secs);
                    Console.ReadLine();
                    break;
                }
                

            }
            flag = false;
            
        }
    }
}
