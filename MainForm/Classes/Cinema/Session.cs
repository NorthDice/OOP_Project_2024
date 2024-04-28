using MainForm.Enums;
using MainForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.Cinema
{
     public class Session : ISessionDescriprion
    {
        private DateTime _date;
        private string _filmName;
        private Halls _hallNumber;
        private TimeSpan _time;
        public static int _count = 0;

        public Session() {      }
        public Session(DateTime date, string filmName, Halls hallNumber, TimeSpan time)
        {
            Date = date;
            FilmName = filmName;
            HallNumber = hallNumber;
            Time = time;
        }

        public event EventHandler SessionStarted;

        public void StartSession()
        {
            OnSessionStarted();
        }

        protected virtual void OnSessionStarted()
        {
            SessionStarted?.Invoke(this, EventArgs.Empty);
        }
        public void ViewSessionInformation(ListBox listBox)
        {
            string sessionInfo = $"Film name: {FilmName}\n Session date: {Date}\n Session hall: {HallNumber}";
            listBox.Items.Add(sessionInfo);
        }

        public void DisplayDescription(string filmName, string director, int year, string description)
        {
            Console.WriteLine($"Film name: {filmName}\n Film Director: {director}\n Issue date: {year}\n Short description: {description}");
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentOutOfRangeException("Date cannot be in the past");
                }
                _date = value;
            }
        }


     

        public TimeSpan Time
        {
            get { return _time; }
            set
            {
                if (value < TimeSpan.Zero)
                {
                    throw new ArgumentOutOfRangeException("Time cannot be negative");
                }
                _time = value;
            }
        }

        public Halls HallNumber
        {
            get { return _hallNumber; }
            set
            {
                if (!Enum.IsDefined(typeof(Halls), value))
                {
                    throw new ArgumentException("Invalid value for room number!");
                }
                _hallNumber = value;
            }
        }

        public string FilmName
        {
            get { return _filmName; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Film name can not be null or empty!");
                }
                _filmName = value;
            }
        }

        public static int CountOfGuests
        {
            get { return _count; }
            set
            {
                if (_count > 30)
                {
                    throw new ArgumentOutOfRangeException("Erorr!");
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Session otherSession = (Session)obj;
            return Date == otherSession.Date &&
                   Time == otherSession.Time &&
                   HallNumber == otherSession.HallNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Date, Time, HallNumber);
        }
    }
}
