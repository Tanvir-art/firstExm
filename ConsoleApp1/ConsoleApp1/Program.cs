using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem;
            int count = 0;
            int reverse = 0;
            Console.WriteLine("Please give a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            for (int i = 2; i < reverse; i++)
            {
                if (reverse % i == 0)
                {
                     count = count + 1;
                }
            }
            if (count==0)
            {
                Console.Write("this prime number:" +reverse +"(prime)");
            }
            else
            {
                Console.WriteLine("this is not prime number");
            }
        }
    }
}
