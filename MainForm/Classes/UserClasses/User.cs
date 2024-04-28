using MainForm.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    public abstract class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private Role _role ;

        public abstract bool SignUp(string login, string password,UserList users);

        public abstract string Login { get; set; }
        public abstract string Password { get; set; }
        public Role Role { get; set; }
        public string Name { get; set;}
        public string Surname { get;}
    }
}
