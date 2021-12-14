public delegate double Fun(double a, double b, int n);
class TestMain
{
    private static double Calc(double a, double b, int n)
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
        return Math.Round(res, 3);
    }
    public static void Main()
    {
        Fun x = new Fun(Calc);
        Console.WriteLine($"Вiдповiдь: {x(2, 5, 3)}");
    }
}
