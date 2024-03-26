using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    public static class QuadraticSolver
    {
        public static int Solver(int a, int b, int c)
        {
            var discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (discriminant < 0)
                return 0;
            
            var x1 = (-b + Math.Sqrt(discriminant)) / (2 *a );
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 *a );
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            return 0;
        }
    }
}
