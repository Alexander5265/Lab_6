using System;

class Program
{
    static Triangle InputTriangle(string name)
    {
        Console.WriteLine("Введите стороны:");
        
        double a, b, c;
        
        Console.Write("A: ");
        while (!double.TryParse(Console.ReadLine(), out a))
            Console.Write("Error! Please enter a valid number!: ");
        
        Console.Write("B: ");
        while (!double.TryParse(Console.ReadLine(), out b))
            Console.Write("Error! Please enter a valid number!: ");
        
        Console.Write("C: ");
        while (!double.TryParse(Console.ReadLine(), out c))
            Console.Write("Error! Please enter a valid number!: ");
        
        return new Triangle(a, b, c);
    }
    
    static void Main()
    {
        try
        {
            Triangle triangle1 = InputTriangle("Enter triangle #1:");
            Triangle triangle2 = InputTriangle("Enter triangle #2:");

            Console.WriteLine("\n RESULTS: ");

            Console.WriteLine($"\nt1: {triangle1}");
            Console.WriteLine($"Площадь: {triangle1.GetArea()}");

            Console.WriteLine($"\nt2: {triangle2}");
            Console.WriteLine($"Площадь: {triangle2.GetArea()}");

            Console.WriteLine($"\nПериметр #1: {(double)triangle1}");
            Console.WriteLine($"\nПериметр #2: {(double)triangle2}");

            Console.WriteLine($"\n#1 Существует: {(triangle1 ? "Yes" : "No")}");
            Console.WriteLine($"\n#2 Существует: {(triangle2 ? "Yes" : "No")}");

            Console.WriteLine("\nСравнение площадей: ");

            if (triangle1 > triangle2)
                Console.WriteLine("ТРеугольник #1 > #2");
            else if (triangle1 < triangle2)
                Console.WriteLine("Треугольник #1 < #2");
            else
                Console.WriteLine("Площади равны!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
