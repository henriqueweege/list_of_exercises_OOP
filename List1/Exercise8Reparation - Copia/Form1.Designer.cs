namespace Exercise8Reparation
{
    partial class F_Main
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
            this.lb_InsertPrimalVector = new System.Windows.Forms.Label();
            this.tb_InsertPrimalVector = new System.Windows.Forms.TextBox();
            this.btn_StartApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_InsertPrimalVector
            // 
            this.lb_InsertPrimalVector.AutoSize = true;
            this.lb_InsertPrimalVector.Location = new System.Drawing.Point(12, 87);
            this.lb_InsertPrimalVector.Name = "lb_InsertPrimalVector";
            this.lb_InsertPrimalVector.Size = new System.Drawing.Size(351, 15);
            this.lb_InsertPrimalVector.TabIndex = 0;
            this.lb_InsertPrimalVector.Text = "Insert the primal vector. The numbers must be comma separated.";
            // 
            // tb_InsertPrimalVector
            // 
            this.tb_InsertPrimalVector.Location = new System.Drawing.Point(12, 105);
            this.tb_InsertPrimalVector.Name = "tb_InsertPrimalVector";
            this.tb_InsertPrimalVector.Size = new System.Drawing.Size(351, 23);
            this.tb_InsertPrimalVector.TabIndex = 1;
            // 
            // btn_StartApp
            // 
            this.btn_StartApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StartApp.Location = new System.Drawing.Point(152, 134);
            this.btn_StartApp.Name = "btn_StartApp";
            this.btn_StartApp.Size = new System.Drawing.Size(75, 23);
            this.btn_StartApp.TabIndex = 2;
            this.btn_StartApp.Text = "Start";
            this.btn_StartApp.UseVisualStyleBackColor = true;
            this.btn_StartApp.Click += new System.EventHandler(this.btn_StartApp_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(374, 232);
            this.Controls.Add(this.btn_StartApp);
            this.Controls.Add(this.tb_InsertPrimalVector);
            this.Controls.Add(this.lb_InsertPrimalVector);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "F_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_InsertPrimalVector;
        private TextBox tb_InsertPrimalVector;
        private Button btn_StartApp;
    }
}