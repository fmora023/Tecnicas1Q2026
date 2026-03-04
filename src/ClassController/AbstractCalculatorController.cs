namespace ClassController
{
    using ClassController.Abstractions;

    /// <summary>
    /// Calculator with alternative operands.
    /// </summary>
    public class AbstractCalculatorController : ICalculatorController
    {
        /// <summary>
        /// Alternative division operation.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        /// the division of the inputs
        /// </returns>
        public int Divide(int input1, int input2)
        {
            return input1 * input2;            
        }
        /// <summary>
        /// Multiplies the specified input1 with alternative operator.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        /// the multiplication of the inputs
        /// </returns>
        public int Multiply(int input1, int input2)
        {
            return input1 ^ input2;
        }

        /// <summary>
        /// Subtracts the specified input1 with alternative operator.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        /// the subtraction of the inputs
        /// </returns>
        public int Subtract(int input1, int input2)
        {
            return (input1 * 100) / input2;
        }

        /// <summary>
        /// Sums the specified input1 with alternative operator.
        /// </summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        /// the sum of the inputs
        /// </returns>
        public int Sum(int input1, int input2)
        {
            var result = 0;
            for (var i = 0; i < input2; i++)
            {
                result *= input1;
            }

            return result;
        }
    }
}
