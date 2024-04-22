using MainForm.Classes.UserClasses;
using System;
using MainForm.Classes.UserClasses;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainForm.Enums;

namespace Tests
{
    [TestClass]
    public class UserListTests
    {
        [TestMethod]
        public void AddUser_ValidUser_ShouldAddUserToList()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe",Role.RegistredUser);

            // Act
            userList.AddUser(user);

            // Assert
            Assert.AreEqual(1, userList.Count);
            Assert.IsTrue(userList.Contains(user.Name));
        }

        [TestMethod]
        public void AddUser_DuplicateUser_ShouldThrowArgumentException()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);
            userList.AddUser(user);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => userList.AddUser(user));
        }

        [TestMethod]
        public void RemoveUser_ExistingUser_ShouldRemoveUserFromList()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);
            userList.AddUser(user);

            // Act
            userList.RemoveUser(user);

            // Assert
            Assert.AreEqual(0, userList.Count);
            Assert.IsFalse(userList.Contains(user.Name));
        }

        [TestMethod]
        public void RemoveUser_NonExistingUser_ShouldNotModifyList()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);

            // Act
            bool result = userList.RemoveUser(user);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(0, userList.Count);
            Assert.IsFalse(userList.Contains(user.Name));
        }

        [TestMethod]
        public void IsEmpty_EmptyList_ShouldReturnTrue()
        {
            // Arrange
            var userList = new UserList();

            // Act & Assert
            Assert.IsTrue(userList.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_NonEmptyList_ShouldReturnFalse()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);
            userList.AddUser(user);

            // Act & Assert
            Assert.IsFalse(userList.IsEmpty());
        }
    }

}