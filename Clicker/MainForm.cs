using static System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        //Стоковые переменные, часть будет меняться
        BigNumber clickPower = new BigNumber(1);
        BigNumber totalClicks = new BigNumber(0);


        public MainForm()
        {
            InitializeComponent();

            lblCount.Text = totalClicks.ToSuffix();

            LoadPowerUps();

            //таймер каждую секунду

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 мс = 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        //
        // Указание на кнопки
        //
        private void LoadPowerUps()
        {
            
        }



        //
        // Таймер
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            
        }



        //
        // Нажатие кнопки
        //
        private void btnClick_Click(object sender, EventArgs e)
        {
            totalClicks += clickPower;

            lblCount.Text = totalClicks.ToScientificRaw();
        }



        //
        // Разблокировка кнопок по количеству кликов
        //

        //
        // Действия на кнопках
        //

    }
}
