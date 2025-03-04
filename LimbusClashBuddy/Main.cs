using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace LimbusClashBuddy
{
    public partial class Main : Form
    {
        private static Random rnd = new Random();

        public Main()
        {
            InitializeComponent();
        }

        public static int Binomial(int n, double p)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (rnd.NextDouble() < p)
                    count++;
            }
            return count;
        }

        public static string RoundSimulation(int BPAlly, int BPEnemy, int CNAlly, int CNEnemy, int CPAlly, int CPEnemy, double CHAlly, double CHEnemy)
        {
            int successesAlly = Binomial(CNAlly, CHAlly);
            int successesEnemy = Binomial(CNEnemy, CHEnemy);

            int PWAlly = BPAlly + CPAlly * successesAlly;
            int PWEnemy = BPEnemy + CPEnemy * successesEnemy;

            if (PWAlly > PWEnemy)
                return "Ally";
            else if (PWEnemy > PWAlly)
                return "Enemy";
            else
                return "Tie";
        }

        public static double MonteCarloFinalSimulation(int SMNumbers, int BPAlly, int BPEnemy, int CNAlly, int CNEnemy, int CPAlly, int CPEnemy, double CHAlly, double CHEnemy)
        {
            int WNAlly = 0;
            int WNEnemy = 0;

            for (int i = 0; i < SMNumbers; i++)
            {
                int CNSMAlly = CNAlly;
                int CNSMEnemy = CNEnemy;

                while (CNSMAlly > 0 && CNSMEnemy > 0)
                {
                    string result = RoundSimulation(BPAlly, BPEnemy, CNSMAlly, CNSMEnemy, CPAlly, CPEnemy, CHAlly, CHEnemy);

                    if (result == "Ally")
                        CNSMEnemy--;
                    else if (result == "Enemy")
                        CNSMAlly--;
                }

                if (CNSMEnemy == 0)
                    WNAlly++;
                else if (CNSMAlly == 0)
                    WNEnemy++;
            }

            return (double)WNAlly / SMNumbers;
        }

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int BPAlly = Convert.ToInt32(AllyClashPower.Text);
                int CNAlly = Convert.ToInt32(AllyCoinNumber.Text);
                int CPAlly = Convert.ToInt32(AllyCoinPower.Text);
                int SNAlly = Convert.ToInt32(AllySanity.Text);
                int BPEnemy = Convert.ToInt32(EnemyClashPower.Text);
                int CNEnemy = Convert.ToInt32(EnemyCoinNumber.Text);
                int CPEnemy = Convert.ToInt32(EnemyCoinPower.Text);
                int SNEnemy = Convert.ToInt32(EnemySanity.Text);
                int SMNumbers = Convert.ToInt32(SimulationNumbers.Text);

                double CHAlly = 0.5 + (SNAlly / 100.0);
                double CHEnemy = 0.5 + (SNEnemy / 100.0);

                double allyWinChance = MonteCarloFinalSimulation(SMNumbers, BPAlly, BPEnemy, CNAlly, CNEnemy, CPAlly, CPEnemy, CHAlly, CHEnemy);
                allyWinChance *= 100;

                VictoryChance.Text = "Victory Chance: " + allyWinChance.ToString("F2") + "%";

                if (allyWinChance >= 50)
                {
                    using (var ms = new MemoryStream(Properties.Resources.AllyWinning))
                    {
                        Ally.Image = Image.FromStream(ms);
                    }

                    using (var ms = new MemoryStream(Properties.Resources.EnemyLosing))
                    {
                        Enemy.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    using (var ms = new MemoryStream(Properties.Resources.AllyLosing))
                    {
                        Ally.Image = Image.FromStream(ms);
                    }

                    using (var ms = new MemoryStream(Properties.Resources.EnemyWinning))
                    {
                        Enemy.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                VictoryChance.Text = "Error: " + ex.Message;
            }
        }

        private void AllySanity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
