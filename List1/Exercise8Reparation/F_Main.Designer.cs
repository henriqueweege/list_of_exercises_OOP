namespace Exercise8
{
    partial class F_Main
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
            this.bt_PrimalVector = new System.Windows.Forms.Button();
            this.lb_InsertPrimalVector = new System.Windows.Forms.Label();
            this.tb_PrimalVector = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_PrimalVector
            // 
            this.bt_PrimalVector.Location = new System.Drawing.Point(124, 127);
            this.bt_PrimalVector.Name = "bt_PrimalVector";
            this.bt_PrimalVector.Size = new System.Drawing.Size(75, 23);
            this.bt_PrimalVector.TabIndex = 0;
            this.bt_PrimalVector.Text = "Start";
            this.bt_PrimalVector.UseVisualStyleBackColor = true;
            this.bt_PrimalVector.Click += new System.EventHandler(this.bt_PrimalVector_Click);
            // 
            // lb_InsertPrimalVector
            // 
            this.lb_InsertPrimalVector.AutoSize = true;
            this.lb_InsertPrimalVector.Location = new System.Drawing.Point(19, 71);
            this.lb_InsertPrimalVector.Name = "lb_InsertPrimalVector";
            this.lb_InsertPrimalVector.Size = new System.Drawing.Size(289, 15);
            this.lb_InsertPrimalVector.TabIndex = 1;
            this.lb_InsertPrimalVector.Text = "Insert the primal vector. It must be comma separated.";
            // 
            // tb_PrimalVector
            // 
            this.tb_PrimalVector.Location = new System.Drawing.Point(64, 98);
            this.tb_PrimalVector.Name = "tb_PrimalVector";
            this.tb_PrimalVector.Size = new System.Drawing.Size(194, 23);
            this.tb_PrimalVector.TabIndex = 2;
            // 
            // F_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(320, 215);
            this.Controls.Add(this.tb_PrimalVector);
            this.Controls.Add(this.lb_InsertPrimalVector);
            this.Controls.Add(this.bt_PrimalVector);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Main";
            this.Text = "Vector Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_PrimalVector;
        private Label lb_InsertPrimalVector;
        private TextBox tb_PrimalVector;
    }
}