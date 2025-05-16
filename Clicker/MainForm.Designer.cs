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
            txtCount = new TextBox();
            btnBuyPower = new Button();
            btnBuyCPS = new Button();
            lblClickPower = new Label();
            lblCPS = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(561, 313);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(177, 54);
            btnClick.TabIndex = 1;
            btnClick.Text = "Click me >:)";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // txtCount
            // 
            txtCount.Enabled = false;
            txtCount.Location = new Point(561, 160);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(177, 33);
            txtCount.TabIndex = 2;
            txtCount.TextChanged += txtCount_TextChanged;
            // 
            // btnBuyPower
            // 
            btnBuyPower.Location = new Point(1016, 12);
            btnBuyPower.Name = "btnBuyPower";
            btnBuyPower.Size = new Size(284, 52);
            btnBuyPower.TabIndex = 3;
            btnBuyPower.Text = "+1 click power for 50 clicks";
            btnBuyPower.UseVisualStyleBackColor = true;
            btnBuyPower.Click += btnBuyPower_Click;
            // 
            // btnBuyCPS
            // 
            btnBuyCPS.Location = new Point(1016, 70);
            btnBuyCPS.Name = "btnBuyCPS";
            btnBuyCPS.Size = new Size(284, 52);
            btnBuyCPS.TabIndex = 4;
            btnBuyCPS.Text = "+1 cps/s power for 100 clicks";
            btnBuyCPS.UseVisualStyleBackColor = true;
            btnBuyCPS.Click += btnBuyCPS_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 639);
            Controls.Add(lblCPS);
            Controls.Add(lblClickPower);
            Controls.Add(btnBuyCPS);
            Controls.Add(btnBuyPower);
            Controls.Add(txtCount);
            Controls.Add(btnClick);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClick;
        private TextBox txtCount;
        private Button btnBuyPower;
        private Button btnBuyCPS;
        private Label lblClickPower;
        private Label lblCPS;
    }
}
