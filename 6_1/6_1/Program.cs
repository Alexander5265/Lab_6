using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите стороны треугольника #1: ");
        Triangle triangle1 = new Triangle();
        Console.Write("\nВведите стороны треугольника #2: ");
        Triangle triangle2 = new Triangle();
        
        Console.WriteLine("\nВаш треугольник #1: " + triangle1);
        Console.WriteLine("Существует: " + triangle1.Existance());
        Console.WriteLine("Ваш треугольник #2: " + triangle2);
        Console.WriteLine("Существует: " + triangle2.Existance());
        
        Console.WriteLine("\nПлощадь треугольника #1 = " + triangle1.Area());
        Console.WriteLine("Площадь треугольника #2 = " + triangle1.Area());
        
        Console.WriteLine("\nS треугольника #1 больше S треугольника #2: ");
        Console.WriteLine($"triangle1 > triangle2 {triangle1 > triangle2}");
        Console.WriteLine("S треугольника #2 больше S треугольника #1: ");
        Console.WriteLine($"triangle1 < triangle2 {triangle1 < triangle2}");
    }
}
