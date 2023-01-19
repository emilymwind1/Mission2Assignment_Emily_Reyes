// Emily Reyes
// Mission #2 Assignment

//import libraries
using System;

// name of program and overall container
namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create random number variable
            Random r = new Random();

            // create empty array with 11 spaces
            int[] rollArray = new int[11];

            // create variable to hold stars
            string histStars = "";

            // write welcome statement
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            // assign the user input as numRolls
            int numRolls = Int32.Parse(Console.ReadLine());

            // loop through number of rolls and roll 2 random numbers between 1 and 6
            for (int counter = 0; counter < numRolls; counter++)
            {
                int numberRolled = r.Next(1, 7);
                int numberRolled2 = r.Next(1, 7);

                // add two dice together
                int rollTotal = numberRolled + numberRolled2;

                rollArray[rollTotal - 2] = rollArray[rollTotal - 2] + 1;
            }

            // convert number of times a number was rolled into a percentage
            for (int counter = 0; counter < 11; counter++)
            {
               double rollPct = ((double)rollArray[counter] / (double)numRolls)*100;
                rollArray[counter] = Convert.ToInt32(rollPct);
            }

            // write result statements
            Console.WriteLine(" ");
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + Convert.ToString(numRolls));
            Console.WriteLine(" ");

            // loop through each dice total count and convert to stars
            for (int counter = 0; counter < 11; counter++)
            {
                histStars = "";
                histStars = new string('*', rollArray[counter]);
                string number = Convert.ToString(counter + 2);
                Console.WriteLine(number + ':' + histStars);
            }

            // write thank you line
            Console.WriteLine(" ");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
