using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30052023_Lab_Session
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            printDetails(name, age);

            

        }

        static void printDetails(string name, int age)
        {
            Console.WriteLine("Hi " + name + ", you are " + age + " years old.");
        }

        static void countFrom10to1()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }


        static void findAverage()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the number " + (i + 1) + ": ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Average: " + (sum / 10.0f));
        }
    }
}
