using MainForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.Cinema
{
    public class Film : ISessionDescriprion
    {
        private string _title;
        private string _director;
        private int _year;
        private string _genre;
        private string _description;

        public Film(string title, string director, int year, string genre, string description)
        {
            throw new NotImplementedException();
        }

        public string Title { get { return _title; } set { _title = value; } }                
        public string Director { get { return _director; } set { _director = value; } }        
        public int Year { get { return _year; } set { _year = value; } }                        
        public string Genre { get { return _genre; } set { _genre = value; } }                
        public string Description { get { return _description; } set { _description = value; } }

        public void DisplayDescription()
        {
            throw new NotImplementedException();
        }
    }
}
