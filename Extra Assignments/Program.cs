using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Extra Assignments");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------PART 1---------------");
            Console.ForegroundColor = ConsoleColor.White;

            /*Write a program in C# Sharp to display the multiplication table of a given integer. 
            Test Data : 
            Input the number (Table to be calculated) : 15 
            Expected Output : 
            15 X 1 = 15 
            ... 
            ... 
            15 X 10 = 150 
            */

            Console.Write("Input the number (Table to be calculated): ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine(); // spacer

            // for loop, starts a 1 and end at 10. increment i
            for (int i = 1; i <= 10; i++)
            {
                int product = i * userInput;
                Console.WriteLine($"{userInput} X {i} = {product}");
            }

            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();


            //PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 2---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            Write a C# Sharp program to display the n terms of odd natural numbers and their sums. 
            Test Data 
            Input number of terms : 10 
            Expected Output : 
            The odd numbers are :1 3 5 7 9 11 13 15 17 19 
            The Sum of odd Natural Number upto 10 terms : 100 
            */

            // user inputs number of terms
            Console.Write("Input number of terms: ");
            int terms = int.Parse(Console.ReadLine()); // asigns term

            int oddNumbers = 1; // first odd number is 1
            int sum = 0;
            Console.Write($"\nThe odd numbers are: ");

            // for loop, starts a 1 and end at terms
            for (int i = 1; i <= terms; i++)
            {
                Console.Write($"{oddNumbers} "); // displays odd number
                sum += oddNumbers; // for displaying term at the end
                oddNumbers += 2; // increment by 2 for odd numbers
            }

            // displays sum
            Console.WriteLine($"\n\nThe Sum of odd Natural Number upto {terms} terms: {sum}");


            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();


            // PART 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 3---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            Write a program in C# Sharp to display a right angle triangle with an asterisk. 
            The pattern like : 
              * 
              ** 
              *** 
              **** 

            */

            // user inputs number of rows
            Console.Write("Enter how many rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine(); // spacer

            // for loop, starts at 1, ends at equal to rows
            for (int i = 1; i <= rows; i++)
            {
                // for loop, starts at 1, loop ends when number of '*' = j
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*"); // prints '*' j number of times
                }
                Console.WriteLine(); // new line
            }


            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();


            // PART 4
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 4---------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            /*
            Write a program in C# Sharp to make such a pattern like a right angle triangle with a 
            number which repeats a number in a row. 
            The pattern like : 
                 1 
                 22 
                 333 
                 4444 
             */

            Console.Write("Enter how many rows: ");
            int numberedRows = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // for loop, starts at 1, ends at equal to rows
            for (int i = 1; i <= numberedRows; i++)
            {
                // for loop, starts at 1, loop ends when number of '*' = j
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i); //prints i, j number of times
                }
                Console.WriteLine(); // new line
            }

            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();


            // PART 5
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 5---------------\n");
            Console.ForegroundColor = ConsoleColor.White;


            /*Take input from user to fill in the array 
             * of any size and find sum of all elements in the array
             */


            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arr = new int[size];
            sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }


            Console.WriteLine($"The sum of your array is {sum}");


            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");

            Console.ReadKey();
        }
    }
}
