using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    internal class CurrentUserManager 
    {
        private static User _currentUser;

        public static void SetCurrentUser(User user)
        {
            Debug.WriteLine(user.UserRole);
            _currentUser = user;
            
        }

        public static User GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
