using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30052023_Lab_Session_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 01: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 02: ");
            int no2 = int.Parse(Console.ReadLine());

            int sum = getSum(no1, no2);
            Console.WriteLine("Sum: " + sum);
        }

        static int getSum(int no1, int no2)
        {
            return no1 + no2;
        }
    }
}
