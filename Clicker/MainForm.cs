using static System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        //�������� ����������, ����� ����� ��������
        int click = 1;

        int buyedPower = 0;
        int buyedCPSPower = 0;

        int buyedOneSecondPower = 0;

        int basePriceForBuyPower = 50;
        int basePriceForCPSPower = 100;

        public MainForm()
        {
            InitializeComponent();

            txtCount.Text = (0).ToString();

            btnBuyPower.Enabled = false;
            btnBuyPower.Text = $"+1 click power for {basePriceForBuyPower} clicks";

            btnBuyCPS.Enabled = false;
            btnBuyCPS.Text = $"+1 cps power for {basePriceForCPSPower} clicks";

            //������ ������ �������

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 �� = 1 �������
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                txtCount.Text = (number + buyedOneSecondPower).ToString();
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                txtCount.Text = (number + click).ToString();
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtCount.Text) > basePriceForBuyPower)
            {
                btnBuyPower.Enabled = true;
            }
            if (int.Parse(txtCount.Text) > basePriceForCPSPower)
            {
                btnBuyCPS.Enabled = true;
            }
        }

        private void btnBuyPower_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                if (number >= basePriceForBuyPower)
                {
                    //�������� �� ������
                    txtCount.Text = (number - basePriceForBuyPower).ToString();

                    //���������� � ������ ������� 1
                    click += 1;

                    lblClickPower.Text = $"Click power = {click}";

                    //���������� � ���������� 1
                    buyedPower += 1;

                    lblClicksBuyed.Text = $"�������: {buyedPower}";

                    //�������� ����
                    basePriceForBuyPower += (int)(basePriceForBuyPower * 0.3 * buyedPower);

                    //�������� ����� ������ � ����� �����
                    btnBuyPower.Text = $"+1 click power for {basePriceForBuyPower} clicks";
                }
                else
                {
                    return;
                }
            }
        }

        private void btnBuyCPS_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                if (number >= basePriceForCPSPower)
                {
                    txtCount.Text = (number - basePriceForCPSPower).ToString();

                    buyedOneSecondPower += 1;

                    lblCPS.Text = $"CPS = {buyedOneSecondPower}";

                    buyedCPSPower += 1;

                    lblCPSbuyed.Text = $"�������: {buyedCPSPower}";

                    basePriceForCPSPower += (int)(basePriceForCPSPower * 0.3 * buyedCPSPower);

                    btnBuyCPS.Text = $"+1 click power for {basePriceForCPSPower} clicks";
                }
                else
                {
                    return;
                }
            }
        }
    }
}
