namespace ClassController
{
    using ClassController.Abstractions;

    /// <summary>
    /// Controller for Login operations.
    /// </summary>
    public class LoginController
    {
        private readonly IUserController userController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="userController">The user controller.</param>
        public LoginController(IUserController userController)
        {
            this.userController = userController;
        }

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the login is successful; otherwise, false.</returns>
        public bool Login(string username, string password)
        {
            return this.userController.Login(username, password);
        }

        /// <summary>
        /// Registers the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>True if the registration is successful; otherwise, false.</returns>
        public bool Register(string username, string password)
        {
            return this.userController.Register(username, password);
        }
    }
}
