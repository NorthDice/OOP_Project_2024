using MainForm.Classes.Cinema;
using MainForm.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainForm.Classes.UserClasses
{
    internal class Guest : User, IRegistration
    {

        public bool ViewSessions(DateTime date, SessionList sessions)
        {

            if(sessions.IsEmpty())
            {
                throw new ArgumentNullException("Can not take view sessions list is epmty!");
            }
            if (date < DateTime.Now.Date)
            {
                return false;
            }

            var sessionsOnDate = sessions.Where(session => session.Date == date);

            foreach (var session in sessionsOnDate)
            {
                session.ViewSessionInformation();
            }

            return true;
        }

        public override bool SignUp(string login, string password, UserList users)
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

            foreach (User user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    CurrentUserManager.SetCurrentUser(user);
                    return true;
                }
            }

            return false;
        }

        public bool Registration(string login, string password,string name,string surname,UserList users)
        {

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Login and password cannot be null value!");
            }
            if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Name field must contain only Latin charecters!");
            }
            if (!Regex.IsMatch(surname, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Surname field must contain only Latin charecters!");
            }
            if (Regex.IsMatch(password, "^[a-zA-Z]{6,}$"))
            {
                return false;
            }
            if (Regex.IsMatch(login, "^[a-zA-Z]{5,}$"))
            {
                return false;
            }

            users.AddUser(new RegistredUser(login, password,name,surname,Enums.Role.RegistredUser));
            return true;

        }

        public override string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
