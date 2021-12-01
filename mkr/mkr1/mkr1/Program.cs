
using System.Collections.Specialized;

Console.WriteLine("Last 10 records");
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Vvedit chislo: ");
    string uservvod = Console.ReadLine();
    int chyslo = Convert.ToInt32(uservvod);
    array[i] = chyslo;
    var str = string.Join(" ", array);
    Console.WriteLine(str);
}

