
public class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle()
    {
        Console.Write("Введите сторону A: ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону B: ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону C: ");
        sideC = double.Parse(Console.ReadLine());
    }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public bool Existance()
    {
        return sideA + sideB > sideC &&
               sideA + sideC > sideB &&
               sideB + sideC > sideC;
    }
    
    public double Area()
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }
    
    public double Perimeter()
    {
        return sideA + sideB + sideC;
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
}
