﻿using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

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

            var numberArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            Populater (numberArray);
           
            //TODO: Print the first number of the array
            Console.WriteLine("First:");
            Console.WriteLine(numberArray[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine("Last:");
           Console.WriteLine(numberArray[numberArray.Length-1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists

            NumberPrinter(numberArray);
            Console.WriteLine("----------");
            Console.WriteLine(numberArray);


            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numberArray);     
            NumberPrinter(numberArray);
            Console.WriteLine();

           Console.WriteLine("-------------------"); 

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
           

            Console.WriteLine("Multiple of three = 0: ");
             ThreeKiller(numberArray);
            NumberPrinter(numberArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(numberArray);
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            var list  = new List<int>();
            //List<int> list = new List<int>();




            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capacity:");
            Console.WriteLine(list.Capacity);
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(list);

            //TODO: Print the new capacity
            Console.WriteLine("Capacity:");
            Console.WriteLine(list.Capacity);
            

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            bool answer = int.TryParse(Console.ReadLine(), out int number);
            NumberChecker(list, number);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
       
            NumberPrinter(list);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);    
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            int[] converted = list.ToArray(); 
            //TODO: Clear the list
            
            list.Clear();
            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                { numbers[i] = 0; }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0 ; i--)
            {
                numberList[i] = 0;
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNumber = false;
            foreach (int item in numberList)
            {
                if (item == searchNumber)
                {Console.WriteLine($"{item } is in the list" );
                    foundNumber = true;
                    break;
                }
           
               
        }     
            { if (foundNumber == false)
                Console.WriteLine($" {searchNumber} Not in list");
            }  }
           

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            //  int index = 0;

            for (int i = 1; i < 50; i++)
            {
                int randomNumber = rng.Next(1, 51);
                numberList.Add(randomNumber);
            }
        }
        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
          //  int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
              //  index++;
            }

        }        

        private static void ReverseArray(int[] array)
        {
            var newArray = new int[array.Length];
            int index = 0;
            for (int i= array.Length; i >= 0; i--)
            {
                newArray[index] = array[i];
                index++;
            }
        }

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
