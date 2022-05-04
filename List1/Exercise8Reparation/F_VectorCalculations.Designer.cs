namespace Exercise8
{
    partial class F_VectorCalculations
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
            this.bt_MultiplyVectors = new System.Windows.Forms.Button();
            this.bt_CreateNewVector = new System.Windows.Forms.Button();
            this.bt_EvenNumbersCounter = new System.Windows.Forms.Button();
            this.bt_VectorInversor = new System.Windows.Forms.Button();
            this.bt_BiggestDifferenceBetweenElements = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_MultiplyVectors
            // 
            this.bt_MultiplyVectors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_MultiplyVectors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_MultiplyVectors.Location = new System.Drawing.Point(74, 44);
            this.bt_MultiplyVectors.Name = "bt_MultiplyVectors";
            this.bt_MultiplyVectors.Size = new System.Drawing.Size(143, 23);
            this.bt_MultiplyVectors.TabIndex = 0;
            this.bt_MultiplyVectors.Text = "Multiply Vectors";
            this.bt_MultiplyVectors.UseVisualStyleBackColor = false;
            this.bt_MultiplyVectors.Click += new System.EventHandler(this.bt_MultiplyVectors_Click);
            // 
            // bt_CreateNewVector
            // 
            this.bt_CreateNewVector.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_CreateNewVector.Location = new System.Drawing.Point(74, 73);
            this.bt_CreateNewVector.Name = "bt_CreateNewVector";
            this.bt_CreateNewVector.Size = new System.Drawing.Size(143, 23);
            this.bt_CreateNewVector.TabIndex = 1;
            this.bt_CreateNewVector.Text = "Create New Vector";
            this.bt_CreateNewVector.UseVisualStyleBackColor = false;
            this.bt_CreateNewVector.Click += new System.EventHandler(this.bt_CreateNewVector_Click);
            // 
            // bt_EvenNumbersCounter
            // 
            this.bt_EvenNumbersCounter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_EvenNumbersCounter.Location = new System.Drawing.Point(74, 102);
            this.bt_EvenNumbersCounter.Name = "bt_EvenNumbersCounter";
            this.bt_EvenNumbersCounter.Size = new System.Drawing.Size(143, 23);
            this.bt_EvenNumbersCounter.TabIndex = 2;
            this.bt_EvenNumbersCounter.Text = "Even Numbers Counter";
            this.bt_EvenNumbersCounter.UseVisualStyleBackColor = false;
            this.bt_EvenNumbersCounter.Click += new System.EventHandler(this.bt_EvenNumbersCounter_Click);
            // 
            // bt_VectorInversor
            // 
            this.bt_VectorInversor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_VectorInversor.Location = new System.Drawing.Point(74, 131);
            this.bt_VectorInversor.Name = "bt_VectorInversor";
            this.bt_VectorInversor.Size = new System.Drawing.Size(143, 23);
            this.bt_VectorInversor.TabIndex = 3;
            this.bt_VectorInversor.Text = "Vector Inversor";
            this.bt_VectorInversor.UseVisualStyleBackColor = false;
            this.bt_VectorInversor.Click += new System.EventHandler(this.bt_VectorInversor_Click);
            // 
            // bt_BiggestDifferenceBetweenElements
            // 
            this.bt_BiggestDifferenceBetweenElements.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_BiggestDifferenceBetweenElements.Location = new System.Drawing.Point(74, 160);
            this.bt_BiggestDifferenceBetweenElements.Name = "bt_BiggestDifferenceBetweenElements";
            this.bt_BiggestDifferenceBetweenElements.Size = new System.Drawing.Size(143, 23);
            this.bt_BiggestDifferenceBetweenElements.TabIndex = 4;
            this.bt_BiggestDifferenceBetweenElements.Text = "Biggest Difference";
            this.bt_BiggestDifferenceBetweenElements.UseVisualStyleBackColor = false;
            this.bt_BiggestDifferenceBetweenElements.Click += new System.EventHandler(this.bt_BiggestDifferenceBetweenElements_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(12, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 23);
            this.textBox1.TabIndex = 6;
            // 
            // F_VectorCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(302, 244);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_BiggestDifferenceBetweenElements);
            this.Controls.Add(this.bt_VectorInversor);
            this.Controls.Add(this.bt_EvenNumbersCounter);
            this.Controls.Add(this.bt_CreateNewVector);
            this.Controls.Add(this.bt_MultiplyVectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_VectorCalculations";
            this.Text = "Vector Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_MultiplyVectors;
        private Button bt_CreateNewVector;
        private Button bt_EvenNumbersCounter;
        private Button bt_VectorInversor;
        private Button bt_BiggestDifferenceBetweenElements;
        private TextBox textBox1;
    }
}