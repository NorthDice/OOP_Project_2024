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
    public class RegistredUserTests
    {


        [TestMethod]
        public void BuyTicket_ValidData_ShouldReturnTrue()
        {
            // Arrange
            DateTime futureDate = DateTime.Now.AddDays(1); // будущая дата
            TimeSpan futureTime = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(1)); // будущее время
            Halls hallNumber = Halls.FirstHall;
            string filmName = "Test Film";
            SessionList sessions = new SessionList();
            sessions.Add(new Session(futureDate, filmName, hallNumber, futureTime)); // добавляем будущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);

            // Act
            bool result = user.BuyTicket(futureDate, futureTime, hallNumber, filmName, sessions);

            // Assert
            Assert.IsTrue(result, "Buying a ticket should return true for valid data");
        }

        [TestMethod]
        public void BuyTicket_InvalidData_ShouldThrowArgumentException()
        {
            // Arrange
            DateTime pastDate = DateTime.Now.AddDays(10); // Прошлая дата
            TimeSpan pastTime = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(-20)); // Прошедшее время
            Halls hallNumber = Halls.FirstHall;
            string filmName = "Test Film";
            SessionList sessions = new SessionList();
            sessions.Add(new Session(DateTime.Now, filmName, hallNumber, DateTime.Now.TimeOfDay)); // Добавляем текущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => user.BuyTicket(pastDate, pastTime, hallNumber, filmName, sessions));
        }
        [TestMethod]
        public void ReturnTicket_ValidData_ShouldReturnTrue()
        {
            // Arrange
            DateTime futureDate = DateTime.Now.AddDays(1); // будущая дата
            TimeSpan futureTime = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(1)); // будущее время
            Halls hallNumber = Halls.FirstHall;
            string filmName = "Test Film";
            SessionList sessions = new SessionList();
            sessions.Add(new Session(futureDate, filmName, hallNumber, futureTime)); // добавляем будущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);

            // Act
            bool result = user.ReturnTicket(futureDate, futureTime, hallNumber, filmName, sessions);

            // Assert
            Assert.IsTrue(result, "Returning a ticket should return true for valid data");
        }

        [TestMethod]
        public void ReturnTicket_InvalidData_ShouldReturnFalse()
        {
            // Arrange
            DateTime pastDate = DateTime.Now.AddDays(-1); // Прошлая дата
            TimeSpan pastTime = DateTime.Now.TimeOfDay.Add(TimeSpan.FromHours(-1)); // Прошедшее время
            Halls hallNumber = Halls.FirstHall;
            string filmName = "Test Film";
            SessionList sessions = new SessionList();
            sessions.Add(new Session(DateTime.Now, filmName, hallNumber, DateTime.Now.TimeOfDay)); // Добавляем текущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);

            // Act
            bool result = user.ReturnTicket(pastDate, pastTime, hallNumber, filmName, sessions);

            // Assert
            Assert.IsFalse(result, "Returning a ticket should return false for invalid data");
        }
        [TestMethod]
        public void ViewSessions_ValidDate_ShouldReturnTrue()
        {
            // Arrange
            DateTime futureDate = DateTime.Now.AddDays(1); // будущая дата
            SessionList sessions = new SessionList();
            sessions.Add(new Session(futureDate, "Test Film", Halls.FirstHall, DateTime.Now.TimeOfDay)); // добавляем будущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);
            ListBox listBox = new ListBox();
            // Act
            bool result = user.ViewSessions(futureDate, sessions,listBox);

            // Assert
            Assert.IsTrue(result, "Viewing sessions should return true for valid date");
        }

        [TestMethod]
        public void ViewSessions_InvalidDate_ShouldReturnFalse()
        {
            // Arrange
            DateTime pastDate = DateTime.Now.AddDays(-1); // Прошлая дата
            SessionList sessions = new SessionList();
            sessions.Add(new Session(DateTime.Now, "Test Film", Halls.FirstHall, DateTime.Now.TimeOfDay)); // Добавляем текущий сеанс

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);
            ListBox listBox = new ListBox();
            // Act
            bool result = user.ViewSessions(pastDate, sessions, listBox);

            // Assert
            Assert.IsFalse(result, "Viewing sessions should return false for invalid date");
        }

        [TestMethod]
        public void ViewSessions_EmptySessionList_ShouldThrowArgumentNullException()
        {
            // Arrange
            DateTime futureDate = DateTime.Now.AddDays(1); // будущая дата
            SessionList sessions = new SessionList(); // пустой список сеансов

            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);
            ListBox listBox = new ListBox();
            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => user.ViewSessions(futureDate, sessions, listBox));
        }
        [TestMethod]
        public void SignUp_ValidCredentials_ShouldReturnTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "testpassword";
            UserList users = new UserList(); // Пустой список пользователей
            Guest guest = new Guest(); // Создаем экземпляр класса Guest
            RegistredUser user = new RegistredUser("testuser", "testpassword", "Test", "User", Role.RegistredUser);


            // Act

            users.Add(user);
            bool result = guest.SignUp(username, password, users);

            // Assert
            Assert.IsTrue(result);

        }



        [TestMethod]
        public void SignUp_ExistingUser_ShouldReturnTrue()
        {
            // Arrange
            string username = "testuser";
            string password = "testpassword";
            UserList users = new UserList();
            users.Add(new RegistredUser(username, password, "Test", "User", Role.RegistredUser)); // Добавляем пользователя с такими же учетными данными
            Guest guest = new Guest(); // Создаем экземпляр класса Guest

            // Act
            bool result = guest.SignUp(username, password, users);

            // Assert
            Assert.IsTrue(result, "Signing up should return true even if user with the same credentials already exists");
        }

        [TestMethod]
        public void SignUp_InvalidPassword_ShouldReturnFalse()
        {
            // Arrange
            string username = "testuser";
            string password = "pass"; // Пароль слишком короткий
            UserList users = new UserList(); // Пустой список пользователей
            Guest guest = new Guest(); // Создаем экземпляр класса Guest

            // Act
            bool result = guest.SignUp(username, password, users);

            // Assert
            Assert.IsFalse(result, "Signing up should return false for invalid password");
        }

        [TestMethod]
        public void SignUp_InvalidUsername_ShouldReturnFalse()
        {
            // Arrange
            string username = "user"; // Имя пользователя слишком короткое
            string password = "testpassword";
            UserList users = new UserList(); // Пустой список пользователей
            Guest guest = new Guest(); // Создаем экземпляр класса Guest

            // Act
            bool result = guest.SignUp(username, password, users);

            // Assert
            Assert.IsFalse(result, "Signing up should return false for invalid username");
        }

        [TestMethod]
        public void SignUp_NullCredentials_ShouldThrowArgumentNullException()
        {
            // Arrange
            string username = null;
            string password = "testpassword";
            UserList users = new UserList(); // Пустой список пользователей
            Guest guest = new Guest(); // Создаем экземпляр класса Guest

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => guest.SignUp(username, password, users));
        }

    }
}
