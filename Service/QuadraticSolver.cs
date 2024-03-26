using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class QuadraticSolver
    {
        private const int roundDigits = 2;

        public static (double x1, double x2)? Solve(double a, double b, double c)
        {
            var discriminant = SolveDiscriminant(a, b, c);
            if (discriminant < 0)
                return null;
            else if (discriminant == 0)
            {
                var x1 = -b / (2 * a);
                x1 = Math.Round(x1, roundDigits);
                return (x1, x1);
            }
            else
            {
                var x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                var x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                return (Math.Round(x1, roundDigits), Math.Round(x2, roundDigits));
            }
        }

        public static double SolveDiscriminant(double a, double b, double c) =>
            Math.Pow(b, 2) - 4 * a * c;
    }
}
