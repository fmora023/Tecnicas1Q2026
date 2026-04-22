using ClassController;
using ClassController.Abstractions;
using ClassExampleModel;
using Moq;

namespace ClassControllerTest
{
    /// <summary>
    /// Test for <see cref="LoginController"/>.
    /// </summary>
    [TestClass]
    public class LoginControllerTest
    {
        /// <summary>
        /// Logins the should be successful.
        /// </summary>
        [TestMethod]
        public void LoginShouldBeSuccessful()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<User>>();
            var users = new List<User>
            {
                new ("user","123"),
                new ("user2","123"),
                new ("user3","123"),
            };

            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            var userController = new UserController(dataHandlerMock.Object);
            var loginController = new LoginController(userController);

            // Act
            var result = loginController.Login("user", "123");

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Login with wrong password should fail.
        /// </summary>
        [TestMethod]
        public void LoginWithWrongPasswordShouldFail()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<User>>();
            var users = new List<User>
            {
                new ("user","123"),
                new ("user2","123"),
                new ("user3","123"),
            };

            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            var userController = new UserController(dataHandlerMock.Object);
            var loginController = new LoginController(userController);

            // Act
            var result = loginController.Login("user", "1234");

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Login without users should not crash.
        /// </summary>
        [TestMethod]
        public void LoginWithoutUsersShouldNotCrash()
        {
            // Arrange
            var dataHandlerMock = new Mock<IDataHandler<User>>();
            var users = new List<User>();

            dataHandlerMock.Setup(x => x.LoadData()).Returns(users);
            var userController = new UserController(dataHandlerMock.Object);
            var loginController = new LoginController(userController);

            // Act
            var result = loginController.Login("user", "1234");

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Tests the login with user controller mock.
        /// Note: this is a unit test, the others could be seen as integration test.
        /// </summary>
        [TestMethod]
        public void TestLoginWithUserControllerMock()
        {
            // Arrange
            var userControllerMock = new Mock<IUserController>();
            userControllerMock.Setup(x => x.Login("Gerardo", "SomePassword")).Returns(true);

            var loginController = new LoginController(userControllerMock.Object);

            // Act
            var result = loginController.Login("Gerardo", "SomePassword");

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Tests the login with user controller mock with any args.
        /// Note: this is a unit test, the others could be seen as integration test.
        /// </summary>
        [TestMethod]
        public void TestLoginWithUserControllerMockWithAnyArgs()
        {
            // Arrange
            var userControllerMock = new Mock<IUserController>();
            userControllerMock.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var loginController = new LoginController(userControllerMock.Object);

            // Act
            // var result = loginController.Login("Gerardo", "SomePassword");
            var result = loginController.Login("Gerardo", "123");

            // Assert
            Assert.IsTrue(result);
        }
    }
}
