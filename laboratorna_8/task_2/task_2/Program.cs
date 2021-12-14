/*string e = Console.ReadLine();
int eps = Convert.ToInt32(e);
for (int i=1; i < e; i++)
{
   double x = (i - 0.1) / (Math.Pow(i, 3) + Math.Abs(Math.Tan(2 * i)));
    Console.WriteLine(i);
    Console.WriteLine(x);
}*/
using System;
public class Program
{

	static public void Main(String[] args)
	{
		double eps = 0.1;
		double x, sum;
		double n;
		x = 1;
		n = 1;
		using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"A:\C#Projects\knms1b21_mozoliuk\laboratorna_8\task_2\file.txt", true))
		//using (var file = new StreamWriter("A:\\C#Projects\\knms1b21_mozoliuk\\laboratorna_8\task_2"))
			/*while (Math.Abs(x) > eps)
		{
			n = n + 1.0;
			x = (n - 0.1) / (Math.Pow(n, 3) + Math.Abs(Math.Tan(2 * n)));
			Console.WriteLine(x);

		}*/
		for(int i=1; Math.Abs(x)>eps; i++)
        {
			x = (i - 0.1) / (Math.Pow(i, 3) + Math.Abs(Math.Tan(2 * i)));
			Console.WriteLine(x);
			file.WriteLine(x);
		}
		List<string> lines = File.ReadAllLines(@"A:\C#Projects\knms1b21_mozoliuk\laboratorna_8\task_2\file.txt").ToList();
		File.WriteAllLines(@"A:\C#Projects\knms1b21_mozoliuk\laboratorna_8\task_2\file.txt", lines.GetRange(0, lines.Count - 1).ToArray());
	}
}