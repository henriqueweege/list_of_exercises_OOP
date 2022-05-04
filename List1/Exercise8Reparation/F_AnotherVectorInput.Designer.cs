namespace Exercise8
{
    partial class F_AnotherVectorInput
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
            this.bt_AnotherVector = new System.Windows.Forms.Button();
            this.tb_AnotherVector = new System.Windows.Forms.TextBox();
            this.lb_AnotherVector = new System.Windows.Forms.Label();
            this.lb_AnotherVectorCountinuation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_AnotherVector
            // 
            this.bt_AnotherVector.Location = new System.Drawing.Point(152, 132);
            this.bt_AnotherVector.Name = "bt_AnotherVector";
            this.bt_AnotherVector.Size = new System.Drawing.Size(75, 23);
            this.bt_AnotherVector.TabIndex = 0;
            this.bt_AnotherVector.Text = "Send";
            this.bt_AnotherVector.UseVisualStyleBackColor = true;
            this.bt_AnotherVector.Click += new System.EventHandler(this.bt_AnotherVector_Click);
            // 
            // tb_AnotherVector
            // 
            this.tb_AnotherVector.Location = new System.Drawing.Point(87, 103);
            this.tb_AnotherVector.Name = "tb_AnotherVector";
            this.tb_AnotherVector.Size = new System.Drawing.Size(194, 23);
            this.tb_AnotherVector.TabIndex = 1;
            // 
            // lb_AnotherVector
            // 
            this.lb_AnotherVector.AutoSize = true;
            this.lb_AnotherVector.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_AnotherVector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_AnotherVector.Location = new System.Drawing.Point(32, 57);
            this.lb_AnotherVector.Name = "lb_AnotherVector";
            this.lb_AnotherVector.Size = new System.Drawing.Size(327, 15);
            this.lb_AnotherVector.TabIndex = 2;
            this.lb_AnotherVector.Text = "This function demands another vector, please insert it below.";
            this.lb_AnotherVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_AnotherVectorCountinuation
            // 
            this.lb_AnotherVectorCountinuation.AutoSize = true;
            this.lb_AnotherVectorCountinuation.ForeColor = System.Drawing.Color.Red;
            this.lb_AnotherVectorCountinuation.Location = new System.Drawing.Point(106, 85);
            this.lb_AnotherVectorCountinuation.Name = "lb_AnotherVectorCountinuation";
            this.lb_AnotherVectorCountinuation.Size = new System.Drawing.Size(161, 15);
            this.lb_AnotherVectorCountinuation.TabIndex = 3;
            this.lb_AnotherVectorCountinuation.Text = "It must be comma separated.";
            // 
            // F_AnotherVectorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(393, 201);
            this.Controls.Add(this.lb_AnotherVectorCountinuation);
            this.Controls.Add(this.lb_AnotherVector);
            this.Controls.Add(this.tb_AnotherVector);
            this.Controls.Add(this.bt_AnotherVector);
            this.Name = "F_AnotherVectorInput";
            this.Text = "Vector Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_AnotherVector;
        private TextBox tb_AnotherVector;
        private Label lb_AnotherVector;
        private Label lb_AnotherVectorCountinuation;
    }
}