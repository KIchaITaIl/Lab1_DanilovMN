// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using Triangle_1lab;

void TriangleExec (string A, string B, string C)
{
    double a = Convert.ToDouble (A);
    double b = Convert.ToDouble (B);
    double c = Convert.ToDouble (C);
    var result = TriangleCalc.CalculateTriangleTypeAndCoordinates(a, b, c);
    string TriangleTypeResPer = Convert.ToString(result.Item1);
    string TriangleTypeRes(string TriangleTypeResPer)
    {
        return TriangleTypeResPer;
    }

}

TriangleExec("10", "15", "20");

//var result = TriangleCalc.CalculateTriangleTypeAndCoordinates(a, b, c);

//Console.WriteLine($"Тип треугольника: {result.Item1}");
//Console.WriteLine("Координаты вершин:");
//foreach (var coordinate in result.Item2)
//{
//    Console.WriteLine($"({coordinate.Item1}, {coordinate.Item2})");
//}