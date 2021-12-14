delegate void Fun(double a, double b, int n);
class Trap
{
    private bool Check(double a, double b, int n)
    {
        if (a >= b)
        {
            return false;
        }
        return true;
    }
    public void Input(int n, Fun f)
    {
        for (int a = 2; a < n; a += a)
        {
            for (int b = 2; b < n; b++)
            {
                for (int c = 2; c < n; c += c)
                {
                    if (Check(a, b, c) == true)
                    {
                        f(a, b, c);
                    }
                }
            }
        }
    }
    public void Calc(double a, double b, int n)
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
}
class TestMain
{
    public static void Calc(double a, double b, int n)
    {
        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
        Trap x = new Trap();
        x.Calc(a, b, n);
    }
    public static void Main()
    {
        Trap x = new Trap();
        Fun fun = new Fun(TestMain.Calc);
        x.Input(7, fun);
    }
}
