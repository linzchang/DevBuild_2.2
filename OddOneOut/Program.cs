using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for and validate input to find range
            Console.WriteLine("Let's find the Sum and Average of the odd numbers in a range of numbers.");
            int userRange = GetNumbers("How big should the range be? Please enter a positive, whole number.");

            //correctly find sum of odd numbers in range
            int sum = FindSum(userRange);

            //correcly calculates average of odd numbers in range
            double average = FindAverage(userRange, sum);

            //print sum and average to console
            Console.WriteLine($"You entered a range of {userRange}. The sum of the odd numbers in this range is {sum}. The average of the odd numbers in this range is {average}.");
            Console.ReadLine();
        }

        static int GetNumbers(string message)
        {
            int number;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine($"Sorry that's invalid, please try again! {message}");
            }
            return number;
        }

        static int FindSum(int range)
        {
            //correctly find sum of odd numbers in range
            int number = 0;
            
            //use for loop to find sum of all odd numbers between 1 and a number (n) provided by user
            for (int i = 0; i < range; i++)
            {
                if ((i % 2) != 0)
                {
                    number += i;
                }
            }
            return number;
        }

        static double FindAverage(int range, int sum)
        {
            double average = (double)sum / range;

            return average;
        }
    }
}
