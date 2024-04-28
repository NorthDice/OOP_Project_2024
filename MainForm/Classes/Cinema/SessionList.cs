using System;
using System.Collections;

namespace MainForm.Classes.Cinema
{
    public class SessionList : IEnumerable<Session>, ICollection<Session>
    {
        public List<Session> _sessions;

        public SessionList()
        {
            _sessions = new List<Session>();
        }

        public event EventHandler SessionsUpdated;

        public virtual void OnSessionsUpdated(EventArgs e)
        {
            SessionsUpdated?.Invoke(this, e);
        }

        public int Count => _sessions.Count;

        public bool IsSynchronized => false;

        public object SyncRoot => this;

        public bool IsReadOnly => false;

        //public void AddSession(Session session)
        //{

        //    session = session ?? throw new ArgumentNullException(nameof(session), "Session can not be null value!");

        //    _sessions.Add(session);
        //}

        //public bool RemoveSession(Session session)
        //{
        //    session = session ?? throw new ArgumentNullException(nameof(session), "Session can not be null value!");

        //    if (!_sessions.Contains(session))
        //    {
        //        throw new ArgumentException("Session not found!");
        //    }

        //    return _sessions.Remove(session);
        //}

        public void Clear()
        {
            _sessions.Clear();
        }

        public bool IsEmpty()
        {
            if (_sessions.Count == 0)
            { 
                return true; 
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<Session> GetEnumerator()
        {
            return _sessions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _sessions.GetEnumerator();
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

            foreach (var session in _sessions)
            {
                array.SetValue(session, index++);
            }
        }

        public void Add(Session item)
        {
            _sessions.Add(item);
        }

        public bool Contains(Session item)
        {
            return _sessions.Contains(item);
        }

        public void CopyTo(Session[] array, int arrayIndex)
        {
            _sessions.CopyTo(array, arrayIndex);
        }

        public bool Remove(Session item)
        {
             return _sessions.Remove(item);
        }
    }
}
