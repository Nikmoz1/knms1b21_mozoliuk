public delegate void Fun(double a, double b, int n);
class TestMain
{
    private static void Calc(double a, double b, int n)
    {
        double h, x1, x2, res, sum = 0;
        h = (b - a) / n;
        for (int i = 0; i < n; i++)
        {
            x1 = a + i * h;
            x2 = a + (i + 1) * h;
            sum += (Math.Exp(Math.Sin(x1)) + Math.Exp(Math.Sin(x2)));
        }
        res = sum * h / 2;
        Console.WriteLine($"Вiдповiдь: {Math.Round(res, 3)}");
    }
    private static void Input(double a, double b, int n)
    {
        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
    }
    public static void Main()
    {
        Fun x = new Fun(Input);
        Fun y = new Fun(Calc);
        x += y;
        x(2.15, 4.99, 3);
        x += x;
        x(0.5, 3, 5);
        x -= y; x -= y; x -= y;
        x(1.25, 4.8, 5);
    }
}
