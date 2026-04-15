using System;

class Triangle
{
    private double a;
    private double b;
    private double c;
    
    public double A
    {
        get => a;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Сторона должна быть больше 0");
            a = value;
        }
    }

    public double B
    {
        get => b;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Сторона должна быть больше 0");
            b = value;
        }
    }

    public double C
    {
        get => c;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Сторона должна быть больше 0");
            c = value;
        }
    }
    
    public Triangle()
    {
        A = 1;
        B = 1;
        C = 1;
    }
    
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }
    
    public Triangle(Triangle other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        A = other.A;
        B = other.B;
        C = other.C;
    }
    
    public bool Exists()
    {
        return A + B > C &&
               A + C > B &&
               B + C > A;
    }
    
    public double GetArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
    
    public static explicit operator double(Triangle t)
    {
        return t.A + t.B + t.C;
    }
    
    public static implicit operator bool(Triangle t)
    {
        return t.Exists();
    }
    
    public static bool operator >(Triangle t1, Triangle t2)
    {
        return t1.GetArea() > t2.GetArea();
    }

    public static bool operator <(Triangle t1, Triangle t2)
    {
        return t1.GetArea() < t2.GetArea();
    }
    
    public override string ToString()
    {
        return $"A={A}, B={B}, C={C}";
    }
}
