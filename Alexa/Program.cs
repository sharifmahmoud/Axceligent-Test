using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexa
{
    class Program
    {
        static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk());

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
            });

            Console.WriteLine(alexa.Talk());

            Console.WriteLine("press any key to exit");
            Console.ReadKey();

           
        }
    }
}
