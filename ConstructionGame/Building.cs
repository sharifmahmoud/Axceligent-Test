using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGame
{
    public class BuldingPart
    {
        public List<string> Parts = new List<String>();

        public string Describe()
        {
            return string.Join(", ", Parts);
        }
    }
    public class Building
    {
        private BuldingPart part;

        public Building()
        {
            part = new BuldingPart();
        }

        public Building AddKitchen()
        {
            part.Parts.Add("Kitchen");
            return this;
        }

        public Building AddBedroom(string title = "")
        {
            if (string.IsNullOrEmpty(title))
                part.Parts.Add("Bedroom");
            else
                part.Parts.Add($"{title} room");
            return this;
        }

        public Building AddBalcony()
        {
            part.Parts.Add("Balcony");
            return this;
        }
        public BuldingPart Build()
        {
            return part;
        }

    }
}
