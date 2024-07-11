using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            bool isPrime = true;
            Console.WriteLine("Enter the number");
            myNumber = Convert.ToInt32(Console.ReadLine());
            if (myNumber == 0 || myNumber == 1)
            {
                Console.WriteLine(myNumber + " is not a Prime Number");
                isPrime = false;
            }

            else
            {
                for (int i = 2; i < Math.Sqrt(myNumber); i++)
                {
                    if (myNumber % i == 0)
                    {

                        Console.WriteLine(myNumber + " is not a prime number");
                        isPrime = false;
                        break;

                    }

                }
            }

            if (isPrime)
            {
                Console.WriteLine(myNumber + " is a prime number");
            }
        }
    }
}
