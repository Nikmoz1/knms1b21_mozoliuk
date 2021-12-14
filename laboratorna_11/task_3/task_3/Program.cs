class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть 3 дати: ");
        string str2 = Console.ReadLine();
        DateTime dt1, dt2, dt3;
        string[] date2 = str2.Split(new char[] { ',' });
        DateTime[] dt = new DateTime[3] { Convert.ToDateTime(date2[0]), Convert.ToDateTime(date2[1]), Convert.ToDateTime(date2[2]) };
        Array.Sort(dt);
        if (dt[0].Day < dt[1].Day && dt[0].Day < dt[2].Day)
        {
            Console.WriteLine($"Дата з найменшим днем: {dt[0].ToShortDateString()}");
        }
        else if (dt[1].Day < dt[2].Day)
        {
            Console.WriteLine($"Дата з найменшим днем: {dt[1].ToShortDateString()}");
        }
        else
        {
            Console.WriteLine($"Дата з найменшим днем: {dt[2].ToShortDateString()}");
        }
        Console.WriteLine("\nВесняна дата:");
        for (int i = 0; i < dt.Length; i++)
        {
            if (dt[i].Month == 3 || dt[i].Month == 4 || dt[i].Month == 5)
            {
                Console.Write($"{dt[i].ToShortDateString()}, ");
            }
        }
        Console.WriteLine("\n");
        if (dt[0] < dt[1] && dt[0] < dt[2])
        {
            Console.WriteLine($"Найпiзнiша дата: {dt[0].ToShortDateString()}");
        }
        else if (dt[1] < dt[2])
        {
            Console.WriteLine($"Найпiзнiша дата: {dt[1].ToShortDateString()}");
        }
        else
        {
            Console.WriteLine($"Найпiзнiша дата: {dt[2].ToShortDateString()}");
        }
    }
}
