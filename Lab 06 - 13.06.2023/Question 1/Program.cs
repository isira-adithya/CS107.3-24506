using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13062023_LabSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double _radius = double.Parse(Console.ReadLine());

            FindValues findValues = new FindValues();

            Console.WriteLine("Area: " + findValues.findArea(_radius));
            Console.WriteLine("Circumference: " + findValues.findCircumference(_radius));
        }
    }
}
