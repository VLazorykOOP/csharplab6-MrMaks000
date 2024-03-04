using System;

namespace Lab6CSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lab 6");
            Console.WriteLine("\nTask 1\n");
            Task1();
            Console.WriteLine("\nTask 2\n");
            Task2();
            Console.WriteLine("\nTask 3\n");
            Task3();
        }

        static void Task1()
        {
            Console.WriteLine("Створення об'єктiв та виклик конструкторiв:");
            Place place = new("Природний заповiдник", 1000);
            Console.WriteLine();

            Region region = new("Київська область", 28131, "Україна", 1765000);
            Console.WriteLine();

            City city = new("Київ", 847, "Україна", 2956000, "Вiталiй Кличко");
            Console.WriteLine();

            Megalopolis megalopolis = new("Токiо", 2191, "Японiя", 37900000, "Юсеi Тосiмiцу", 23);
            Console.WriteLine();

            Console.WriteLine("Демонстрацiя виклику методу Show() для кожного об'єкту:");
            Console.WriteLine("iнформацiя про мiсце:");
            place.Show();
            Console.WriteLine();

            Console.WriteLine("iнформацiя про область:");
            region.Show();
            Console.WriteLine();

            Console.WriteLine("iнформацiя про мiсто:");
            city.Show();
            Console.WriteLine();

            Console.WriteLine("iнформацiя про мегаполiс:");
            megalopolis.Show();
        }

        static void Task2()
        {
            // Приклад створення телефонного довідника з декількох записів
            IPhoneDirectory[] phoneDirectory = new IPhoneDirectory[]
            {
            new Person("Iванов", "Київ", "+380123456789"),
            new Organization("Компанiя", "Львiв", "+380987654321", "+380123456789", "Петров"),
            new Friend("Петров", "Одеса", "+380111223344", new DateTime(1990, 5, 15))
            };

            // Виведення інформації про всі записи в довіднику
            foreach (var entry in phoneDirectory)
            {
                entry.PrintInfo();
                Console.WriteLine();
            }

            // Пошук за прізвищем у телефонному довіднику
            string searchCriteria = "Петров";
            Console.WriteLine($"Результати пошуку за прiзвищем '{searchCriteria}':");
            foreach (var entry in phoneDirectory)
            {
                if (entry.MatchesSearchCriteria(searchCriteria))
                {
                    entry.PrintInfo();
                    Console.WriteLine();
                }
            }
        }

        static void Task3()
        {
            // Приклад використання оператора foreach
            Megalopolis megapolis = new Megalopolis("Мегаполiс", 1000, "Країна", 1000000, "Мер", 10);

            // Виводимо інформацію про мегаполіс
            Console.WriteLine($"Iнформацiя про '{megapolis.Name}':");
            Console.WriteLine($"Країна: {megapolis.Country}");
            Console.WriteLine($"Населення: {megapolis.Population}");
            Console.WriteLine($"Мер: {megapolis.Mayor}");
            Console.WriteLine($"Кiлькiсть районiв: {megapolis.NumberOfDistricts}");

            // Використання foreach для виводу мегаполісу
            Console.WriteLine("\nВикористання foreach для виводу мегаполiсу:");
            foreach (Place place in megapolis)
            {
                place.Show();
            }
        }
    }

    

    internal interface ILocation
    {
        string Name { get; }
        double Area { get; }
    }

    internal interface IPopulation
    {
        int Population { get; }
    }

    internal interface IGovernment
    {
        string Mayor { get; }
    }

    internal interface ICountry
    {
        string Country { get; }
    }
}