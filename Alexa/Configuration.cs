using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexa
{
    public class Configuration
    {
        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }
        public Configuration() { }
        public Configuration(string greeting,string owner)
        {
            this.GreetingMessage = greeting;
            this.OwnerName = owner;
        }
    }
}
