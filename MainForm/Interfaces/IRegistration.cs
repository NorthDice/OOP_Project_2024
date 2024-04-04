using MainForm.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Interfaces
{
    internal interface IRegistration
    {
        public bool Registration(string login, string password,string name,string surname, UserList users);
    }
}
