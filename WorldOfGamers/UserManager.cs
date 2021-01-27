using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfGamers
{
    class UserManager
    {
        public void Register(NewUser newUser)
        {
            Console.WriteLine(newUser.NickName+" is succesfully registered.");
        }

        public void Delete(IUser user)
        {
            Console.WriteLine(user.NickName + " is succesfully deleted.");

        }
        public void Upgrade(IUser user)
        {
            Console.WriteLine(user.NickName + " is succesfully upgraded.");

        }

    }
}
