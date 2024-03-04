using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp
{
    internal class Megalopolis : City
    {
        public int NumberOfDistricts { get; private set; }

        public Megalopolis(string name, double area, string country, int population, string mayor, int numberOfDistricts) : base(name, area, country, population, mayor)
        {
            NumberOfDistricts = numberOfDistricts;          
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Кiлькiсть районiв: {NumberOfDistricts}");
        }
    }
}
