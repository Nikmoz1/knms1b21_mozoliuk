using System;
using System.Collections.Generic;
using System.Text;

class TQuadrangle
{
    private int a;
    private int b;
    private int c;
    private int d;

    private int ang1;
    private int ang2;
    private int ang3;
    private int ang4;

    public int A
    {
        get
        {
            return a;
        }
        set
        {
            if (value <= 0) a = 1;
            else a = value;
        }
    }
    public int B
    {
        get
        {
            return b;
        }
        set
        {
            if (value <= 0) b = 1;
            else b = value;
        }
    }
    public int C
    {
        get
        {
            return c;
        }
        set
        {
            if (value <= 0) c = 1;
            else c = value;
        }
    }
    public int D
    {
        get
        {
            return d;
        }
        set
        {
            if (value <= 0) d = 1;
            else d = value;
        }
    }
    public int Ang1
    {
        get
        {
            return ang1;
        }
        set
        {
            if (value <= 0) ang1 = 1;
            else ang1 = value;
        }
    }
    public int Ang2
    {
        get
        {
            return ang2;
        }
        set
        {
            if (value <= 0) ang2 = 1;
            else ang2 = value;
        }
    }
    public int Ang3
    {
        get
        {
            return ang3;
        }
        set
        {
            if (value <= 0) ang3 = 1;
            else ang3 = value;
        }
    }
    public int Ang4
    {
        get
        {
            return ang4;
        }
        set
        {
            if (value <= 0) ang4 = 1;
            else ang4 = value;
        }
    }
    public TQuadrangle(int a, int b, int c, int d, int ang1, int ang2, int ang3, int ang4)
    {
        A = a;
        B = b;
        C = c;
        D = d;
        Ang1 = ang1;
        Ang2 = ang2;
        Ang3 = ang3;
        Ang4 = ang4;

    }
    public void show()
    {
        Console.WriteLine($"{a} {b} {c} {d} {ang1} {ang2} {ang3} {ang4}");
    }
    public int per()
    {
        return a + b + c + d;
    }
    public double sq()
    {
        double s = (per() - a) * (per() - b) * (per() - c) * (per() - d) - a * b * c * d * Math.Cos((ang1 + ang3) / 2);
        return Math.Sqrt(s);
    }
    public void defineQ()
    {
        if (a == b && b == c && c == d)
        {
            if (ang1 == ang3 && ang3 == 90) Console.WriteLine("kvadrat");
            else Console.WriteLine("romb");
        }
        else if (a == c && b == d)
        {
            if (ang1 == ang3 && ang1 == 90) Console.WriteLine("pryamkunik");
            else if (ang1 == ang3) Console.WriteLine("paralelogram");

        }
        else if (a == c || b == d) Console.WriteLine("trapeciya");
        else Console.WriteLine("norm 4 kutnik");
    }
}
class Program
{
    static void Main(string[] args)
    {
        TQuadrangle q = new TQuadrangle(1, 2, 3, 4, -5, 3, 3, 4);
        q.show();
        Console.WriteLine(q.per());
        Console.WriteLine(q.sq());
        q.defineQ();
    }
}


