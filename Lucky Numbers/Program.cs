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
            //Step one
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

            //Step two
            //Creating new array, and making program enter 6 random numbers between users specified first/last numbers within new array.
            Console.WriteLine("And now to display our six lucky numbers!");
            int[] luckyNumb = new int[6];

            Random numGenerate = new Random();
            for (int j = 0; j< 6; j++)
            {
                luckyNumb[j] = numGenerate.Next(firstNum, lastNum);
                Console.WriteLine("Lucky Number: " + luckyNumb[j]);
            }

            //Step three
            //Program announces the rate of winnings to the user ( every win gains the user 1$).
            //Use nested loop to have program confirm if player's guesses are equal to the random numbers generated.
            //If-else used to add +1$ to winnings for ever iteration of the loop that is found to be equal.

            Console.WriteLine("For every number guessed correctly the user will receive 1$, for a total of 6$ for any person who guesses all six lucky numbers correctly!");
            

            int winnings = 0;    
            
            for (int k = 0; k < 6; k++)
            {                
                for (int l = 0; l < 6; l++)
                {
                    if(numbersGuessed[l] == luckyNumb[k])
                    {
                        winnings++;
                    }                 
                }                
            }
            Console.WriteLine("You got" + winnings + " correct!");
            Console.WriteLine("You've won " + winnings + "$");



            
        }
    }
}
