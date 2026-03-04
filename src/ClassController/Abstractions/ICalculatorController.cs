namespace ClassController.Abstractions
{
    /// <summary>
    /// CalculatorController defines the operations of a calculator.
    /// </summary>
    public interface ICalculatorController
    {
        /// <summary>
        /// Sums the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>the sum of the inputs</returns>
        public int Sum(int input1, int input2);

        /// <summary>
        /// Subtracts the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>the subtraction of the inputs</returns>
        public int Subtract(int input1, int input2);

        /// <summary>
        /// Multiplies the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>the multiplication of the inputs</returns>
        public int Multiply(int input1, int input2);

        /// <summary>
        /// Divides the specified input1.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>the division of the inputs</returns>
        public int Divide(int input1, int input2);
    }
}
