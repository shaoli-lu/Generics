using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class User
    {
        public User()
        {
        }

        //public string Name;
        //public string Name { get; set; }
        string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value; //.ToUpper();
            }
        }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;

            }
        }

        //hash table override
        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }

        public string Output(int times)
        {
            string msg = "";
            for (int i = 0; i < times; i++)
            {
                //Console.WriteLine(FirstName);
                //Console.WriteLine(LastName);
                msg += FirstName + " " + LastName + "\n";
            }
            return msg;

        }

        public override bool Equals(object obj)
        {
            if (FullName == ((User)obj).FullName)
            {
                return true;
            }
            return false;
        }

        public static int Find(List<User> users, User search)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(search))
                {
                    return i;

                }
            }

            return -1;
        }

        public static User GetUser(List<User> users, User search)
        {
            foreach (var user in users)
            {
                if(user.Equals(search))
                {
                    return user;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return FullName;
        }
    }

}
