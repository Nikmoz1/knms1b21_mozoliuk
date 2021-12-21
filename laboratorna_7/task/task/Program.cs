using System;

namespace lab0107
{
    class Company
    {
        public string companyName { get; set; }

        public Company(string companyName)
        {
            this.companyName = companyName;
        }
    }

    class Tariff : Company
    {
        public string tariffName { get; set; }
        public int quantityConsumer { get; set; }

        public Tariff(string companyName, string tariffName, int quantityConsumer) : base(companyName)
        {
            this.tariffName = tariffName;
            this.quantityConsumer = quantityConsumer;

            try
            {
                if (string.IsNullOrWhiteSpace(tariffName))
                {
                    throw new NazvaException($"ПОМИЛКА: Неможливо створити тариф – не вказано назву");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual double CostConversation()
        {
            try
            {
                Console.Write("Введiть кiлькiсть секунд: ");
                int quantitySeconds = Convert.ToInt32(Console.ReadLine());

                if (quantitySeconds < 0)
                {
                    throw new KilkistSekundException($"ПОМИЛКА: Неможливо розрахувати вартiсть розмови – вказана негативна кiлькiсть секунд: {quantitySeconds}");
                }
                else
                {
                    double minute = Convert.ToInt32(Math.Round(quantitySeconds * 0.0166666667, 1));
                    if (100 < minute)
                    {
                        Console.WriteLine($"Всього хвилин було потрачено {minute} хв - а це бiльше за умови тарифу, тому кожна наступна хвилина буде становити по 0,85 грн!");
                        Console.WriteLine($"Ви повиннi доплатити: {(minute - 100) * 0.85} грн");
                    }
                    else
                    {
                        Console.WriteLine($"Введена кiлькiсть секунд не перевищує лiмiт тарифу, тому вартiсть залишається 50 грн на 4 тижнi (100 хв) ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public virtual string Display()
        {
            if (!string.IsNullOrWhiteSpace(tariffName))
            {
                Console.WriteLine($"Назва компанiї: {companyName}, Назва тарифа: {tariffName}, Кiлькiсть абонентiв: {quantityConsumer}");
                CostConversation();
            }
            return "";
        }
    }

    class TariffSecond : Tariff
    {
        public double costSecond { get; set; }

        public TariffSecond(string companyName, string tariffName, int quantityConsumer, double costSecond) : base(companyName, tariffName, quantityConsumer)
        {
            this.costSecond = costSecond;
        }

        public override double CostConversation()
        {
            try
            {
                Console.Write("Введiть кiлькiсть секунд: ");
                int quantitySeconds = Convert.ToInt32(Console.ReadLine());

                if (quantitySeconds < 0)
                {
                    throw new KilkistSekundException($"ПОМИЛКА: Неможливо розрахувати вартiсть розмови – вказана негативна кiлькiсть секунд: {quantitySeconds}");
                }
                else
                {
                    Console.WriteLine($"Вартiсть розмови: {quantitySeconds * costSecond} грн");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public override string Display()
        {
            if (!string.IsNullOrWhiteSpace(tariffName))
            {
                Console.WriteLine($"Назва компанiї: {companyName}, Назва тарифа: {tariffName}, Кiлькiсть абонентiв: {quantityConsumer}");
                Console.WriteLine($"Вартiсть секунди розмови: {costSecond}");
                CostConversation();
            }
            return "";
        }
    }

    class TariffMinute : Tariff
    {
        public double costMinute { get; set; }

        public TariffMinute(string companyName, string tariffName, int quantityConsumer, double costMinute) : base(companyName, tariffName, quantityConsumer)
        {
            this.costMinute = costMinute;
        }

        public override double CostConversation()
        {
            try
            {
                Console.Write("Введiть кiлькiсть секунд: ");
                int quantitySeconds = Convert.ToInt32(Console.ReadLine());
                double minute = Convert.ToInt32(Math.Round(quantitySeconds * 0.0166666667, 1));

                if (quantitySeconds < 0)
                {
                    throw new KilkistSekundException($"ПОМИЛКА: Неможливо розрахувати вартiсть розмови – вказана негативна кiлькiсть секунд: {quantitySeconds}");
                }
                else
                {
                    Console.WriteLine($"Вартiсть розмови: {minute * costMinute} грн");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public override string Display()
        {
            if (!string.IsNullOrWhiteSpace(tariffName))
            {
                Console.WriteLine($"Назва компанiї: {companyName}, Назва тарифа: {tariffName}, Кiлькiсть абонентiв: {quantityConsumer}");
                Console.WriteLine($"Вартiсть хвилини розмови: {costMinute}");
                CostConversation();
            }
            return "";
        }
    }

    class Consumer : Tariff
    {
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public double balance { get; set; }

        public Consumer(string companyName, string tariffName, int quantityConsumer, string fullName, string phoneNumber, double balance) : base(companyName, tariffName, quantityConsumer)
        {
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.balance = balance;
        }

        public override string Display()
        {
            if (!string.IsNullOrWhiteSpace(tariffName))
            {
                Console.WriteLine($"Компанiя {companyName} мiстить такого абонента: {fullName}, що має такий номер телефону: {phoneNumber} i залишок на його (її) рахунку становить: {balance} грн, використовує вiн (вона) тариф: {tariffName}");
            }
            return "";
        }
    }

    class KilkistSekundException : Exception
    {
        public KilkistSekundException(string aMessage) : base(aMessage) { }
    }

    class NazvaException : Exception
    {
        public NazvaException(string aMessage) : base(aMessage) { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Tariff[] t = {
                new Tariff ("PhonePLUS", "Базовий", 2500),
                new TariffSecond ("PhonePLUS", "1 Секунда", 500, 0.006),
                new TariffMinute ("PhonePLUS", "1 хвилина", 1300, 0.56),
                new Consumer ("PhonePLUS", "Базовий", 2500, "Романовський Д. М.", "+380936479810", 100),
                new Consumer ("PhonePLUS", "1 хвилина", 1300, "Кульченко О. Л.", "+380676780316", 8.89),
            };

            foreach (Tariff s in t)
            {
                Console.WriteLine(s.Display());
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}