namespace ClassExamples
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSimpleCalc = new Button();
            label1 = new Label();
            alternativeCalculatorBtn = new Button();
            SuspendLayout();
            // 
            // btnSimpleCalc
            // 
            btnSimpleCalc.Location = new Point(79, 279);
            btnSimpleCalc.Name = "btnSimpleCalc";
            btnSimpleCalc.Size = new Size(187, 78);
            btnSimpleCalc.TabIndex = 0;
            btnSimpleCalc.Text = "Simple Calculator";
            btnSimpleCalc.UseVisualStyleBackColor = true;
            btnSimpleCalc.Click += BtnSimpleCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(301, 87);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 1;
            label1.Text = "Bievenido a nuestro Sistema";
            // 
            // alternativeCalculatorBtn
            // 
            alternativeCalculatorBtn.Location = new Point(322, 279);
            alternativeCalculatorBtn.Name = "alternativeCalculatorBtn";
            alternativeCalculatorBtn.Size = new Size(187, 78);
            alternativeCalculatorBtn.TabIndex = 2;
            alternativeCalculatorBtn.Text = "Alternative Calculator";
            alternativeCalculatorBtn.UseVisualStyleBackColor = true;
            alternativeCalculatorBtn.Click += AlternativeCalculatorBtn_Click;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 655);
            Controls.Add(alternativeCalculatorBtn);
            Controls.Add(label1);
            Controls.Add(btnSimpleCalc);
            Name = "PrincipalForm";
            Text = "PrincipalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpleCalc;
        private Label label1;
        private Button alternativeCalculatorBtn;
    }
}