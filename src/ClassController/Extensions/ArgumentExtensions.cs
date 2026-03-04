namespace ClassController.Extensions
{
    /// <summary>
    /// Class for extension methods related to arguments.
    /// </summary>
    public static class ArgumentExtensions
    {
        /// <summary>
        /// Converts the string representation of a string to an integer.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <returns>the value of the argument as an integer</returns>
        public static int ToInt(this string argument)
        {
            if (int.TryParse(argument, out var result))
            {
                return result;
            }

            throw new NotSupportedException("The provided argument cannot be converted to an integer.");
        }

        /// <summary>
        /// Converts the string representation of a string to an integer.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <returns>the value of the argument as an integer</returns>
        public static int ToInteger(string argument)
        {
            if (int.TryParse(argument, out var result))
            {
                return result;
            }

            throw new NotSupportedException("The provided argument cannot be converted to an integer.");
        }
    }
}
