using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLgac
{
    internal class UserLogin
    {
        private string user;
        private string password;

        public UserLogin()
        {
        }

        public UserLogin(string user, string password)
        {
            this.user = user;
            this.password = password;
        }

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}
