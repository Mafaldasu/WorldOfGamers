using System;
using System.Collections.Generic;
using System.Text;

namespace WorldOfGamers
{
    class RegisteredUser:IUser
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
    }
}
