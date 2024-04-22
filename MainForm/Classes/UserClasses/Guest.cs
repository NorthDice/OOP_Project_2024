using MainForm.Classes.Cinema;
using MainForm.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MainForm.Classes.UserClasses
{
    public class Guest : User, IRegistration
    {

        public bool ViewSessions(DateTime date, SessionList sessions, ListBox listBox)
        {
            listBox.Items.Clear(); 

            if (sessions.IsEmpty())
            {
                throw new ArgumentNullException("Cannot view sessions list is empty!");
            }
            if (date < DateTime.Now.Date)
            {
                return false;
            }

            List<Session> sessionsOnDate = new List<Session>();

            foreach (var session in sessions)
            {
                if (session.Date.Date == date.Date)
                {
                    sessionsOnDate.Add(session);
                }
            }

            foreach (var session in sessionsOnDate)
            {
                Debug.WriteLine($"Session date: {session.Date}");
                session.ViewSessionInformation(listBox);
            }

            return true;
        }


        public override bool SignUp(string login, string password, UserList users)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Login and password cannot be null value!");
            }
            if (password.Length < 6 && !Regex.IsMatch(password, "^[a-zA-Z]+$"))
            {
               return false;
            }
            if (login.Length < 5 && !Regex.IsMatch(login, "^[a-zA-Z]+$"))
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

        public bool Registration(string login, string password, string name, string surname, UserList users)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Login and password cannot be null value!");
            }
            if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Name field must contain only Latin characters!");
            }
            if (!Regex.IsMatch(surname, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Surname field must contain only Latin characters!");
            }
            if (password.Length < 6 && !Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Password must be at least 6 characters long!");
            }
            if (login.Length < 5 && !Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Login must be at least 5 characters long!");
            }

            users.AddUser(new RegistredUser(login, password, name, surname, Enums.Role.RegistredUser));
            return true;
        }

        public override string Login { get; set; }
        public override string Password { get; set; }
    }
}
