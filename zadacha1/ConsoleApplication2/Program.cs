using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");
            int[] array = new int[5];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(); 
            string s = string.Join(",", array);
            Console.WriteLine(s);
            int[] array2 = array.ReverseArray();
            string s2 = string.Join(",", array2);
            Console.WriteLine(s2 + "\n");
        }
    }
    public static class ArrayExtension
    {
        public static int[] ReverseArray(this int[] array)
        {
            int[] a = new int[5];
            array = array.Reverse().ToArray();
            return array;
        }
    }
}


