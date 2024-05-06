using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using telyukos;

namespace Tests
{
    [TestClass]
    public class AuthControllerTests
    {
        private AuthController _authController;

        [TestInitialize]
        public void Setup()
        {
            // Initialize AuthController with an empty user list
            _authController = new AuthController();
            MethodInfo setUsersMethod = typeof(AuthController).GetMethod("SetUsers", BindingFlags.NonPublic | BindingFlags.Instance);
            setUsersMethod.Invoke(_authController, new object[] { new List<User>() });
        }

        [TestMethod]
        public void Register_WithValidUser_ReturnsOk()
        {
            // Arrange
            var newUser = new User
            {
                Email = "test@example.com",
                Password = "testpassword",
                Role = "penyewa"
            };

            // Act
            var result = _authController.Register(newUser);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Register_WithExistingEmail_ReturnsConflict()
        {
            // Arrange
            var existingUser = new User
            {
                Email = "existing@example.com",
                Password = "existingpassword",
                Role = "pemilik"
            };
            MethodInfo setUsersMethod = typeof(AuthController).GetMethod("SetUsers", BindingFlags.NonPublic | BindingFlags.Instance);
            setUsersMethod.Invoke(_authController, new object[] { new List<User> { existingUser } });

            var newUser = new User
            {
                Email = "existing@example.com",
                Password = "newpassword",
                Role = "penyewa"
            };

            // Act
            var result = _authController.Register(newUser);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ConflictObjectResult));
        }

        // Add more test methods as needed...

    }
}
