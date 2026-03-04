using ClassController.Abstractions;
using ClassController.Extensions;

namespace ClassExamples
{
    /// <summary>
    /// View for the Calculator form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CalculatorForm : Form
    {
        private readonly ICalculatorController calculatorController;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorForm"/> class.
        /// </summary>
        /// <param name="calculatorController">The calculator controller.</param>
        public CalculatorForm(ICalculatorController calculatorController)
        {
            this.calculatorController = calculatorController;
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            var (input1, input2) = GetInputs();

            var result = this.calculatorController.Sum(input1, input2);

            this.resultLbl.Text = $"El resultado de la suma es: " + result;
        }

        private void newEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha hecho click en el boton de suma");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var (input1, input2) = GetInputs();
            
            var result = this.calculatorController.Subtract(input1, input2);
            
            this.resultLbl.Text = $"El resultado de la resta es: " + result;
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            var (input1, input2) = GetInputs();

            var result = this.calculatorController.Multiply(input1, input2);

            this.resultLbl.Text = $"El resultado de la multiplicacion es: " + result;
        }

        private (int, int) GetInputs()
        {
            var input1 = ArgumentExtensions.ToInteger(this.textBox1.Text);
            var input2 = this.textBox2.Text.ToInt();
            return (input1, input2);
        }
    }
}
