using System;

class Program
{
    static void Main(string[] args)
    {
        // Pobieranie współczynników od użytkownika
        Console.WriteLine("Podaj wartość współczynnika a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wartość współczynnika b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wartość współczynnika c:");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj wartość współczynnika d:");
        double d = Convert.ToDouble(Console.ReadLine());

        // Pobieranie wartości x od użytkownika
        Console.WriteLine("Podaj wartość x:");
        double x = Convert.ToDouble(Console.ReadLine());

        // Obliczanie wartości funkcji sześciennej
        double result = CalculateCubicFunction(a, b, c, d, x);

        // Wyświetlanie wyniku
        Console.WriteLine($"Wartość funkcji sześciennej dla x = {x} wynosi: {result}");
    }

    static double CalculateCubicFunction(double a, double b, double c, double d, double x)
    {
        return a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d;
    }
}