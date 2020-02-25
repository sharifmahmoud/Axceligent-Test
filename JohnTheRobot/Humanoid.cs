using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnTheRobot
{
    class Humanoid
    {
        public Skill skill { get; set; }
        public Humanoid() { }
        public Humanoid(Skill skill)
        {
            this.skill = skill;
        }

        public string ShowSkill()
        {
            if (skill != null)
                return skill._Skill;
            return "no skill is defined";

        }
    }
}
