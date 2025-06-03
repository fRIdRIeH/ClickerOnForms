using static System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        //�������� ����������, ����� ����� ��������
        BigNumber clickPower = new BigNumber(0.1);
        BigNumber totalClicks = new BigNumber(0);
        BigNumber timePower = new BigNumber(0);


        public MainForm()
        {
            InitializeComponent();

            lblCount.Text = totalClicks.ToSuffix();

            LoadPowerUps();

            //������ ������ �������

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 �� = 1 �������
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        //
        // �������� �� ������
        //
        private void LoadPowerUps()
        {

        }



        //
        // ������
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            totalClicks += timePower;
            lblCount.Text = totalClicks.ToSmartString();
        }



        //
        // ������� ������
        //
        private void btnClick_Click(object sender, EventArgs e)
        {
            totalClicks += clickPower;

            lblCount.Text = totalClicks.ToSmartString();
        }

        //
        // ������������� ������ �� ���������� ������
        //

        //
        // �������� �� �������
        //

    }
}
