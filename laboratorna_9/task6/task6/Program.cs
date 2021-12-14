delegate void Action();
class AlarmClock
{
    public event Action Alarm;
    public void Start(int count)
    {
        for (int i = 0; i < count; ++i) { }
        if (Alarm != null)
        {
            Alarm();
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
    public static void WakeUp()
    {
        Console.WriteLine("Завантаження...");
    }
    public static void Main()
    {
        AlarmClock clk = new AlarmClock();
        clk.Alarm += new Action(WakeUp);
        Random rand = new Random();
        for (int i = 0; i < 6; i++)
        {
            clk.Start(199999999);
            clk.Calc(rand.Next(1, 10), rand.Next(2, 10), 3);
            Console.WriteLine();
        }
    }
}