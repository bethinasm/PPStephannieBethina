using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPStephannieBethina
{
    internal class Store
    {
        public string Name { get; set; }
        public string Description { get; set; } // klær, elektronikk osv osv
        public int PriceLevel { get; set; } // 1 - billig, 2 - midt på treet, 3 - dyrt

        public Store(string name, string description, int pricelevel)
        {
            Name = name;
            Description = description;
            PriceLevel = pricelevel;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Store Name: {Name} \nStore Description: {Description} \nPrice Level: {PriceLevel}");
        }
    }
}
