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
            var user = new RegistredUser("testuser", "testpassword", "Johbnn", "Doe",Role.RegistredUser);

            // Act
            userList.Add(user);

            // Assert
            Assert.AreEqual(1, userList.Count);
        }

        [TestMethod]
        public void AddUser_DuplicateUser_ShouldThrowArgumentException()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);
            userList.Add(user);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => userList.Add(user));
        }

        [TestMethod]
        public void RemoveUser_ExistingUser_ShouldRemoveUserFromList()
        {
            // Arrange
            var userList = new UserList();
            var user = new RegistredUser("testuser", "testpassword", "John", "Doe", Role.RegistredUser);
            userList.Add(user);

            // Act
            userList.Remove(user);

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
            bool result = userList.Remove(user);

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
            userList.Add(user);

            // Act & Assert
            Assert.IsFalse(userList.IsEmpty());
        }
    }

}