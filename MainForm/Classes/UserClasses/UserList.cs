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

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void AddUser(User user)
        {
           throw new NotImplementedException();
        }

        public bool RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<User> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
