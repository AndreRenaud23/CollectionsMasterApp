using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] myIntArray = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater(myIntArray);

            Console.WriteLine("First Number: ");
            //TODO: Print the first number of the array\
            Console.WriteLine(myIntArray[0]);

            //TODO: Print the last number of the array
            Console.WriteLine("Last Number: ");
            Console.WriteLine(myIntArray[^1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myIntArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */



            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myIntArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(myIntArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */

            Console.WriteLine("Sorted numbers:");

            Array.Sort(myIntArray);
            NumberPrinter(myIntArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> myList = new List<int>();


            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"Capacity: {myList.Capacity}");


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {myList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!

            int userNumber;
            bool isANumber;


            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (isANumber == false);

            NumberChecker(myList, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(myList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var anArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> myNumberList)
        {
            for (int i = myNumberList.Count - 1; i >= 0; i--)
            {
                if (myNumberList[i] % 2 != 0)
                {
                    myNumberList.Remove(myNumberList[i]);
                }
            }


            NumberPrinter(myNumberList);
        }

        private static void NumberChecker(List<int> myNumberList, int searchNumber)
        {
            if (myNumberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yay! We have that number");
            }
            else
            {
                Console.WriteLine($"Sorry! That number isn't available");
                Console.WriteLine($"Come some time later :)");
            }
        }

        private static void Populater(List<int> myNumberList)
        {

            while (myNumberList.Count < 50)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                myNumberList.Add(number);
            }

            NumberPrinter(myNumberList);
        }

        private static void Populater(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

        }

        private static void ReverseArray(int[] myArray)
        {
            Array.Reverse(myArray);

            NumberPrinter(myArray);

        }



        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
