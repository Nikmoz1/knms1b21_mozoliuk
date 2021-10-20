using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4

{
    class peoem
    {
        public static int count_of_objects = 0;
        public static int ram_filter;
        private string processor;
        private int frequency;
        private int ram;
        private string type;
        public peoem(string _processor, int _frequency, int _ram, string _type)
        {
            processor = _processor;
            frequency = _frequency;
            ram = _ram;
            type = _type;
            count_of_objects++;
        }
        public string Processor
        {
            get { return processor; }
            set { processor = Regex.Replace(value, @"[^A-zА-я]+", String.Empty); }
        }
        public int Frequency
        {
            get { return frequency; }
            set
            {
                if (value > 0)
                    frequency = value;
                else
                    Console.WriteLine("Частота не може бути від'ємною!");
            }
        }
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value > 0)
                    frequency = value;
                else
                    Console.WriteLine("Пам'ять не може бути від'ємною!");
            }
        }
        public string Type
        {
            get { return type; }
            set { type = Regex.Replace(value, @"[^A-zА-я]+", String.Empty); }
        }

        public void display_info()
        {
            Console.WriteLine($"Процесор: {processor}\nЧастота: {frequency}\nRam: {ram}\nТип: {type}");
        }
        public bool filter()
        {
            if (ram > peoem.ram_filter)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            peoem[] Peoem = new peoem[10];
            Peoem[0] = new peoem("1", 321, 532, "qwe");
            Peoem[0].display_info();
            Peoem[1] = new peoem("2", 213, 12, "qwd");
            Peoem[1].display_info();
            Peoem[2] = new peoem("3", 213, 122, "qwe");
            Peoem[2].display_info();
            Peoem[3] = new peoem("4", 56, 321, "sad");
            Peoem[3].display_info();
            Peoem[4] = new peoem("5", 12,32, "asd");
            Peoem[4].display_info();
            Peoem[5] = new peoem("6", 432, 54, "asd");
            Peoem[5].display_info();
            Peoem[6] = new peoem("7", 123, 435, "dsa");
            Peoem[6].display_info();
            Peoem[7] = new peoem("8", 12, 234, "ad");
            Peoem[7].display_info();
            Peoem[8] = new peoem("9", 123, 45, "sd");
            Peoem[8].display_info();
            Peoem[9] = new peoem("10", 123, 412, "sad");
            Peoem[9].display_info();
            Console.WriteLine("Кiлькiсть об'єктiв в класi: " + peoem.count_of_objects);
            Console.WriteLine("\nВведiть мiнiмальне значення RAM для пошуку за критерiєм: ");
            peoem.ram_filter = int.Parse(Console.ReadLine());
            Console.WriteLine("Об'єкти, RAM яких бiльшe, нiж " + peoem.ram_filter + ": \n");
            for (int i = 0; i < peoem.count_of_objects; i++)
                if (Peoem[i].filter())
                    Peoem[i].display_info();
        }
    }
}
