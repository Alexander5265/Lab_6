using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double sideA, sideB, sideC;
        Console.Write("Введите стороны треугольника #1:\n ");
        Triangle triangle1 = new Triangle();
        Console.Write("\nВведите стороны треугольника #2:\n ");
        Triangle triangle2 = new Triangle();
        
        Console.WriteLine("Ваш треугольник: " + triangle1);
        Console.WriteLine("Существует: " + triangle1.Existance());
        Console.WriteLine("\nВаш треугольник: " + triangle2);
        Console.WriteLine("Существует: " + triangle2.Existance());
        
        Console.WriteLine("Площадь треугольника #1 = " + triangle1.Area());
        Console.WriteLine("Площадь треугольника #2 = " + triangle1.Area());
        
        Console.WriteLine("S треугольника #1 больше S треугольника #2: ");
        Console.WriteLine($"triangle1 > triangle2 {triangle1 > triangle2}");
        Console.WriteLine("S треугольника #2 больше S треугольника #1: ");
        Console.WriteLine($"triangle1 < triangle2 {triangle1 < triangle2}");
    }
}
