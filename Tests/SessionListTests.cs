using MainForm.Classes.Cinema;
using MainForm.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class SessionListTests
    {
        [TestMethod]
        public void AddSession_ShouldAddSessionToList()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Session session = new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18));

            // Act
            sessionList.AddSession(session);

            // Assert
            Assert.AreEqual(1, sessionList.Count);
            Assert.IsTrue(sessionList.Contains(session));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddSession_NullSession_ShouldThrowArgumentNullException()
        {
            // Arrange
            SessionList sessionList = new SessionList();

            // Act
            sessionList.AddSession(null);

            // Assert
            // ExpectedExceptionAttribute указывает, что ожидается исключение типа ArgumentNullException
            // поэтому нет необходимости в дополнительных assert-утверждениях здесь
        }

        [TestMethod]
        public void RemoveSession_ShouldRemoveSessionFromList()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            sessionList.Clear();
            Session session = new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18));
            sessionList.AddSession(session);

            // Act
            bool removed = sessionList.RemoveSession(session);

            // Assert
            Assert.IsTrue(removed);
            Assert.AreEqual(0, sessionList.Count);
            Assert.IsFalse(sessionList.Contains(session));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveSession_SessionNotFound_ShouldThrowArgumentException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Session session = new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18));

            // Act
            sessionList.RemoveSession(session);

            // Assert
            // Ожидаем, что метод RemoveSession выбросит исключение ArgumentException,
            // поэтому нет необходимости в дополнительных assert-утверждениях здесь
        }
        [TestMethod]
        public void Clear_ShouldRemoveAllSessionsFromList()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Session session1 = new Session(DateTime.Now, "Test Film 1", Halls.FirstHall, TimeSpan.FromHours(18));
            Session session2 = new Session(DateTime.Now, "Test Film 2", Halls.SecondHall, TimeSpan.FromHours(20));
            sessionList.AddSession(session1);
            sessionList.AddSession(session2);

            // Act
            sessionList.Clear();

            // Assert
            Assert.AreEqual(0, sessionList.Count);
            Assert.IsFalse(sessionList.Any());
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnTrueWhenListIsEmpty()
        {
            // Arrange
            SessionList sessionList = new SessionList();

            // Act
            bool isEmpty = sessionList.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnFalseWhenListIsNotEmpty()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Session session = new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18));
            sessionList.AddSession(session);

            // Act
            bool isEmpty = sessionList.IsEmpty();

            // Assert
            Assert.IsFalse(isEmpty);
        }
        [TestMethod]
        public void Count_ShouldReturnCorrectNumberOfSessions()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Session session1 = new Session(DateTime.Now, "Test Film 1", Halls.FirstHall, TimeSpan.FromHours(18));
            Session session2 = new Session(DateTime.Now, "Test Film 2", Halls.SecondHall, TimeSpan.FromHours(20));
            sessionList.AddSession(session1);
            sessionList.AddSession(session2);

            // Act
            int count = sessionList.Count;

            // Assert
            Assert.AreEqual(2, count);
        }

    }
}
