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
        public void Display()
        {
            Console.WriteLine($"Процесор: {processor}\nЧастота: {frequency}\nRam: {ram}\nТип: {type}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            peoem Peoem = new peoem("Pentium-III", 233, 4, "C");
            Peoem.Display();
        }
    }
}
