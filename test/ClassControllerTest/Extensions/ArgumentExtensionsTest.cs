namespace ClassControllerTest.Extensions
{
    using ClassController.Extensions;

    /// <summary>
    /// Test for <see cref="ArgumentExtensions"/>.
    /// </summary>
    [TestClass]
    public class ArgumentExtensionsTest
    {
        /// <summary>
        /// Converting a string to int extension should return integer.
        /// </summary>
        [TestMethod]
        public void ToIntExtensionShouldReturnInteger()
        {
            // BDD (Behavioral driven development => Given => when => then) || AAA (Arrange, Act, Assert)
            // Arrange: Set up any objects or values needed for the test.
            // Act: Perform the action that you want to test.
            // Assert: Verify that the action produced the expected result.
            // Arrange
            var input = "123";

            // Act
            var result = input.ToInt();

            // Assert
            Assert.AreEqual(123, result);
        }

        /// <summary>
        /// Converts to intextensionshouldthrowexceptionforinvalidinput.
        /// </summary>
        [TestMethod]
        public void ToIntExtensionShouldThrowExceptionForInvalidInput()
        {
            // Arrange
            var input = "abc";

            // Act & Assert
            Assert.ThrowsException<NotSupportedException>(() => input.ToInt());
        }

        /// <summary>
        /// Converts to intextensionshouldthrowexceptionforinvalidinput.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ToIntExtensionShouldThrowExceptionForInvalidInputWithAttribute()
        {
            // Arrange
            var input = "abc";

            // Act
            input.ToInt();
        }
    }
}
