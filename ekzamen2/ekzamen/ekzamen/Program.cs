using System;

namespace exsam_oop2
{
    interface IDevice
    {

        string Type();
        int Price();
        string show();
        static string? function { get; set; }
        static string? power { get; set; }


    }
    interface IoTDevice : IDevice
    {
        int time { get; set; }
        int show_time();
    }
    class KitchenDevice : IDevice
    {
        public KitchenDevice(string type, int price, string maker, string power, string function)
        {
            this.type = type;
            this.price = price;
            this.maker = maker;
            this.function = function;
            this.power = power;
        }
        public string type;
        public int price;
        public string maker;
        public string function { get; set; }
        public string power { get; set; }
        public string Type()
        {
            return type;
        }
        public int Price()
        {
            return price;
        }
        public string show()
        {
            return maker;
        }
    }
    class SmartTracker : IoTDevice
    {
        public SmartTracker(string type, int price, string maker, int time)
        {
            this.type = type;
            this.price = price;
            this.maker = maker;
            this.time = time;
        }
        public int time { get; set; }
        public int function { get; set; }
        public int power { get; set; }
        public string type;
        public int price;
        private string maker;
        public string Type()
        {
            return type;
        }
        public int Price()
        {
            return price;
        }
        public string show()
        {
            return maker;
        }
        public int show_time()
        {
            return time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кухоннi прилади:");
            void findByMakerDevices(string maker, KitchenDevice[] devices)
            {
                foreach (KitchenDevice str in devices)
                {

                    if (str.show() != maker)
                    {
                        Console.WriteLine($"\nНазва: {str.Type()}\nЦiна: {str.Price()}грн\nВиробник: {str.show()}\nЖивлення: {str.power}\nДля чого використовується: {str.function}");
                    }
                }
            }
            void findByMakerTrackers(string maker, SmartTracker[] devices)
            {
                Console.WriteLine("\nСмарт трекери:");
                foreach (SmartTracker str in devices)
                {

                    if (str.show() != maker)
                    {
                        Console.WriteLine($"\nНазва: {str.Type()}\nЦiна: {str.Price()}грн\nВиробник: {str.show()}\nПрацює без живлення: {str.time} годин");
                    }
                }
            }
            KitchenDevice[] kitchen_devices =
            {
                new KitchenDevice("Плита кухонна", 9999, "Китай", "Мережа", "Для приготування їжі"),
                new KitchenDevice("Холодильник", 15000, "Португалія", "Мережа", "Для зберігання їжi"),
                new KitchenDevice("Кавоварка", 150000, "Японія", "", "Для приготування кави")
            };
            SmartTracker[] trackers =
            {
                new SmartTracker("Смарт годинник Apple Watch", 21999, "Apple", 30),
                new SmartTracker("Смартфон Apple IPhone;", 39999, "Apple", 20),
                new SmartTracker("Ноутбук MacBook", 79999, "Apple", 10)
            };
            findByMakerDevices("USA", kitchen_devices);
            findByMakerTrackers("Smart", trackers);

        }
    }
}