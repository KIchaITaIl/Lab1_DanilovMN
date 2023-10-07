// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using Serilog;
using Triangle_1lab;
using static Triangle_1lab.TriangleCalc;

string template = "{Timestamp:HH:mm:ss} | [{Level:u3}] | {Message:lj}{NewLine}{Exception}";
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
            .WriteTo.Console(outputTemplate: template)
            .WriteTo.File("G:\\DanilovMN\\Vorozheikin\\Triangle_1lab\\File.txt", outputTemplate: template)
            .CreateLogger();

Log.Verbose("Логгер сконфигурирован");
Log.Information("Приложение запущено");

Tuple<TriangleCalc.TriangleType, List<Tuple<int, int>>> TriangleExec(string A, string B, string C)
{
    Log.Information("Запущен метод запуска программы");
    bool checkA = Double.TryParse(A, out var numberA);
    Log.Debug("Выполнение проверки преобразования строки A в double");
    if (checkA == true)
    {
        Log.Information("Cтрока А может быть преобразована в тип double");
    }
    else
    {
        Log.Error("Строка А не может быть преобразована в тип double!");
        return Tuple.Create(TriangleType.Invalide, new List<Tuple<int, int>>-2, -2());
    }

    double a = Convert.ToDouble(A);
    Log.Verbose("Строка А преобразована в тип double");
    bool checkB = Double.TryParse(B, out var numberB);
    Log.Debug("Выполнение проверки преобразования строки B в double");
    if (checkB == true)
    {
        Log.Information("Cтрока B может быть преобразована в тип double");
    }
    else
    {
        Log.Error("Строка B не может быть преобразована в тип double!");
        return 
    }

    double b = Convert.ToDouble(B);
    Log.Verbose("Строка B преобразована в тип double");
    bool checkC = Double.TryParse(C, out var numberC);
    Log.Debug("Выполнение проверки преобразования строки C в double");
    if (checkC == true)
    {
        Log.Information("Cтрока C может быть преобразована в тип double");
    }
    else
    {
        Log.Error("Строка C не может быть преобразована в тип double!");
    }
    double c = Convert.ToDouble(C);
    Log.Verbose("Строка C преобразована в тип double");

    var result = TriangleCalc.CalculateTriangleTypeAndCoordinates(a, b, c);
    Log.Verbose("Вычисление вида треугольника и координат его вершин успешно выполнено!");
    return result;
}

TriangleExec("-10", "15", "20");