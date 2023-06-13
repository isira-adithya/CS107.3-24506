using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13062023_LabSession
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            return (2 * Math.PI * radius);
        }

        public double findCircumference(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }
    }
}
