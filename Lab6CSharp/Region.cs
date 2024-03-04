using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class Region : Place, ICountry, IPopulation
    {
        public string Country { get; private set; }
        public int Population { get; private set; }

        public Region(string name, double area, string country, int population) : base(name, area)
        {
            Country = country;
            Population = population;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Населення: {Population} осiб");
        }
    }
}
