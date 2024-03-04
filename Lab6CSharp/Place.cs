using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab6CSharp
{
    internal class Place : ILocation, IEquatable<Place>
    {
        public string Name { get; private set; }
        public double Area { get; private set; }     

        public Place(string name, double area)
        {
            Name = name;
            Area = area;            
        }

        public IEnumerator GetEnumerator()
        {
            yield return this;
        }

        public bool Equals(Place other)
        {
            // Перевіряємо, чи не є other нульовим і чи має він таку ж назву, як поточний об'єкт Place
            return other != null && Name.Equals(other.Name);
        }

        // Перевизначаємо метод Equals (перевантаження базового методу)
        public override bool Equals(object obj)
        {
            if (obj is Place other)
            {
                return Equals(other);
            }
            return false;
        }

        // Перевизначаємо метод GetHashCode() для коректної реалізації Equals
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public virtual void Show()
        {
            Console.WriteLine($"Мiсце: {Name}");
            Console.WriteLine($"Площа: {Area} км^2");
        }
    }
}
