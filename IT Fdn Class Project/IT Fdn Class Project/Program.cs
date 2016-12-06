//File: IT Fdn Class Project

//Write a program to keep track of some inventory items as shown below.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Fdn_Class_Project
{
    struct ItemData                                  //struct with the data fields to work with
    {
        public int itemIDNo;
        public string sDescription;
        public double dblPricePerItem;
        public int iQuantityOnHand;
        public double dblOurCostPerItem;
    }

    class MyInventory
    {
        public static void Main(string[] args)      //start compiling

        {

            int aNum = 50;                     //use an integer to keep track of the possible # of items in your inventory    



            var iData = new ItemData[aNum];       //create an array of your ItemData struct

            iData[0].itemIDNo = 1;                                 //Initial data entries
            iData[0].sDescription = "Paperclips";
            iData[0].dblPricePerItem = .02;
            iData[0].iQuantityOnHand = 200;
            iData[0].dblOurCostPerItem = .01;

            iData[1].itemIDNo = 78;
            iData[1].sDescription = "Erasers";
            iData[1].dblPricePerItem = .05;
            iData[1].iQuantityOnHand = 50;
            iData[1].dblOurCostPerItem = .02;

            iData[2].itemIDNo = 4;
            iData[2].sDescription = "Pencils";
            iData[2].dblPricePerItem = .10;
            iData[2].iQuantityOnHand = 30;
            iData[2].dblOurCostPerItem = .03;

            iData[3].itemIDNo = 9;
            iData[3].sDescription = "Pens";
            iData[3].dblPricePerItem = .20;
            iData[3].iQuantityOnHand = 30;
            iData[3].dblOurCostPerItem = .10;

            iData[4].itemIDNo = 5;
            iData[4].sDescription = "Notepads";
            iData[4].dblPricePerItem = .35;
            iData[4].iQuantityOnHand = 30;
            iData[4].dblOurCostPerItem = .20;

            iData[5].itemIDNo = 42;
            iData[5].sDescription = "Rulers";
            iData[5].dblPricePerItem = .35;
            iData[5].iQuantityOnHand = 30;
            iData[5].dblOurCostPerItem = .22;

            iData[6].itemIDNo = 7;
            iData[6].sDescription = "DeathStars";
            iData[6].dblPricePerItem = 999;
            iData[6].iQuantityOnHand = 210;
            iData[6].dblOurCostPerItem = 50;


            int sp = 7;                               //Make a pointer (also a count of unique items actually on inventory)

            if (sp == aNum)                          //Increase amount of items available to add to struct
            {
                aNum = aNum + aNum;
            }

            bool run = true;
            //use a never ending loop that shows the user what options they can select
            while (run)
            {
                Console.WriteLine("1. Add an item.");
                Console.WriteLine("2. Change an item.");
                Console.WriteLine("3. Delete an item.");
                Console.WriteLine("4. List all items in the database.");
                Console.WriteLine("5. Quit.");
                Console.WriteLine();
                Console.Write("Please choose an option from the list(1, 2, 3, 4, or 5) ");


                //as long as no one Quits, continue the inventory update

                //in that loop, show what user can select from the list

                //read the user's input and then create what case it falls



                string strx = Console.ReadLine();      //read user's input

                int optx = int.Parse(strx);  //convert the given string to integer to match our case types shown below

                Console.WriteLine();  //provide an extra blank line on screen

                switch (optx)
                {
                    case 1:          //add an item to the list if this option is selected
                        {
                            Console.Write("Item ID No.: ");
                            string strno = Console.ReadLine();
                            int itemidno = int.Parse(strno);

                            bool duplicate = false;

                            for (int t = 0; t < sp; t++)
                            {
                                if (iData[t].itemIDNo == itemidno)
                                {
                                    Console.WriteLine("That Item ID already in use.");
                                    Console.WriteLine();
                                    duplicate = true;

                                }
                            }
                            if (duplicate != true)
                            {

                                Console.Write("Description: ");
                                string strdes = Console.ReadLine();

                                Console.Write("Price per item: ");
                                string strpr = Console.ReadLine();
                                double dblprice = double.Parse(strpr);

                                Console.Write("Quantity on hand: ");
                                string strqty = Console.ReadLine();
                                int intqty = int.Parse(strqty);

                                Console.Write("Our Cost per item: ");
                                string strcst = Console.ReadLine();
                                double dblcst = double.Parse(strcst);

                                Console.WriteLine();

                                iData[sp].dblOurCostPerItem = dblcst;
                                iData[sp].sDescription = strdes;
                                iData[sp].itemIDNo = itemidno;
                                iData[sp].dblPricePerItem = dblprice;
                                iData[sp].iQuantityOnHand = intqty;

                                sp++;

                            }

                            break;
                        }

                    //reset the count to show a new count for your list

                    //(Note: Your list is now increased by one item)




                    case 2:          //change items in the list if this option is selected
                        {
                            Console.Write("Please enter an item ID No:");
                            string strchgid = Console.ReadLine();
                            int chgid = int.Parse(strchgid);
                            bool fFound = false;
                            Console.WriteLine();

                            for (int x = 0; x < sp; x++)
                            {
                                if (iData[x].itemIDNo == chgid)
                                {
                                    fFound = true;
                                    Console.WriteLine("Which field would you like to change? ");
                                    Console.WriteLine("1. Description");
                                    Console.WriteLine("2. Price per item");
                                    Console.WriteLine("3. Quantity on hand");
                                    Console.WriteLine("4. Our cost per item");
                                    Console.WriteLine("5. Quit");

                                    Console.WriteLine("Enter option 1,2,3,4 or 5? ");
                                    Console.WriteLine();

                                    //code to show what has to happen if the item in the list is found

                                    string stry = Console.ReadLine();      //read user's input

                                    int opty = int.Parse(stry);  //convert the given string to integer to match our case types shown below

                                    Console.WriteLine();  //provide an extra blank line on screen

                                    switch (opty)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Enter new description: ");
                                                iData[x].sDescription = Console.ReadLine();
                                                Console.WriteLine();
                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.WriteLine("Enter new price per item: ");
                                                string strpr = Console.ReadLine();
                                                iData[x].dblPricePerItem = double.Parse(strpr);
                                                Console.WriteLine();
                                                break;
                                            }

                                        case 3:
                                            {
                                                Console.WriteLine("Enter new quantity on hand: ");
                                                string strqoh = Console.ReadLine();
                                                iData[x].iQuantityOnHand = int.Parse(strqoh);
                                                Console.WriteLine();
                                                break;
                                            }

                                        case 4:
                                            {
                                                Console.WriteLine("Enter new cost per item: ");
                                                string strcpi = Console.ReadLine();
                                                iData[x].dblOurCostPerItem = double.Parse(strcpi);
                                                Console.WriteLine();
                                                break;
                                            }

                                        case 5:
                                            {
                                                opty = 0;
                                                Console.WriteLine();
                                                break;
                                            }
                                        default:
                                            {
                                                Console.Write("Invalid Option, try again");
                                                Console.WriteLine();
                                                break;
                                            }

                                    }
                                }
                            }
                            if (!fFound)  //and if not found
                            {
                                Console.WriteLine("Item {0} not found", chgid);
                                Console.WriteLine();
                            }

                            break;
                        }
                    case 3: //delete items in the list if this option is selected
                        {
                            Console.Write("Please enter an item ID No: ");
                            string strnewid = Console.ReadLine();
                            int newid = int.Parse(strnewid);
                            bool fDeleted = false;

                            for (int x = 0; x < sp; x++)
                            {
                                if (iData[x].itemIDNo == newid)
                                {
                                    while (x < sp)
                                    {
                                        iData[x] = iData[x + 1];
                                        x++;
                                    }


                                    fDeleted = true;
                                    sp--;

                                    //delete the item if you found it
                                    //reset the count to show a new count for your list
                                    //(Note: your list is now reduced by one ite)
                                }
                            }
                            if (fDeleted)  //hint the user that you deleted the requested item
                            {
                                Console.WriteLine("Item deleted");
                                Console.WriteLine();
                            }
                            else  //if did not find it, hint the user that you did not find it in your list
                            {
                                Console.WriteLine("Item {0} not found", newid);
                                Console.WriteLine();
                            }
                            break;

                        }
                    case 4:       //list all items in current database if this option is selected
                        {
                            Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  ");
                            Console.WriteLine("-----  ------  --------------------  -----  ---  ----  ");
                            int x = 0;

                            foreach (var y in iData)
                            {
                                if (x == sp)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("{0,5}  {1,6}  {2,-20}  {3,5}  {4,3}  {5,4}", x + 1, iData[x].itemIDNo, iData[x].sDescription,
                                    iData[x].dblPricePerItem, iData[x].iQuantityOnHand, iData[x].dblOurCostPerItem);
                                    x++;
                                }
                            }
                            Console.WriteLine();

                            //code in this block. Use the above line format as a guide for printing or displaying the items in your list
                            //right under it

                            break;
                        }
                    case 5:       //quit the program if this option is selected
                        {
                            Console.Write("Are you sure that you want to quit(y/n)?");
                            string strresp = Console.ReadLine();
                            if (strresp == "y") //code
                            {
                                run = false;
                                optx = 0;     //as long as it is not 5, the process is not breaking
                            }
                            break;
                        }
                    default:
                        {
                            Console.Write("Invalid Option, try again");
                            break;
                        }
                }
            }
        }
    }
}
