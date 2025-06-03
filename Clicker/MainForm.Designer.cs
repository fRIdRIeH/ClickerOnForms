namespace Clicker
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
            btnClick = new Button();
            lblClickPower = new Label();
            lblCPS = new Label();
            lblCount = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(722, 644);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(177, 54);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click me >:)";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // lblClickPower
            // 
            lblClickPower.AutoSize = true;
            lblClickPower.Location = new Point(12, 12);
            lblClickPower.Name = "lblClickPower";
            lblClickPower.Size = new Size(142, 25);
            lblClickPower.TabIndex = 5;
            lblClickPower.Text = "Click power = 1";
            // 
            // lblCPS
            // 
            lblCPS.AutoSize = true;
            lblCPS.Location = new Point(12, 39);
            lblCPS.Name = "lblCPS";
            lblCPS.Size = new Size(79, 25);
            lblCPS.TabIndex = 6;
            lblCPS.Text = "CPS = 0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(777, 427);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(61, 25);
            lblCount.TabIndex = 7;
            lblCount.Text = "label1";
            lblCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblCount);
            Controls.Add(lblCPS);
            Controls.Add(lblClickPower);
            Controls.Add(btnClick);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClick;
        private TextBox txtCount;
        private Label lblClickPower;
        private Label lblCPS;
        private Label lblCount;
    }
}
