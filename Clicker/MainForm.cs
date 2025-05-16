using static System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        //�������� ����������, ����� ����� ��������
        int click = 1;

        int buyedMoueses = 0;
        int buyedSchoolars = 0;
        int buyedIndianBoys = 0;
        int buyedCallCentres = 0;
        int buyedGaymers = 0;
        int buyedCyberSportsman = 0;
        int buyedCyberTeams = 0;
        int buyedKoreaHackers = 0;

        //������� cps
        int OneSecPower = 0;

        //������� ����
        int basePriceForMouse = 50;
        int basePriceForSchoolar = 100;
        int basePriceForIndianBoy = 1600;
        int basePriceForCallCenter = 12800;
        int basePriceForGaymer = 204800;
        int basePriceForCyberSportman = 1638400;
        int basePriceForCyberTeam = 13107200;
        int basePriceForKoreaHackers = 104857600;

        public MainForm()
        {
            InitializeComponent();

            txtCount.Text = (0).ToString();

            btnMouseUpgrade.Enabled = false;
            btnMouseUpgrade.Text = $"�������� ����� �� {basePriceForMouse} ������";

            btnBuySchoolar.Enabled = false;
            btnBuySchoolar.Text = $"������ ��������� �� {basePriceForSchoolar} ������";

            btnBuyIndianBoy.Enabled = false;
            btnBuyIndianBoy.Text = $"������ ������ �� {basePriceForIndianBoy} ������";

            btnBuyCallCenter.Enabled = false;
            btnBuyCallCenter.Text = $"������ ����-����� �� {basePriceForCallCenter} ������";

            btnBuyGaymer.Enabled = false;
            btnBuyGaymer.Text = $"������ ������� �� {basePriceForGaymer}";

            btnBuyCyberSportman.Enabled = false;
            btnBuyCyberSportman.Text = $"������ ��������������� �� {basePriceForCyberSportman} ������";

            btnBuyCyberTeam.Enabled = false;
            btnBuyCyberTeam.Text = $"������ ���������� ������� �� {basePriceForCyberTeam} ������";

            btnBuyKoreaHackers.Enabled = false;
            btnBuyKoreaHackers.Text = $"������ ��������� ������� �� {basePriceForKoreaHackers} ������";

            //������ ������ �������

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 �� = 1 �������
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        //
        // ������
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                txtCount.Text = (number + OneSecPower).ToString();
            }
        }



        //
        // ������� ������
        //
        private void btnClick_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                txtCount.Text = (number + click).ToString();
            }
        }



        //
        // ������������� ������ �� ���������� ������
        //
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtCount.Text) > basePriceForMouse)
            {
                btnMouseUpgrade.Enabled = true;
            }
            if (int.Parse(txtCount.Text) > basePriceForSchoolar)
            {
                btnBuySchoolar.Enabled = true;
            }
        }



        //
        // �������� �� �������
        //
        //
        //



        private void btnBuyPower_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                if (number >= basePriceForMouse)
                {
                    //�������� �� ������
                    txtCount.Text = (number - basePriceForMouse).ToString();

                    //���������� � ������ ������� 1
                    click += 1;

                    lblClickPower.Text = $"Click power = {click}";

                    //���������� � ���������� 1
                    buyedMoueses += 1;

                    lblClicksBuyed.Text = $"�������: {buyedMoueses}";

                    //�������� ����
                    basePriceForMouse += (int)(basePriceForMouse * 0.3 * buyedMoueses);

                    //�������� ����� ������ � ����� �����
                    btnMouseUpgrade.Text = $"+1 click power for {basePriceForMouse} clicks";
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
                if (number >= basePriceForSchoolar)
                {
                    txtCount.Text = (number - basePriceForSchoolar).ToString();

                    OneSecPower += 1;

                    lblCPS.Text = $"CPS = {OneSecPower}";

                    buyedSchoolars += 1;

                    lblCPSbuyed.Text = $"�������: {buyedSchoolars}";

                    basePriceForSchoolar += (int)(basePriceForSchoolar * 0.3 * buyedSchoolars);

                    btnBuySchoolar.Text = $"+1 click power for {basePriceForSchoolar} clicks";
                }
                else
                {
                    return;
                }
            }
        }
    }
}
