using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    public static class TriangleSolver
    {
        public static string Analyse(int x, int y, int z)
        {
            if ((x == y) && (y == z))
            {
                return "Equilateral";
            }

            if (((x == y) && (y != z)) || ((x!=y) && (y==z)) ||((x==z) && (z != y)))
            {
                return "Isosceles";
            }

            return "Scalene";
        }
    }
}
