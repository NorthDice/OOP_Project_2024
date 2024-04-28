using MainForm.Classes.Cinema;
using MainForm.Enums;
using MainForm.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            sessionList.Add(new Session(currentDate, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));
            ListBox listBox = new ListBox();
            // Act
            var result = guest.ViewSessions(currentDate, sessionList,listBox);

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
            ListBox listBox = new ListBox();
            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => guest.ViewSessions(currentDate, sessionList, listBox));
        }

        [TestMethod]
        public void ViewSessions_PastDate_ShouldReturnFalse()
        {
            // Arrange
            var guest = new Guest();
            var sessionList = new SessionList();
            var pastDate = DateTime.Now.AddDays(-1); // Используем прошедшую дату
            sessionList.Add(new Session(DateTime.Now, "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));
            ListBox listBox = new ListBox();

            // Act
            var result = guest.ViewSessions(pastDate, sessionList, listBox);

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
