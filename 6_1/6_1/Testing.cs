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
        string input1 = Console.ReadLine();
        while (!f || _sideA <= 0)
        {
            f = double.TryParse(input1, out _sideA);
            if (!f || _sideA <= 0)
            {
                Console.WriteLine("Ошибка! Повторите ввод");
                Console.Write("\nВведите сторону A: ");
                input1 = Console.ReadLine();
            }
        }
        
        Console.Write("Введите сторону B: ");
        //double sideB;
        f = false;
        string input2 = Console.ReadLine();
        while (!f || _sideB <= 0)
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
        while (!f || _sideC <= 0)
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
               _sideB + _sideC > _sideA;
    }
    
    public double Area()
    {
        if (Existance())
        {
            double p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
        else
        {
            return 0;
        }

    }
    
    public static implicit operator double(Triangle t)
    {
       return t._sideA + t._sideB + t._sideC;
    }

    public static double operator -(Triangle t)
    {
        if (t.Existance())
        {
            double p = (t._sideA + t._sideB + t._sideC) / 2;
            return Math.Sqrt(p * (p - t._sideA) * (p - t._sideB) * (p - t._sideC));
        }
        else
        {
            return 0;
        }
        
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
