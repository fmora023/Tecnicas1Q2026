namespace ClassExamples
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            sumButton = new Button();
            minusButton = new Button();
            multButton = new Button();
            resultLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 98);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 3;
            // 
            // sumButton
            // 
            sumButton.Location = new Point(69, 188);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(166, 48);
            sumButton.TabIndex = 4;
            sumButton.Text = "Sum";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButton_Click;
            sumButton.Click += newEvent;
            // 
            // minusButton
            // 
            minusButton.Location = new Point(69, 254);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(166, 48);
            minusButton.TabIndex = 5;
            minusButton.Text = "Minus";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multButton
            // 
            multButton.Location = new Point(69, 323);
            multButton.Name = "multButton";
            multButton.Size = new Size(166, 48);
            multButton.TabIndex = 6;
            multButton.Text = "Mult";
            multButton.UseVisualStyleBackColor = true;
            multButton.Click += multButton_Click;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(418, 47);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(49, 20);
            resultLbl.TabIndex = 4;
            resultLbl.Text = "Result";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLbl);
            Controls.Add(multButton);
            Controls.Add(minusButton);
            Controls.Add(sumButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button sumButton;
        private Button minusButton;
        private Button multButton;
        private Label resultLbl;
    }
}
