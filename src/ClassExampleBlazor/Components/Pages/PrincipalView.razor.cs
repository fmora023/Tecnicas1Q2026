using ClassController;
using Microsoft.AspNetCore.Components;

namespace ClassExampleBlazor.Components.Pages
{
    /// <summary>
    /// C# code behind for PrincipalView.razor.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
    public partial class PrincipalView : ComponentBase
    {
        [Inject]
        private CalculatorController CalculatorControllerService { get; set; } = new CalculatorController();

        private int Value1 { get; set; } = 0;
        private int Value2 { get; set; } = 0;
        private string Result { get; set; } = string.Empty;

        private CalculatorController calculatorController = new CalculatorController();

        private void Sum()
        {
            // this.Result = calculatorController.Sum(this.Value1, this.Value2).ToString();
            this.Result = CalculatorControllerService!.Sum(this.Value1, this.Value2).ToString();
        }
    }
}
