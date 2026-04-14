using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Тест конструкторов - ");

        Triangle t1 = new Triangle();
        Console.WriteLine("По умолчанию: " + t1);

        Triangle t2 = new Triangle(3, 4, 5);
        Console.WriteLine("С параметрами: " + t2);

        Triangle t3 = new Triangle(t2);
        Console.WriteLine("Копия: " + t3);

        Console.WriteLine("\nПроверка метода Exists - ");
        Console.WriteLine($"{t2} -> {t2.Exists()}");

        Console.WriteLine("\nВвод пользователя - ");

        try
        {
            Console.Write("Введите сторону A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangle userTriangle1 = new Triangle(a, b, c);

            Console.WriteLine("Ваш треугольник: " + userTriangle1);
            Console.WriteLine("Существует: " + userTriangle1.Exists());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено не число!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        
        // Для 3 лабы
        Triangle tr1 = new Triangle(3, 4, 5);
        Triangle tr2 = new Triangle(6, 8, 10);

        Console.WriteLine("\nТреугольник 1: " + tr1);
        Console.WriteLine("Площадь: " + tr1.GetArea());

        Console.WriteLine("\nТреугольник 2: " + tr2);
        Console.WriteLine("Площадь: " + tr2.GetArea());
        
        double perimeter = (double)tr1;
        Console.WriteLine($"\nПериметр t1: {perimeter}");
        
        if (tr1)
            Console.WriteLine("t1 существует");
        else
            Console.WriteLine("t1 не существует");
        
        Console.WriteLine("\nСравнение площадей:");
        Console.WriteLine($"t1 > t2: {tr1 > tr2}");
        Console.WriteLine($"t1 < t2: {tr1 < tr2}");
    }
}