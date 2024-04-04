﻿using System;
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
            user = user ?? throw new ArgumentNullException(nameof(user), "User cannot be null");

            if (users.Contains(user))
            {
                throw new ArgumentException("Duplicate user!");
            }

            users.Add(user);
        }

        public bool RemoveUser(User user)
        {
            user = user ?? throw new ArgumentNullException(nameof(user), "User cannot be null");

            return users.Remove(user);
        }

        public bool IsEmpty()
        {
            return users.Count == 0;
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
