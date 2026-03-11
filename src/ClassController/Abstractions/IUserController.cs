namespace ClassController.Abstractions
{
    /// <summary>
    /// An interface to handle user-related operations.
    /// </summary>
    public interface IUserController
    {
        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the login is successful; otherwise, false.</returns>
        public bool Login(string username, string password);

        /// <summary>
        /// Registers the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the login is successful; otherwise, false.</returns>
        public bool Register(string username, string password);
    }
}
