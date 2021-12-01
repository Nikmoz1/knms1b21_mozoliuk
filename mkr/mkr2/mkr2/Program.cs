interface ICare
{
    string Car { get; }
    string Potuzhnist();
}

class Audi : ICare
{
    protected string marka { get; set; }

    protected string kyzov { get; set; }

    protected double rik { get; set; }
    public Audi(string marka, string kyzov, int rik)
    {
        this.marka = marka;
        this.kyzov = kyzov;
        this.rik = rik;
    }
    public string Car
    {
        get
        {
            return $"Марка: {marka}, Кузов: {kyzov}, Рік: {rik}";
        }
    }
    public string Potuzhnist()
    {
        switch (rik)
        {
            case 1998:
                Console.WriteLine("80 кiнських сил");
                break;
            case 2004:
                Console.WriteLine("130 кiнських сил");
                break;
            case 2007:
                Console.WriteLine("140 кiнських сил");
                break;

        }
        return $"{marka},{kyzov}, {rik}";

    }

}

class Program
{
    static void Main(string[] args)
    {
        Audi[] audi = {
             new Audi ("a6", "седан", 2004),
             new Audi ("a6", "седан", 2007),
             new Audi ("a6", "ceдан", 1998)
    };
        foreach (Audi str in audi)
        {

           Console.WriteLine($"{str.Potuzhnist()}");
        }
    }
}