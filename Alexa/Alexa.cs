using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alexa
{
    public class Alexa
    {
        public static Configuration Config = new Configuration("hello, i am {OwnerName}", "Alexa");
        public string Talk()
        {
            return string.Format(Config.GreetingMessage.Replace("OwnerName", "0"), Config.OwnerName);
        }

        public void Configure(Action<Configuration> conf)
        {
            conf.Invoke(Config);
        }
    }
}
