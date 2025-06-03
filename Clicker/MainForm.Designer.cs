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
            btnMouseUpgrade = new Button();
            btnBuySchoolar = new Button();
            lblClickPower = new Label();
            lblCPS = new Label();
            lblClicksBuyed = new Label();
            lblCPSbuyed = new Label();
            btnBuyIndianBoy = new Button();
            label1 = new Label();
            label2 = new Label();
            btnBuyCallCenter = new Button();
            label3 = new Label();
            btnBuyGaymer = new Button();
            label4 = new Label();
            btnBuyCyberSportman = new Button();
            btnBuyKoreaHackers = new Button();
            btnBuyCyberTeam = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(811, 546);
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
            txtCount.Location = new Point(744, 412);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(331, 33);
            txtCount.TabIndex = 2;
            txtCount.TextAlign = HorizontalAlignment.Right;
            txtCount.TextChanged += txtCount_TextChanged;
            // 
            // btnMouseUpgrade
            // 
            btnMouseUpgrade.Location = new Point(1497, 25);
            btnMouseUpgrade.Name = "btnMouseUpgrade";
            btnMouseUpgrade.Size = new Size(395, 52);
            btnMouseUpgrade.TabIndex = 3;
            btnMouseUpgrade.Text = "Улучшить мышку";
            btnMouseUpgrade.UseVisualStyleBackColor = true;
            btnMouseUpgrade.Click += btnBuyPower_Click;
            // 
            // btnBuySchoolar
            // 
            btnBuySchoolar.Location = new Point(1497, 108);
            btnBuySchoolar.Name = "btnBuySchoolar";
            btnBuySchoolar.Size = new Size(395, 52);
            btnBuySchoolar.TabIndex = 4;
            btnBuySchoolar.Text = "Купить школьника";
            btnBuySchoolar.UseVisualStyleBackColor = true;
            btnBuySchoolar.Click += btnBuySchoolar_Click;
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
            // lblClicksBuyed
            // 
            lblClicksBuyed.AutoSize = true;
            lblClicksBuyed.Location = new Point(1497, 80);
            lblClicksBuyed.Name = "lblClicksBuyed";
            lblClicksBuyed.Size = new Size(97, 25);
            lblClicksBuyed.TabIndex = 7;
            lblClicksBuyed.Text = "Куплено: ";
            // 
            // lblCPSbuyed
            // 
            lblCPSbuyed.AutoSize = true;
            lblCPSbuyed.Location = new Point(1497, 163);
            lblCPSbuyed.Name = "lblCPSbuyed";
            lblCPSbuyed.Size = new Size(97, 25);
            lblCPSbuyed.TabIndex = 8;
            lblCPSbuyed.Text = "Куплено: ";
            // 
            // btnBuyIndianBoy
            // 
            btnBuyIndianBoy.Location = new Point(1497, 191);
            btnBuyIndianBoy.Name = "btnBuyIndianBoy";
            btnBuyIndianBoy.Size = new Size(395, 52);
            btnBuyIndianBoy.TabIndex = 9;
            btnBuyIndianBoy.Text = "Купить индуса";
            btnBuyIndianBoy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1497, 246);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "Куплено: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1497, 329);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 12;
            label2.Text = "Куплено: ";
            // 
            // btnBuyCallCenter
            // 
            btnBuyCallCenter.Location = new Point(1497, 274);
            btnBuyCallCenter.Name = "btnBuyCallCenter";
            btnBuyCallCenter.Size = new Size(395, 52);
            btnBuyCallCenter.TabIndex = 11;
            btnBuyCallCenter.Text = "Купить колл-центр";
            btnBuyCallCenter.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1497, 412);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 14;
            label3.Text = "Куплено: ";
            // 
            // btnBuyGaymer
            // 
            btnBuyGaymer.Location = new Point(1497, 357);
            btnBuyGaymer.Name = "btnBuyGaymer";
            btnBuyGaymer.Size = new Size(395, 52);
            btnBuyGaymer.TabIndex = 13;
            btnBuyGaymer.Text = "Купить геймера";
            btnBuyGaymer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1497, 495);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 16;
            label4.Text = "Куплено: ";
            // 
            // btnBuyCyberSportman
            // 
            btnBuyCyberSportman.Location = new Point(1497, 440);
            btnBuyCyberSportman.Name = "btnBuyCyberSportman";
            btnBuyCyberSportman.Size = new Size(395, 52);
            btnBuyCyberSportman.TabIndex = 15;
            btnBuyCyberSportman.Text = "Купить киберспортсмена";
            btnBuyCyberSportman.UseVisualStyleBackColor = true;
            // 
            // btnBuyKoreaHackers
            // 
            btnBuyKoreaHackers.Location = new Point(1497, 606);
            btnBuyKoreaHackers.Name = "btnBuyKoreaHackers";
            btnBuyKoreaHackers.Size = new Size(395, 52);
            btnBuyKoreaHackers.TabIndex = 18;
            btnBuyKoreaHackers.Text = "Купить хакеров из Кореи";
            btnBuyKoreaHackers.UseVisualStyleBackColor = true;
            // 
            // btnBuyCyberTeam
            // 
            btnBuyCyberTeam.Location = new Point(1497, 523);
            btnBuyCyberTeam.Name = "btnBuyCyberTeam";
            btnBuyCyberTeam.Size = new Size(395, 52);
            btnBuyCyberTeam.TabIndex = 17;
            btnBuyCyberTeam.Text = "Купить киберспорт команду";
            btnBuyCyberTeam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1497, 578);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 19;
            label5.Text = "Куплено: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1497, 661);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 20;
            label6.Text = "Куплено: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnBuyKoreaHackers);
            Controls.Add(btnBuyCyberTeam);
            Controls.Add(label4);
            Controls.Add(btnBuyCyberSportman);
            Controls.Add(label3);
            Controls.Add(btnBuyGaymer);
            Controls.Add(label2);
            Controls.Add(btnBuyCallCenter);
            Controls.Add(label1);
            Controls.Add(btnBuyIndianBoy);
            Controls.Add(lblCPSbuyed);
            Controls.Add(lblClicksBuyed);
            Controls.Add(lblCPS);
            Controls.Add(lblClickPower);
            Controls.Add(btnBuySchoolar);
            Controls.Add(btnMouseUpgrade);
            Controls.Add(txtCount);
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
        private Button btnMouseUpgrade;
        private Button btnBuySchoolar;
        private Label lblClickPower;
        private Label lblCPS;
        private Label lblClicksBuyed;
        private Label lblCPSbuyed;
        private Button btnBuyIndianBoy;
        private Label label1;
        private Label label2;
        private Button btnBuyCallCenter;
        private Label label3;
        private Button btnBuyGaymer;
        private Label label4;
        private Button btnBuyCyberSportman;
        private Button btnBuyKoreaHackers;
        private Button btnBuyCyberTeam;
        private Label label5;
        private Label label6;
    }
}
