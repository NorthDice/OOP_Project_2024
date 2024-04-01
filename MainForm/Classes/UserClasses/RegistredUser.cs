using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    internal class RegistredUser : User
    {
        private string _login;
        private string _password;
        private string _name;
        private string _surname;
        

        private string Login { get; set; }
        private string Password { get; set; }
        private string Name { get; set; }
        private string Surname { get; set; }
       
        

        public bool BuyTicket(DateTime date, TimeSpan time, Halls hallNumber, string filmName)
        {
            throw new NotImplementedException(); 
        }

        public bool ReturnTicket(DateTime date, TimeSpan time, Halls hallNumber, string filmName)
        {
            throw new NotImplementedException(); 
        }

        public void ViewSessions(DateTime date)
        {
            throw new NotImplementedException ();
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
    }
}
