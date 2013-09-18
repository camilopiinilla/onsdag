using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil bmw = new Bil("BMW", "118i", 2006);

            Console.WriteLine(bmw.Brand);
            Console.WriteLine(bmw.Model);
            Console.WriteLine(bmw.Year);
        }
        public class Bil
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Bil(string brand, string model, int year)
            {
                Brand = brand;
                Model = model;
                Year = year;
            }
        }
    }
    
}
