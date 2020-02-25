using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionGame
{
    public class Room
    {
        public string Title { get; set; }
        public Room(string title) { this.Title = title; }
    }
    public class Building
    {
        private static List<Room> BuldingParts = null;
        public Building()
        {
            BuldingParts = new List<Room>();
        }
        public Building Build()
        {
            return this;
        }

        public string Describe()
        {
            return string.Join(", ", BuldingParts.Select(a => a.Title));
        }


        public Building AddKitchen()
        {
            BuldingParts.Add(new Room("Kitchen"));
            return this;
        }

        public Building AddBedroom(string title = "")
        {
            if (string.IsNullOrEmpty(title))
                BuldingParts.Add(new Room("Bedroom"));
            else
                BuldingParts.Add(new Room($"{title} room"));
            return this;
        }

        public Building AddBalcony()
        {
            BuldingParts.Add(new Room("Balcony"));
            return this;
        }


    }
}
