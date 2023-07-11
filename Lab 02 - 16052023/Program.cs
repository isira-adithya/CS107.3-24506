# RPIAR Pathirana - 24506

using System;

namespace Lab_16052023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n------------------ Question 01 -------------------");
            Question01();
            Console.WriteLine("\n\n------------------ Question 02 -------------------");
            Question02();
            Console.WriteLine("\n\n------------------ Question 03 -------------------");
            Question03();
            Console.WriteLine("\n\n------------------ Question 04 -------------------");
            Question04();
            Console.WriteLine("\n\n------------------ Question 05 -------------------");
            Question05();
        }

        static void Question01()
        {
            Console.Write("Enter Number 01: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 02: ");
            int no2 = int.Parse(Console.ReadLine());

            Console.WriteLine(no1 + " + " + no2 + " = " + (no1 + no2));
        }

        static void Question02()
        {
            Console.Write("Enter Number 01: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 02: ");
            int no2 = int.Parse(Console.ReadLine());

            Console.WriteLine(no1 + " + " + no2 + " = " + (no1 + no2));
            Console.WriteLine(no1 + " - " + no2 + " = " + (no1 - no2));
            Console.WriteLine(no1 + " / " + no2 + " = " + (no1 / no2));
            Console.WriteLine(no1 + " * " + no2 + " = " + (no1 * no2));
        }

        static void Question03()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());   
            
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * (Math.Pow(radius, 2));

            Console.WriteLine("Circumference of the circle: " + circumference);
            Console.WriteLine("Area of the circle: " + area);

        }

        static void Question04()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is an even number");
            } else
            {
                Console.WriteLine("Number is an odd number");
            }
        }

        static void Question05() {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter Number {i}: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"Number {i} is an even number");
                }
                else
                {
                    Console.WriteLine($"Number {i} is an odd number");
                }
            }
        }
    }
}
