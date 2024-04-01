using MainForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    internal class Guest : User, IRegistration
    {
        
        
        
        public bool ViewSessions(DateTime date)
        {
            throw new NotImplementedException();
        }

        public override bool SignUp(string login, string password)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Login and password cannot be null value!");
            }
            if (Regex.IsMatch(password, "^[a-zA-Z]{6,}$"))
            {
                return false;
            }
            if (Regex.IsMatch(login, "^[a-zA-Z]{5,}$"))
            {
                return false;
            }

            return true;
        }

        public bool Registration(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
