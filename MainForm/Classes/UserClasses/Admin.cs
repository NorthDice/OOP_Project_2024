using MainForm.Classes.Cinema;
using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    internal class Admin : User
    {
        private string _login;
        private string _password;
        private string _name;
        private string _surname;


        public Admin(string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
        }

        public bool AddSession(DateTime date, TimeSpan time, Halls hallNumber, string filmName)
        { 
            throw new NotImplementedException();
        }
        public bool EditSession(DateTime date, TimeSpan time, TimeSpan newTime)
        {
            throw new NotImplementedException();
            
        }
        public bool DeleteSession(DateTime date, TimeSpan time,Halls hallNumber)
        {
            throw new NotImplementedException();
        }

        public override bool SignUp(string login, string password)
        {
            throw new NotImplementedException();
        }

        public string Login
        {
            get { return _login; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]{5,}$"))
                {
                    _login = value;
                }
                else
                {
                    throw new ArgumentException("Login must contain at least 5 Latin characters.");
                }
            }
        }

        public string Password
        {
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]{6,}$"))
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Password must contain at least 6 Latin characters!");
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name field must contain only Latin charecters!");
                }
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Surname field must contain only Latin charecters!");
                }
            }
        }
    }
}
