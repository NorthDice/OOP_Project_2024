using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _login = login;
            _password = password;
            _name = name;
            _surname = surname;
        }



        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
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
    }
}
