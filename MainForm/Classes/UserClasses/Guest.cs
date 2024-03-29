using MainForm.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    internal class Guest : User, IRegistration
    {
        
        
        
        public bool ViewSessions(DateTime date)
        {
            throw new NotImplementedException();
        }

        public override bool SignUp(string login, string password)
        {
            throw new NotImplementedException();
        }

        public bool Registration(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
