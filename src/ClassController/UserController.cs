namespace ClassController
{
    using ClassController.Abstractions;
    using ClassExampleModel;

    /// <summary>
    /// Implements the user-related operations.
    /// </summary>
    public class UserController : IUserController
    {
        private readonly List<User> users;
        private readonly IDataHandler<User> dataHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="dataHandler">The data handler.</param>
        public UserController(IDataHandler<User> dataHandler)
        {
            this.dataHandler = dataHandler;
            this.users = dataHandler.LoadData();
        }

        /// <summary>
        /// Logins the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// True if the login is successful; otherwise, false.
        /// </returns>
        public bool Login(string username, string password)
        {
            if (this.users != null && this.ExistsUser(username, password))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Registers the specified username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// True if the login is successful; otherwise, false.
        /// </returns>
        public bool Register(string username, string password)
        {
            if (this.users != null)
            {
                if (this.ExistsUser(username, password))
                {
                    return false;
                }

                this.users.Add(new User(username, password));
                var result = this.dataHandler.SaveData(this.users);
                return result;
            }

            return false;
        }

        private bool ExistsUser(string username, string password)
        {
            foreach (var user in this.users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
