using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            var normalHouse = myHouse.Build();

            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuaryHouse = myHouse.Build();

            Console.WriteLine(luxuaryHouse.Describe());

            Console.ReadKey();
        }
    }
}
