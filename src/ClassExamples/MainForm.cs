namespace ClassExamples
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            var input1 = int.Parse(this.textBox1.Text);
            var input2 = int.Parse(this.textBox2.Text);

            var result = input1 + input2;
            var resultAsString = result.ToString();
            this.resultLbl.Text = $"El resultado de la suma es: " + resultAsString;
        }

        private void newEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha hecho click en el boton de suma");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var input1 = int.Parse(this.textBox1.Text);
            var input2 = int.Parse(this.textBox2.Text);
            var result = input1 - input2;
            var resultAsString = result.ToString();
            this.resultLbl.Text = $"El resultado de la resta es: " + resultAsString;
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            var input1 = int.Parse(this.textBox1.Text);
            var input2 = int.Parse(this.textBox2.Text);
            var result = input1 * input2;
            var resultAsString = result.ToString();
            this.resultLbl.Text = $"El resultado de la multiplicacion es: " + resultAsString;
        }
    }
}
