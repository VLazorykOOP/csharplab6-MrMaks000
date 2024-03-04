using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class City : Region, IGovernment
    {
        public string Mayor { get; private set; }

        public City(string name, double area, string country, int population, string mayor) : base(name, area, country, population)
        {
            Mayor = mayor;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Мер: {Mayor}");
        }
    }
}
