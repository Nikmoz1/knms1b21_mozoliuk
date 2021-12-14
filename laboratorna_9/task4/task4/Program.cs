public delegate void Fun(double a, double b, int n);
class Trapezium
{
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
    public void Input(double a, double b, int n)
    {
        Console.WriteLine($"Введенi значення: [{a}, {b}, {n}]");
    }
}
class TestMain
{
    static void Main()
    {
        Trapezium a = new Trapezium();
        Fun f = new Fun(a.Input);
        f += new Fun(a.Calc);
        f(2, 5, 5);
    }
}