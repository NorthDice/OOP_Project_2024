using MainForm.Classes.Cinema;
using MainForm.Enums;
using MainForm.Interfaces;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    public class Admin : User
    {
        private string _login;
        private string _password;
        private string _name;
        private string _surname;
        private Role _userRole;

        public Admin() { }
        public Admin(string login, string password, string name, string surname, Role userRole)
        {
            _login = login;
            Password = password;
            Name = name;
            Surname = surname;
            UserRole = userRole;
        }

        public bool AddSession(DateTime date, TimeSpan time, Halls hallNumber, string filmName,SessionList sessions)
        {
            if(String.IsNullOrEmpty(filmName)) 
            {
                throw new ArgumentNullException("Film name cannot be null or empty!");
            }
          
            if (!Enum.IsDefined(typeof(Halls), hallNumber))
            {
                throw new ArgumentOutOfRangeException("Unknown hall number!");
            }

            if (date <= DateTime.Now.Date)
            {
                return false;
            }

            sessions.Add(new Session(date, filmName, hallNumber, time));
            return true;
           
        }
        public bool EditSession(DateTime date, TimeSpan time, TimeSpan newTime, SessionList sessions)
        {
            if (date < DateTime.Now.Date )
            {
                return false; 
            }

            if (date == DateTime.Now.Date && newTime <= DateTime.Now.TimeOfDay)
            {
                return false ;
            }
            if (sessions.IsEmpty())
            {
                throw new ArgumentNullException("Session list cannot be empty");
            }

            Session sessionToEdit = sessions.FirstOrDefault(session =>
                session.Date == date && session.Time == time);

            if (sessionToEdit != null)
            {
                sessionToEdit.Time = newTime;
                return true;
            }

            return false;
        }


        public bool DeleteSession(DateTime date, TimeSpan time, Halls hallNumber, string filmName, SessionList sessions)
        {
            if (String.IsNullOrEmpty(filmName))
            {
                throw new ArgumentNullException(nameof(filmName), "Film name cannot be null or empty!");
            }

            if (!Enum.IsDefined(typeof(Halls), hallNumber))
            {
                throw new ArgumentOutOfRangeException(nameof(hallNumber), "Unknown hall number!");
            }

            if (date <= DateTime.Now.Date)
            {
                return false;
            }

            if (sessions.IsEmpty())
            {
                throw new ArgumentNullException(nameof(sessions), "Session list cannot be empty");
            }

            Session sessionToDelete = new Session(date, filmName, hallNumber, time);

            return sessions.Remove(sessionToDelete);
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

        public override string Login
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
                    throw new ArgumentException("Registration is not possible!The login and password must contain only latin letters and numbers! ");
                }
            }
        }

        public override string Password
        {
            get { return _password; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]{6,}$"))
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("Registration is not possible!The login and password must contain only latin letters and numbers!");
                }
            }
        }

        public override string Name
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


        public override string Surname
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

        public override Role UserRole {
            get { return _userRole; }
            set
            {
                if (!Enum.IsDefined(typeof(Role), value))
                {
                    throw new ArgumentException("Invalid user role!");
                }
                _userRole = value;
            }
        }
    }
}
