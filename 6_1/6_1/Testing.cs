public class Triangle
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle()
    {
        Console.Write("\nВведите сторону A: ");
        //double sideA;
        bool f = false;
        string input = Console.ReadLine();
        while (!f)
        {
            f = double.TryParse(input, out _sideA);
            if (!f || _sideA <= 0)
            {
                Console.WriteLine("Ошибка! Повторите ввод");
                Console.Write("\nВведите сторону A: ");
                input = Console.ReadLine();
            }
        }
        
        Console.Write("Введите сторону B: ");
        //double sideB;
        f = false;
        string input2 = Console.ReadLine();
        while (!f)
        {
            f = double.TryParse(input2, out _sideB);
            if (!f || _sideB <= 0)
            {
                Console.WriteLine("Ошибка! Повторите ввод");
                Console.Write("\nВведите сторону B: ");
                input2 = Console.ReadLine();
            }
        }
        
        Console.Write("Введите сторону C: ");
        //double sideC;
        f = false;
        string input3 = Console.ReadLine();
        while (!f)
        {
            f = double.TryParse(input3, out _sideC);
            if (!f || _sideC <= 0)
            {
                Console.WriteLine("Ошибка! Повторите ввод");
                Console.Write("\nВведите сторону C: ");
                input3 = Console.ReadLine();
            }
        }
    }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        this._sideA = sideA;
        this._sideB = sideB;
        this._sideC = sideC;
    }

    public bool Existance()
    {
        return _sideA + _sideB > _sideC &&
               _sideA + _sideC > _sideB &&
               _sideB + _sideC > _sideC;
    }
    
    public double Area()
    {
        double p = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
    
    public double Perimeter()
    {
        return _sideA + _sideB + _sideC;
    }
    
    // Бинарные операции (сравнение площадей)
    public static bool operator >(Triangle triangle1, Triangle triangle2)
    {
        return triangle1.Area() > triangle2.Area();
    }

    public static bool operator <(Triangle triangle1, Triangle triangle2)
    {
        return triangle1.Area() < triangle2.Area();
    }

    public override string ToString()
    {
        return $"A = {_sideA}, B = {_sideB}, C = {_sideC}";
    }
}
