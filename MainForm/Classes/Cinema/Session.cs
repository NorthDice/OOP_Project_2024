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

        public Session(DateTime date, string filmName, Halls hallNumber, TimeSpan time)
        {
            _date = date;
            _filmName = filmName;
            _hallNumber = hallNumber;
            _time = time;
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

        public bool ReturnTicket(DateTime currentDateTime)
        {
            throw new NotImplementedException();
        }
        public void ViewSessionInformation()
        {
            throw new NotImplementedException(); 
        }

        public void DisplayDescription(string filmName, string director, int year, string description)
        {
            throw new NotImplementedException();
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Halls HallNumber
        {
            get { return _hallNumber; }
            set { _hallNumber = value; }
        }

        public string FilmName
        {
            get { return _filmName; }
            set { _filmName = value; }
        }
    }
}
