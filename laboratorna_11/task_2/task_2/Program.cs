class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть день: ");
        int day = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введiть мiсяць: ");
        int month = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введiть рiк: ");
        int year = Convert.ToInt16(Console.ReadLine());
        DateTime date = new DateTime(year, month, day);
        Console.WriteLine($"Поточна дата {DateTime.Today.ToShortDateString()}");
        TimeSpan ts = date - DateTime.Today;
        if (ts.Days > 0)
        {
            Console.WriteLine($"Залишилося {ts.Days} днiв до заданої дати");
        }
        else if (ts.Days < 0)
        {
            Console.WriteLine($"Минуло {-ts.Days} днiв вiд заданої дати");
        }
        else
        {
            Console.WriteLine($"Цей день вже настав!");
        }
    }
}
