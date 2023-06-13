using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13062023_LabSession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 01: ");
            double no1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Number 02: ");
            double no2 = double.Parse(Console.ReadLine());


            CalculateValues calculateValues = new CalculateValues();
            Console.Write("\n\nEnter 1 for Addition\nEnter 2 for Substraction\nEnter 3 for Multiplication\nEnter 4 for Division\n\nEnter your choice: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "1":
                    Console.WriteLine(no1 + " + " + no2 + " = " + calculateValues.addition(no1, no2));
                    break;
                case "2":
                    Console.WriteLine(no1 + " - " + no2 + " = " + calculateValues.substraction(no1, no2));
                    break;
                case "3":
                    Console.WriteLine(no1 + " * " + no2 + " = " + calculateValues.multiplication(no1, no2));
                    break;
                case "4":
                    Console.WriteLine(no1 + " / " + no2 + " = " + calculateValues.division(no1, no2));
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
