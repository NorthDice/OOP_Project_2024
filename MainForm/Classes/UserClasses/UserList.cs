using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    public class UserList : IEnumerable<User>, ICollection
    {
        private List<User> users;

        public UserList()
        {
            users = new List<User>();
        }

        public int Count => users.Count;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public void AddUser(User user)
        {
            if (user != null)
            {
                users.Add(user);
            }
            else
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }
        }

        public bool RemoveUser(User user)
        {
            return users.Remove(user);
        }

        public IEnumerator<User> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return users.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
