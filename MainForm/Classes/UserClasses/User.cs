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

        public abstract bool SignUp(string login, string password);

    }
}
