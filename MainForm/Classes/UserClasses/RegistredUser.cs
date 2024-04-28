using MainForm.Classes.Cinema;
using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MainForm.Classes.UserClasses
{
    public class RegistredUser : User
    {
        private string _login;
        private string _password;
        private string _name;
        private string _surname;
        private Role _userRole = (Role)1;
        
        public RegistredUser() {     }
        public RegistredUser(string login,string password,string name,string surname,Role userRole = Role.RegistredUser) 
        { 
            _login= login;
            Password = password;
            Name = name;
            Surname = surname;
            UserRole = userRole;
        }

        public bool BuyTicket(DateTime date, TimeSpan time, Halls hallNumber, string filmName, SessionList sessions)
        {
            if (String.IsNullOrEmpty(filmName))
            {
                throw new ArgumentNullException("Film name cannot be null or empty!");
            }

            if (!Enum.IsDefined(typeof(Halls), hallNumber))
            {
                throw new ArgumentOutOfRangeException("Unknown hall number!");
            }

            if (time <= TimeSpan.Zero)
            {
                throw new ArgumentException("Time cannot be negative");
            }

            if (date < DateTime.Now.Date)
            {
                return false;
            }
            var session = sessions.FirstOrDefault(s =>
                s.Date == date &&
                s.Time == time &&
                s.HallNumber == hallNumber &&
                s.FilmName == filmName);

            if(session != null)
            {
                Session.CountOfGuests++;
                return true;
            }
            //foreach (var session in sessions)
            //{
            //    if (session.Date == date && session.Time == time && session.HallNumber == hallNumber && session.FilmName == filmName)
            //    {
            //        // Найдена нужная сессия
            //        Session.CountOfGuests++;
            //        return true;
            //    }
            //}

            return false;
            

        }

        public bool ReturnTicket(DateTime date, TimeSpan time, Halls hallNumber, string filmName, SessionList sessions)
        {
            if (String.IsNullOrEmpty(filmName))
            {
                throw new ArgumentNullException("Film name cannot be null or empty!");
            }

            if (!Enum.IsDefined(typeof(Halls), hallNumber))
            {
                throw new ArgumentOutOfRangeException("Unknown hall number!");
            }

            if (date < DateTime.Now.Date)
            {
                return false;
            }

            if (time <= TimeSpan.Zero)
            {
                return false;
            }


            DateTime sessionDateTime = date.Date + time;
            TimeSpan timeRemaining = sessionDateTime - DateTime.Now;
            if (timeRemaining.TotalHours < 6)
            {
                return false;
            }


            var session = sessions.FirstOrDefault(s =>
           s.Date == date &&
           s.Time == time &&
           s.HallNumber == hallNumber &&
           s.FilmName == filmName);

            if (session != null)
            {
                Session.CountOfGuests--;
                return true;
            }
            else
            {
                return false;
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
            if (password.Length < 6 || !Regex.IsMatch(password, "^[a-zA-Z]+$"))
            {
                return false;
            }
            if (login.Length < 5 || !Regex.IsMatch(login, "^[a-zA-Z]+$"))
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
                    throw new ArgumentException("Login must contain at least 5 Latin characters.");
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
                    throw new ArgumentException("Password must contain at least 6 Latin characters!");
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

        public override Role UserRole
        {
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
