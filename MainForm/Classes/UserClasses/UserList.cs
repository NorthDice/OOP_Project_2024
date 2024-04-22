using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Classes.UserClasses
{
    public class UserList : IEnumerable<RegistredUser>, ICollection
    {
        private List<RegistredUser> users;

        public UserList()
        {
            users = new List<RegistredUser>();
        }

        public int Count => users.Count;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public void AddUser(RegistredUser user)
        {
            user = user ?? throw new ArgumentNullException(nameof(user), "User cannot be null");

            if (users.Contains(user))
            {
                throw new ArgumentException("Duplicate user!");
            }

            users.Add(user);
        }

        public bool RemoveUser(RegistredUser user)
        {
            user = user ?? throw new ArgumentNullException(nameof(user), "User cannot be null");

            return users.Remove(user);
        }

        public bool Contains(string name)
        {
            return users.Any(user => user.Name == name);
        }

        public bool IsEmpty()
        {
            return users.Count == 0;
        }

        public IEnumerator<RegistredUser> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return users.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (array.Rank > 1 || index >= array.Length || Count > array.Length - index)
            {
                throw new ArgumentException("Invalid array or index length");
            }

            foreach (var user in users)
            {
                array.SetValue(user, index++);
            }
        }
    }
}
