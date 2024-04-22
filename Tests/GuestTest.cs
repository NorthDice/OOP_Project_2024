using MainForm.Classes.Cinema;
using MainForm.Enums;
using MainForm.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class GuestTests
    {
        [TestMethod]
        public void ViewSessions_ValidData_ShouldReturnTrue()
        {
            // Arrange
            var guest = new Guest();
            var sessionList = new SessionList();
            var currentDate = DateTime.Now;
            sessionList.AddSession(new Session(currentDate, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));

            // Act
            var result = guest.ViewSessions(currentDate, sessionList);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ViewSessions_EmptySessionList_ShouldThrowArgumentNullException()
        {
            // Arrange
            var guest = new Guest();
            var sessionList = new SessionList();
            var currentDate = DateTime.Now;

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => guest.ViewSessions(currentDate, sessionList));
        }

        [TestMethod]
        public void ViewSessions_PastDate_ShouldReturnFalse()
        {
            // Arrange
            var guest = new Guest();
            var sessionList = new SessionList();
            var pastDate = DateTime.Now.AddDays(-1); // Используем прошедшую дату
            sessionList.AddSession(new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));

            // Act
            var result = guest.ViewSessions(pastDate, sessionList);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Registration_ValidInput_ReturnsTrue()
        {
            // Arrange
            var guest = new Guest();
            var users = new UserList();
            string login = "testuser";
            string password = "testpassword";
            string name = "John";
            string surname = "Doe";

            // Act
            bool result = guest.Registration(login, password, name, surname, users);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Registration_EmptyLogin_ShouldThrowArgumentNullException()
        {
            // Arrange
            var guest = new Guest();
            var userList = new UserList();
            var login = "";
            var password = "testpassword";
            var name = "John";
            var surname = "Doe";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => guest.Registration(login, password, name, surname, userList));
        }

        [TestMethod]
        public void Registration_EmptyPassword_ShouldThrowArgumentNullException()
        {
            // Arrange
            var guest = new Guest();
            var userList = new UserList();
            var login = "testuser";
            var password = "";
            var name = "John";
            var surname = "Doe";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => guest.Registration(login, password, name, surname, userList));
        }

        [TestMethod]
        public void Registration_InvalidName_ShouldThrowArgumentException()
        {
            // Arrange
            var guest = new Guest();
            var userList = new UserList();
            var login = "testuser";
            var password = "testpassword";
            var name = "123John"; // Невалидное имя
            var surname = "Doe";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Registration(login, password, name, surname, userList));
        }

        [TestMethod]
        public void Registration_InvalidSurname_ShouldThrowArgumentException()
        {
            // Arrange
            var guest = new Guest();
            var userList = new UserList();
            var login = "testuser";
            var password = "testpassword";
            var name = "John";
            var surname = "123Doe"; // Невалидная фамилия

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => guest.Registration(login, password, name, surname, userList));
        }
    }
}
