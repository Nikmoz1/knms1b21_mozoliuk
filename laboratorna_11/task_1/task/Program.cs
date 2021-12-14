class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок: ");
        string s = Console.ReadLine();
        Console.Write("Введiть задану позицiю рядка: ");
        int p = Convert.ToInt16(Console.ReadLine());
        char[] str = s.ToCharArray();
        int n = str.Length;
        if ((p < 1) || (p > n))
        {
            Console.WriteLine("Такої позицiї не iснує!");
        }
        else
        {
            for (int i = p; i < n; i++)
            {
                if (s[i] == '1')
                {
                    str[i] = '0';
                }
                else if (s[i] == '0')
                {
                    str[i] = '1';
                }
            }
            Console.Write("Виконання: ");
            Console.WriteLine(str);
        }
    }
}

