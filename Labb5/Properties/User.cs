using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    public class User
    {
        private string userName;
        private string userEmail;
        public string UserName { get => userName; set => userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }

        public User(string UserName, string UserEmail)
        {
            this.userName = UserName;
            this.userEmail = UserEmail;
        }

    }
}
