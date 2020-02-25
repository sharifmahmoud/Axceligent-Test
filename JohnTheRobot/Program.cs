using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnTheRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined

            Console.ReadKey();
        }
    }
}
