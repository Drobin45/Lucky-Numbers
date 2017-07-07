using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initializing beginning text for program. Asking user to input the first and last possible numbers...
            //... used for random number generation(RNG from here forward)

            Console.WriteLine("Welcome to the world of gambling! Enjoy the following program responsibly!");
            Console.WriteLine("Please type starting number for number generation.");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type ending number for number generation.");
            int lastNum = int.Parse(Console.ReadLine());


            //Allowing user to input data for the array 'numbersGuessed'. 
            //Created an empty array, and maee a loop that allows user to input his/her 6 gambling numbers
            Console.WriteLine("Please type your 6 lottery guesses separately");            
            int[] numbersGuessed = new int[6];         
            
            for (int i = 0; i < 6; i++)
            {
                numbersGuessed[0] = int.Parse(Console.ReadLine());
                if (numbersGuessed[0] >= lastNum)
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }

            //Making program enter 6 random numbers between users specified first/last numbers.
            Console.WriteLine("And now to display our six lucky numbers!");
            int[] luckyNumb = new int[6];

            for (int j = 0; j< 6; j++)
            {
                Random numGenerate = new Random();
                Console.WriteLine(numGenerate.Next(firstNum, lastNum));
            }
            








            //numbersGuessed[1] = int.Parse(Console.ReadLine());
            //numbersGuessed[2] = int.Parse(Console.ReadLine());
            //numbersGuessed[3] = int.Parse(Console.ReadLine());
            //numbersGuessed[4] = int.Parse(Console.ReadLine());
            //numbersGuessed[5] = int.Parse(Console.ReadLine());







            ////nameOfArray[index] = Element;



            ////The below can take elements from DIFFERENT ARRAYS and put them on the same line together. Useful!

            //Console.WriteLine("{0}, {1}, {2}, {3}", cohortNames[0], cohortNames[1], cohortNames[2], cohortNames[3]);
        }
    }
}
