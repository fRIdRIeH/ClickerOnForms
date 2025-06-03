using static System.Windows.Forms.Timer;

namespace Clicker
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer timer;

        //Стоковые переменные, часть будет меняться
        BigNumber clickPower = new BigNumber(1);
        BigNumber totalClicks = new BigNumber(0);

        int buyedMoueses = 0;
        int buyedSchoolars = 0;
        int buyedIndianBoys = 0;
        int buyedCallCentres = 0;
        int buyedGaymers = 0;
        int buyedCyberSportsman = 0;
        int buyedCyberTeams = 0;
        int buyedKoreaHackers = 0;

        //Базовый cps
        BigNumber OneSecPower = new BigNumber(0);

        //Базовые цены
        BigNumber basePriceForMouse = new BigNumber(50);
        BigNumber basePriceForSchoolar = new BigNumber(100);
        BigNumber basePriceForIndianBoy = new BigNumber(1600);
        BigNumber basePriceForCallCenter = new BigNumber(12800);
        BigNumber basePriceForGaymer = new BigNumber(204800);
        BigNumber basePriceForCyberSportman = new BigNumber(1638400);
        BigNumber basePriceForCyberTeam = new BigNumber(13107200);
        BigNumber basePriceForKoreaHackers = new BigNumber(104857600);

        public MainForm()
        {
            InitializeComponent();

            txtCount.Text = totalClicks.ToSuffix();

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
            btnMouseUpgrade.Enabled = false;
            btnMouseUpgrade.Text = $"Улучшить мышку за {basePriceForMouse} кликов";

            btnBuySchoolar.Enabled = false;
            btnBuySchoolar.Text = $"Купить школьника за {basePriceForSchoolar} кликов";

            btnBuyIndianBoy.Enabled = false;
            btnBuyIndianBoy.Text = $"Купить индуса за {basePriceForIndianBoy} кликов";

            btnBuyCallCenter.Enabled = false;
            btnBuyCallCenter.Text = $"Купить колл-центр за {basePriceForCallCenter} кликов";

            btnBuyGaymer.Enabled = false;
            btnBuyGaymer.Text = $"Купить геймера за {basePriceForGaymer}";

            btnBuyCyberSportman.Enabled = false;
            btnBuyCyberSportman.Text = $"Купить киберспортсмена за {basePriceForCyberSportman} кликов";

            btnBuyCyberTeam.Enabled = false;
            btnBuyCyberTeam.Text = $"Купить киберспорт команду за {basePriceForCyberTeam} кликов";

            btnBuyKoreaHackers.Enabled = false;
            btnBuyKoreaHackers.Text = $"Купить корейских хакеров за {basePriceForKoreaHackers} кликов";
        }



        //
        // Таймер
        //
        private void Timer_Tick(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                //txtCount.Text = (number + OneSecPower).ToString();
            }
        }



        //
        // Нажатие кнопки
        //
        private void btnClick_Click(object sender, EventArgs e)
        {
            totalClicks += clickPower;

            txtCount.Text = totalClicks.ToSuffix();
        }



        //
        // Разблокировка кнопок по количеству кликов
        //
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (new BigNumber(int.Parse(txtCount.Text)) > basePriceForMouse)
            {
                btnMouseUpgrade.Enabled = true;
            }
            //if (int.Parse(txtCount.Text) > basePriceForSchoolar)
            //{
            //    btnBuySchoolar.Enabled = true;
            //}
        }



        //
        // Действия на кнопках
        //
        //
        //



        private void btnBuyPower_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                //if (number >= basePriceForMouse)
                //{
                //    //вычитаем из кликов
                //    txtCount.Text = (number - basePriceForMouse).ToString();

                //    //прибавляем к нашему нажатию 1
                //    click += 1;

                //    lblClickPower.Text = $"Click power = {click}";

                //    //прибавляем к переменной 1
                //    buyedMoueses += 1;

                //    lblClicksBuyed.Text = $"Куплено: {buyedMoueses}";

                //    //изменяем цену
                //    basePriceForMouse += (int)(basePriceForMouse * 0.3 * buyedMoueses);

                //    //изменяем текст кнопки с новой ценой
                //    btnMouseUpgrade.Text = $"+1 click power for {basePriceForMouse} clicks";
                //}
                //else
                //{
                //    return;
                //}
            }
        }

        private void btnBuySchoolar_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCount.Text, out number))
            {
                //if (number >= basePriceForSchoolar)
                //{
                //    txtCount.Text = (number - basePriceForSchoolar).ToString();

                //    OneSecPower += 1;

                //    lblCPS.Text = $"CPS = {OneSecPower}";

                //    buyedSchoolars += 1;

                //    lblCPSbuyed.Text = $"Куплено: {buyedSchoolars}";

                //    basePriceForSchoolar += (int)(basePriceForSchoolar * 0.3 * buyedSchoolars);

                //    btnBuySchoolar.Text = $"+1 click power for {basePriceForSchoolar} clicks";
                //}
                //else
                //{
                //    return;
                //}
            }
        }
    }
}
