using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    public interface IPhoneDirectory
    {
        void PrintInfo(); 
        bool MatchesSearchCriteria(string criteria); 
    }

    public class PhoneEntry : IPhoneDirectory
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public PhoneEntry(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Прiзвище: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Номер телефону: {PhoneNumber}");
        }

        public bool MatchesSearchCriteria(string criteria)
        {
            return Name != null && Name.Equals(criteria, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Person : PhoneEntry
    {
        public Person(string name, string address, string phoneNumber) : base(name, address, phoneNumber)
        {
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Iнформацiя про особу:");
            base.PrintInfo();
        }
    }

    public class Organization : PhoneEntry
    {
        public string Fax { get; set; }
        public string ContactPerson { get; set; }

        public Organization(string name, string address, string phoneNumber, string fax, string contactPerson)
            : base(name, address, phoneNumber)
        {
            Fax = fax;
            ContactPerson = contactPerson;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Iнформацiя про органiзацiю:");
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Адреса: {Address}");
            Console.WriteLine($"Номер телефону: {PhoneNumber}");
            Console.WriteLine($"Факс: {Fax}");
            Console.WriteLine($"Контактна особа: {ContactPerson}");
        }
    }

    // Клас для записів про друга
    public class Friend : PhoneEntry
    {
        public DateTime BirthDate { get; set; }

        public Friend(string name, string address, string phoneNumber, DateTime birthDate)
            : base(name, address, phoneNumber)
        {
            BirthDate = birthDate;
        }

        // Метод для виведення інформації про друга
        public override void PrintInfo()
        {
            Console.WriteLine("Iнформацiя про друга:");
            base.PrintInfo();
            Console.WriteLine($"Дата народження: {BirthDate:d}");
        }
    }

}
