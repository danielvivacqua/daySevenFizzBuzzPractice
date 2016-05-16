using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daySevenFizzBuzzPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "2 7 15"; //simulating CodeEval input, do not copy and paste this line
            string[] arrayOfNumbers = line.Split(); //splitting string line into an array that holds each number (still as a string though)
            int fizz = int.Parse(arrayOfNumbers[0]); //Fizz Number
            int buzz = int.Parse(arrayOfNumbers[1]); //Buzz Number
            int limit = int.Parse(arrayOfNumbers[2]); //How high we're going to count


            for (int counter = 1; counter <= limit; counter++)

            {
                if (counter % fizz == 0 && counter % buzz == 0)
                {
                    Console.WriteLine("FB");
                }
                else if (counter % fizz == 0)
                {
                    Console.WriteLine("F");
                }
                else if (counter % buzz == 0)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
