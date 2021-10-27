
class Time
{
    int hours { get; set; }
    int minutes { get; set; }
    int seconds { get; set; }
    public Time(int h, int m, int s)
    {
        this.hours = h;
        this.minutes = m;
        this.seconds = s;
    }
    public void Math()
    {
        Console.WriteLine($"Введений час – {hours}:{minutes}:{seconds}");
        double rez = (hours * 60) + minutes + (seconds / 60);
        Console.WriteLine($"Всього хвилин в зазначеному часу - {rez}");
        Console.WriteLine($"Пiсля зменшення часу - {rez - 10}");
    }
}
class Timetable : Time
{
    string lastname { get; set; }
    string oper { get; set; }
    TimeSpan now_time = DateTime.Now.TimeOfDay;
    public Timetable(int h, int m, int s) : base(h, m, s) { }
    public void Abonent(TimeSpan user_time)
    {
        var timeFrom1 = new TimeSpan(00, 00, 0);
        var timeTo1 = new TimeSpan(8, 00, 0);
        var timeFrom2 = new TimeSpan(08, 00, 0);
        var timeTo2 = new TimeSpan(16, 00, 0); 
        var timeFrom3 = new TimeSpan(16, 00, 0);
        var timeTo3 = new TimeSpan(11, 59, 59);
        if (user_time > timeFrom1 && user_time < timeTo1)
        {
            lastname = "Продоляк";
            oper = "Kyivstar";
            Console.WriteLine($"Прiзвище - {lastname} оператор {oper} час '{now_time}' ");
        }
        else if (user_time >timeFrom2 && user_time < timeTo2)
        {
            lastname = "Глушко";
            oper = "MTC";
            Console.WriteLine($"Прiзвище - {lastname} оператор {oper} час '{now_time}' ");
        }
        else
        {
            lastname = "Гуменюк";
            oper = "Life";
            Console.WriteLine($"Прiзвище - {lastname} оператор {oper} час '{now_time}' ");
        }
    }
    public void Pilgi(TimeSpan time)
    {
        if (time > new TimeSpan(0, 0, 0) && time < new TimeSpan(8,0,0))
        {
            Console.WriteLine("Час пiльговий");
        }
        else
        {
            Console.WriteLine("Час не пiльговий");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {


        Console.Write("Введiть години: ");
        int h = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введiть хвилини: ");
        int m = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введiть секунди: ");
        int s = Convert.ToInt16(Console.ReadLine());
        Timetable tm = new Timetable(h, m, s);
        tm.Math();
        TimeSpan user_time = new TimeSpan(h, m, s);
        tm.Pilgi(user_time);
        string x = $"{h}:{m}";
        Console.Write("Оператоp в зазначений час: ");
        tm.Abonent(user_time);
    }
}