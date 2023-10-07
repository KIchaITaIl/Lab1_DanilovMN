using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace Triangle_1lab
{
    
    internal class TriangleCalc
    {
        public enum TriangleType
        {
            NotTriangle,
            Equilateral,
            Isosceles,
            Scalene,
            Invalide
        }

        

        public static Tuple<TriangleType, List<Tuple<int, int>>> CalculateTriangleTypeAndCoordinates(double a, double b, double c)
        {
            Log.Verbose("Метод вычисления вида треугольника запущен");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Log.Warning("Некорректный ввод данных, числа должны быть положительными!");
                
                return Tuple.Create(TriangleType.NotTriangle, new List<Tuple<int, int>>());
            }

            if (!(a + b > c && a + c > b && b + c > a))
            {
                Log.Warning("Введенные данные не формируют треугольник");

                Console.WriteLine("The input values do not form a triangle.");
                return Tuple.Create(TriangleType.NotTriangle, new List<Tuple<int, int>>());
            }

            List<Tuple<int, int>> scaledCoordinates = ScaleCoordinates(a, b, c);
            Log.Verbose("Метод вычисления координат вершин треугольника успешно выполнен");

            if (a == b && b == c)
            {
                Log.Information("Равностороний треугольник");
                return Tuple.Create(TriangleType.Equilateral, scaledCoordinates);
            }
            else if (a == b || a == c || b == c)
            {
                Log.Information("Равнобедренный треугольник");
                return Tuple.Create(TriangleType.Isosceles, scaledCoordinates);
            }
            else
            {
                Log.Information("Неравносторонний треугольник");
                return Tuple.Create(TriangleType.Scalene, scaledCoordinates);
            }

        }

        private static List<Tuple<int, int>> ScaleCoordinates(double a, double b, double c)
        {
            Log.Verbose("Запущен метод вычисление координат вершин треугольника");
            double maxSide = Math.Max(a, Math.Max(b, c));
            Log.Debug("Вычисление длинной стороны");
            double scalingFactor = 100 / maxSide;
            Log.Debug("Вычисление коэффициента масштабирования");
            var scaledCoordinates = new List<Tuple<int, int>>();
            Log.Debug("Создание списка координат вершин треугольника");
            scaledCoordinates.Add(Tuple.Create((int)(a * scalingFactor), (int)(a * scalingFactor)));
            Log.Debug("Вычисление координаты вершины А");
            scaledCoordinates.Add(Tuple.Create((int)(b * scalingFactor), (int)(b * scalingFactor)));
            Log.Debug("Вычисление координаты вершины B");
            scaledCoordinates.Add(Tuple.Create((int)(c * scalingFactor), (int)(c * scalingFactor)));
            Log.Debug("Вычисление координаты вершины C");
            return scaledCoordinates;
        }
    }
}
