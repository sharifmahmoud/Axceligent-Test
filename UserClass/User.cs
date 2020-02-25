using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClass
{
    public class User
    {
        public static List<string> Users = new List<string>();
        public void Add(string userName)
        {
            Users.Add(userName);
        }

        public int GetUsersCount()
        {
            return Users.Count;
        }
    }
}
