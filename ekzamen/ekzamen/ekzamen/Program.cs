using System;

namespace ekzamen
{
    interface Lamp
    {
        static string type;
        static string manufacturer;
        static int power;
        static int count;
        void set_power(int new_power) { }
        void lamp_show_info() { }

    }
    interface Camera
    {
        static string type = "Cannon 3210";
        static string manufacturer = "Німечинна, Берлін";
        static int sensitivity_min = 3;
        static int sensitivity_max = 125;
        void set_sensitivity() { }
        void camera_show_info() { }

    }
    class PhotoStudio : Lamp
    {
        protected string type { get; set; }
        protected string manufacturer { get; set; }
        protected int power { get; set; }
        protected int count { get; set; }

        public PhotoStudio(string type, string manufacturer, int power, int count)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.power = power;
            this.count = count;
        }
        public void remake()
        {
           this.power = 100;

        }
        public string lamp_show_info()
        {
            return "Тип: " + type + "\nВиробник: " + manufacturer + "\nПотужнiсть у люменах: " + power + "СИ\nКiлькiсть освiтлювальних елементiв: " + count;
        }
        public string camera_show_info()
        {
            return "Тип: " + Camera.type + "\nВиробник: " + Camera.manufacturer + "\nСвiтлочутливiсть: " + Camera.sensitivity_min + "lux - " + Camera.sensitivity_max + "lux";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoStudio[] photostudio = {
                new PhotoStudio("Лампа Illuminate 3000", "Україна, Київ", 13, 3),
                new PhotoStudio("Лампа Блискавка 2000", "Україна, Кам-Под", 21, 1),
            };
            Console.WriteLine("Лампи:");
            foreach (PhotoStudio str in photostudio)
            {

                Console.WriteLine($"{str.lamp_show_info()}\n " );
            }
            Console.WriteLine("Лампа яку ви хочете змiнити (0 або 1): ");
            int lampa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(photostudio[lampa].remake);
            foreach (PhotoStudio str in photostudio)
            {

                Console.WriteLine($"{str.lamp_show_info()}\n ");
            }



        }

    }
}