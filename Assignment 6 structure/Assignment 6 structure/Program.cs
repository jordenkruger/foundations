//Assignment 6 structure

//Assignment #6
//Copy this block into your Visual Studio.
// Review and Redo this code line by line at home.  
// Place comments on each line and describe what the code is doing

using System;  //Allows use of the System library



namespace ConsoleApplication1
{                                       //bracket starting namespace
    public struct Pet                   //Creates a public struct named Pet
    {                                   //bracket starting strucet Pet
        public string Name;             //Declares a public string named Name
        public string TypeOfPet;        //Declares a public string named TypeOfPet
    }                                   //Ends struct Pet
    class Program                       //Creates a class called Program
    {                                   //Bracket starting class Program
        static void Main()              //The Main() line where the compiler interpreting the program
        {                               //Bracket for Main()
            var numberOfPets = 0;                             //Declares and initializes to 0 the variable NumberOfPets
            var pets = new Pet[10];                           //Declares and initializes an array of type struct Pet
            while (true)                                      //Begins a neverending loop
            {                                                 //While loop bracket
                Console.Write("A)dd D)elete L)ist pets:");    //Writes text in parentheses to Console prompting user for input
                var choice = Console.ReadLine();              //Declares choice and initializes it to take keystrokes entered at Cmd prompt and 
                switch (choice)                               //Begins switch statement
                {                                             //Switch bracket
                    case "A":                                 //compiler runs this case's code if user entered a capital A.  I guess if the case statement is empty it just slides to the next case
                    case "a":                                 //compiler runs this case's code if user entered a small case a
                        {                                     //bracket for start of case A,a
                            Console.Write("Name :");                           //Writes text to Console
                            var name = Console.ReadLine();                     //Declares name and initializes it to take keystrokes at Cmd prompt
                            Console.Write("Type of pet :");                    //Writes text to Console
                            var typeOfPet = Console.ReadLine();                //Declares typeOfPet and initializes it to take keystrokes at Cmd prompt
                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;                    //Assigns the value of the variable name to the Name field of the numberOfPets element of the array of struct pets of type struct Pet
                            pets[numberOfPets].TypeOfPet = typeOfPet;          //Assigns the value of the variable typeOfPet to the TypeOfPet field of the numberOfPets element of the array of struct pets of type struct Pet
                            numberOfPets++;                                    //Increments the numberOfPets variable so that the next time this case is called it will fill the next available element of the array
                            break;                                             //breaks out of the switch statement
                        }                                                      //bracket for the end of case A,a
                    case "D":                                                  //compiler runs this case's code if user entered a capital D
                    case "d":                                                  //compiler runs this case's code if user entered a small case d
                        {                                                      //bracket for start of case D,d
                            if (numberOfPets == 0)                             //if numberOfPets is equal to 0 this code will compile
                            {                                                  //bracket that begins the if code
                                Console.WriteLine("No pets");                  //Writes text to Console
                                break;                                         //breaks out of switch statement.  There are no pets to delete
                            }                                                  //bracket that ends the if statement
                            for (var index = 0; index < numberOfPets; index++) //for statement that initializes the variable index to 0, then as long as index is less than numberOfPets the code executes, after execution the index variable is incremented and checked against the numberOfPets.  If >= then skips over.
                            {                                                  //bracket that begins the for loop
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);    //Writes thee different variables to Console. {0} will be 
                                                                                                                              //replaced by the result of index + 1, {1,-10} will assign 10
                                                                                                                              // spaces and left justify the text of variable pets[index].Name,
                                                                                                                              //{2} is pets[index].TypeOfPet 
                            }                                                   //bracket that ends the for loop.  The whole list of pets will have been printed to Console.
                            Console.Write("Which pet to remove (1-{0})", numberOfPets);            //Writes text asking user to enter number for pet to be deleted from list                
                            var petNumberToDelete = Console.ReadLine();                            //Takes the input and initializes it to the variable petNumberToDelete
                            var indexToDelete = int.Parse(petNumberToDelete);                      //Parses petNumberToDelete to integer and initializes it to indexToDelete
                            // Squish the array from index to the end
                            for (var index = indexToDelete - 1; index < numberOfPets; index++)     //for loop that initializes index to the number user wishes to delete minus 1,
                                                                                                   //checks to see if index is less than numberOfPets, if so the for loop code will execute
                                                                                                   //after execution index will be incremented and checked against numberOfPets
                            {                                                                      //bracket that starts the for loop
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];             //Exactly.  Copy over the index user wishes to delete
                            }                                              //End for loop bracket
                            // We have one less pet
                            numberOfPets--;                                //decrements numberOfPets
                            break;                                         //breaks from switch statement back to while statement
                        }                                                  //bracket to end case D,d
                    case "L":                                              //Switch to here if user inputs L
                    case "l":                                              //Or here if user inputs l
                        {                                                  //bracket to start the case
                            if (numberOfPets == 0)                         //if numberOfPets is equal to 0 do the code
                            {                                              //if statement start bracket
                                Console.WriteLine("No pets");              //Writes text in parentheses
                            }                                              //end if bracket
                            for (int index = 0; index < numberOfPets; index++)            //for loop that initializes index to 0, and executes as long as index is less than numberOfPets,  increments index and checks it against numberOfPets again
                            {                                                                                               //for loop start bracket
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);  //Writes an element from the array of struct pets to Console.
                            }                                                             //for loop end bracket.  Will have written the list of pets
                            break;                                                        //breaks out of the switch statement
                        }                                                                 //bracket ending the case L,l
                    default:                                                              //default choice if user enters something not in the case statements
                        {                                                                 //bracket starts default 
                            Console.WriteLine("Invalid option [{0}]", choice);            //writes text showing user their fault
                            break;                                                        //breaks from switch statement
                        }                                                                 //bracket ending default
                }                    //bracket ends switch module
            }                        //bracket ends while loop
        }                            //bracket ending Main statement
    }                                //bracket ends class Program
}                                    //bracket closing the namespace