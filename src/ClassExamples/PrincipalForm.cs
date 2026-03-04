namespace ClassExamples
{
    using ClassController;

    /// <summary>
    /// Main form of the application, it will be used to navigate to the different examples.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PrincipalForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalForm"/> class.
        /// </summary>
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void BtnSimpleCalc_Click(object sender, EventArgs e)
        {
            var calculatorForm = new CalculatorForm(new CalculatorController());
            calculatorForm.Show();
        }

        private void AlternativeCalculatorBtn_Click(object sender, EventArgs e)
        {
            var alternativeCalculatorForm = new CalculatorForm(new AbstractCalculatorController());
            alternativeCalculatorForm.Show();
        }
    }
}
