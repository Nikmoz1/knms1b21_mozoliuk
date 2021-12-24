using System;

namespace ConsoleApp6
{
    interface Lamp
    {
        static string type = "Лампа Illuminate";
        static string manufacturer = "Україна, Київ";
        static int power = 13;
        static int count = 3;
        void set_power(int new_power) { }
        void lamp_show_info() { }

    }
    interface Camera
    {
        static string type = "Cannon 5008";
        static string manufacturer = "Нiмечинна, Берлiн";
        static int sensitivity_min = 4;
        static int sensitivity_max = 135;
        void set_sensitivity() { }
        void camera_show_info() { }

    }
    class PhotoStudio : Lamp
    {
        public void lamp_show_info()
        {
            Console.WriteLine("Тип: " + Lamp.type + "\nВиробник: " + Lamp.manufacturer + "\nПотужнiсть у люменах: " + Lamp.power + "СИ\nКiлькiсть освiтлювальних елементiв: " + Lamp.count);
        }
        public void camera_show_info()
        {
            Console.WriteLine("Тип: " + Camera.type + "\nВиробник: " + Camera.manufacturer + "\nСвiтлочутливiсть: " + Camera.sensitivity_min + "lux - " + Camera.sensitivity_max + "lux");
        }
        public void show_info()
        {
            lamp_show_info();
            Console.WriteLine("\n");
            camera_show_info();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoStudio ps = new PhotoStudio();
            ps.show_info();
        }
    }
}