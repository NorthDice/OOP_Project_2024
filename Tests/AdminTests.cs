using MainForm.Classes.UserClasses;
using MainForm.Classes.Cinema;
using MainForm.Enums;
using MainForm.Enums;
using MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void AddSession_ValidData_ShouldAddSession()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act
            bool added = admin.AddSession(DateTime.Now.AddDays(1), TimeSpan.FromHours(18), Halls.FirstHall, "Test Film", sessionList);

            // Assert
            Assert.IsTrue(added);
            Assert.AreEqual(1, sessionList.Count);
        }

        [TestMethod]
        public void AddSession_InvalidData_ShouldThrowException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => admin.AddSession(DateTime.Now, TimeSpan.FromHours(18), Halls.FirstHall, "", sessionList));
        }

        [TestMethod]
        public void AddSession_NullFilmName_ShouldThrowArgumentNullException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => admin.AddSession(DateTime.Now.AddDays(1), TimeSpan.FromHours(18), Halls.FirstHall, null, sessionList));
        }

        [TestMethod]
        public void AddSession_InvalidHallNumber_ShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => admin.AddSession(DateTime.Now.AddDays(1), TimeSpan.FromHours(18), (Halls)(-1), "Test Film", sessionList));
        }

        [TestMethod]
        public void AddSession_PastDate_ShouldReturnFalse()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act
            bool added = admin.AddSession(DateTime.Now.AddDays(-1), TimeSpan.FromHours(18), Halls.FirstHall, "Test Film", sessionList);

            // Assert
            Assert.IsFalse(added);
        }

        [TestMethod]
        public void EditSession_PastDate_ShouldReturnFalse()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            sessionList.AddSession(new Session(DateTime.Now.AddDays(1), "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));

            // Act
            bool edited = admin.EditSession(DateTime.Now.AddDays(-1), TimeSpan.FromHours(18), TimeSpan.FromHours(19), sessionList);

            // Assert
            Assert.IsFalse(edited);
        }

        [TestMethod]
        public void EditSession_PastTime_ShouldReturnFalse()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            sessionList.AddSession(new Session(DateTime.Now.AddDays(1), "Test Film", Halls.FirstHall, TimeSpan.FromHours(18)));

            // Act
            bool edited = admin.EditSession(DateTime.Now.AddDays(1), TimeSpan.FromHours(17), TimeSpan.FromHours(19), sessionList);

            // Assert
            Assert.IsFalse(edited);
        }
        [TestMethod]
        public void EditSession_EmptyList_ShouldThrowArgumentNullException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => admin.EditSession(DateTime.Now.AddDays(1), TimeSpan.FromHours(18), TimeSpan.FromHours(19), sessionList));
        }
        [TestMethod]
        public void EditSession_SuccessfulEdit_ShouldReturnTrue()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            var originalTime = TimeSpan.FromHours(18);
            var newTime = TimeSpan.FromHours(19);
            var tomorrow = DateTime.Now.AddDays(1);
            sessionList.AddSession(new Session(tomorrow, "Test Film", Halls.FirstHall, originalTime));

            // Act
            bool edited = admin.EditSession(tomorrow, originalTime, newTime, sessionList);

            // Assert
            Assert.IsTrue(edited);
        }

        [TestMethod]
        public void DeleteSession_SessionExists_ShouldReturnTrue()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            var date = DateTime.Now.AddDays(1);
            var time = TimeSpan.FromHours(18);
            var filmName = "Test Film";
            var hallNumber = Halls.FirstHall;
            sessionList.AddSession(new Session(date, filmName, hallNumber, time));

            // Act
            bool deleted = admin.DeleteSession(date, time, hallNumber, filmName, sessionList);

            // Assert
            Assert.IsTrue(deleted);
            Assert.AreEqual(0, sessionList.Count);
        }

        [TestMethod]
        public void DeleteSession_SessionNotFound_ShouldThrowArgumentException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            var date = DateTime.Now.AddDays(1);
            var time = TimeSpan.FromHours(18);
            var hallNumber = Halls.FirstHall;
            var filmName = "Test Film";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => admin.DeleteSession(date, time, hallNumber, filmName, sessionList));
        }

        [TestMethod]
        public void DeleteSession_EmptySessionList_ShouldThrowArgumentNullException()
        {
            // Arrange
            SessionList sessionList = new SessionList();
            Admin admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            var date = DateTime.Now.AddDays(1);
            var time = TimeSpan.FromHours(18);
            var hallNumber = Halls.FirstHall;
            var filmName = "Test Film";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => admin.DeleteSession(date, time, hallNumber, filmName, sessionList));
        }

        [TestMethod]
        public void Login_SetValidLogin_ShouldSetLogin()
        {
            // Arrange
            string validLogin = "admin";
            var admin = new Admin("initialLogin", "password", "John", "Doe", Role.Admin);

            // Act
            admin.Login = validLogin;

            // Assert
            Assert.AreEqual(validLogin, admin.Login);
        }

        [TestMethod]
        public void Login_SetInvalidLogin_ShouldThrowArgumentException()
        {
            // Arrange
            string invalidLogin = "ad";
            var admin = new Admin("initialLogin", "password", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => admin.Login = invalidLogin);
        }

        [TestMethod]
        public void Password_SetValidPassword_ShouldSetPassword()
        {
            // Arrange
            string validPassword = "strongPassword";
            var admin = new Admin("admin", "initialPassword", "John", "Doe", Role.Admin);

            // Act
            admin.Password = validPassword;

            // Assert
            Assert.AreEqual(validPassword, admin.Password);
        }

        [TestMethod]
        public void Password_SetInvalidPassword_ShouldThrowArgumentException()
        {
            // Arrange
            string invalidPassword = "weak";
            var admin = new Admin("admin", "initialPassword", "John", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => admin.Password = invalidPassword);
        }
        [TestMethod]
        public void Name_SetValidName_ShouldSetName()
        {
            // Arrange
            string validName = "John";
            var admin = new Admin("admin", "password", "initialName", "Doe", Role.Admin);

            // Act
            admin.Name = validName;

            // Assert
            Assert.AreEqual(validName, admin.Name);
        }

        [TestMethod]
        public void Name_SetInvalidName_ShouldThrowArgumentException()
        {
            // Arrange
            string invalidName = "1234"; // Недопустимое имя, так как содержит цифры
            var admin = new Admin("admin", "password", "initialName", "Doe", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => admin.Name = invalidName);
        }
        [TestMethod]
        public void Surname_SetValidSurname_ShouldSetSurname()
        {
            // Arrange
            string validSurname = "Doe";
            var admin = new Admin("admin", "password", "John", "initialSurname", Role.Admin);

            // Act
            admin.Surname = validSurname;

            // Assert
            Assert.AreEqual(validSurname, admin.Surname);
        }

        [TestMethod]
        public void Surname_SetInvalidSurname_ShouldThrowArgumentException()
        {
            // Arrange
            string invalidSurname = "1234"; // Недопустимая фамилия, так как содержит цифры
            var admin = new Admin("admin", "password", "John", "initialSurname", Role.Admin);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => admin.Surname = invalidSurname);
        }
        [TestMethod]
        public void Role_SetValidRole_ShouldSetRole()
        {
            // Arrange
            var admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            Role validRole = Role.Admin;

            // Act
            admin.UserRole = validRole;

            // Assert
            Assert.AreEqual(validRole, admin.UserRole);
        }

        [TestMethod]
        public void Role_SetInvalidRole_ShouldThrowArgumentException()
        {
            // Arrange
            var admin = new Admin("admin", "password", "John", "Doe", Role.Admin);
            Role invalidRole = (Role)10; // Недопустимое значение

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => admin.UserRole = invalidRole);
        }
       
    }
}
