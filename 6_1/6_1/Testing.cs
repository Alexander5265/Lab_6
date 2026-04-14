using System;

class Triangle
{
    private double a;
    private double b;
    private double c;

    // Свойства с проверкой
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

    // Конструктор по умолчанию
    public Triangle()
    {
        A = 1;
        B = 1;
        C = 1;
    }

    // Конструктор с параметрами
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    // Конструктор копирования
    public Triangle(Triangle other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        A = other.A;
        B = other.B;
        C = other.C;
    }

    // Метод проверки существования
    public bool Exists()
    {
        return A + B > C &&
               A + C > B &&
               B + C > A;
    }
    
    // УНАРНАЯ операция (площадь по формуле Герона)
    public double GetArea()
    {
        double p = (A + B + C) / 2; // полупериметр
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    // Приведение к double (периметр)
    public static explicit operator double(Triangle t)
    {
        return t.A + t.B + t.C;
    }

    // Приведение к bool (существует ли)
    public static implicit operator bool(Triangle t)
    {
        return t.Exists();
    }

    // Бинарные операции (сравнение площадей)
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