using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_1lab
{
    internal class TriangleCalc
    {
        public enum TriangleType
        {
            NotTriangle,
            Equilateral,
            Isosceles,
            Scalene
        }

        public static Tuple<TriangleType, List<Tuple<int, int>>> CalculateTriangleTypeAndCoordinates(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Invalid input. All sides must be positive.");
                return Tuple.Create(TriangleType.NotTriangle, new List<Tuple<int, int>>());
            }

            if (!(a + b > c && a + c > b && b + c > a))
            {
                Console.WriteLine("The input values do not form a triangle.");
                return Tuple.Create(TriangleType.NotTriangle, new List<Tuple<int, int>>());
            }

            List<Tuple<int, int>> scaledCoordinates = ScaleCoordinates(a, b, c);

            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral triangle");
                return Tuple.Create(TriangleType.Equilateral, scaledCoordinates);
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Isosceles triangle");
                return Tuple.Create(TriangleType.Isosceles, scaledCoordinates);
            }
            else
            {
                Console.WriteLine("Scalene triangle");
                return Tuple.Create(TriangleType.Scalene, scaledCoordinates);
            }

        }

        private static List<Tuple<int, int>> ScaleCoordinates(double a, double b, double c)
        {
            double maxSide = Math.Max(a, Math.Max(b, c));
            double scalingFactor = 100 / maxSide;
            var scaledCoordinates = new List<Tuple<int, int>>();
            scaledCoordinates.Add(Tuple.Create((int)(a * scalingFactor), (int)(a * scalingFactor)));
            scaledCoordinates.Add(Tuple.Create((int)(b * scalingFactor), (int)(b * scalingFactor)));
            scaledCoordinates.Add(Tuple.Create((int)(c * scalingFactor), (int)(c * scalingFactor)));
            return scaledCoordinates;
        }
    }
}
