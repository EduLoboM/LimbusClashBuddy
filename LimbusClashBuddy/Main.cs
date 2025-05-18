using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using FormsTimer = System.Windows.Forms.Timer;

namespace LimbusClashBuddy
{
    public partial class Main : Form
    {
        private static Random rnd = new Random();

        class Particle
        {
            public float X, Y;
            public float VX, VY;
            public int Life;
        }

        private List<Particle> particles = new List<Particle>();
        private FormsTimer particleTimer;

        public Main()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer |
                          ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint,
                          true);
            this.UpdateStyles();

            particleTimer = new FormsTimer { Interval = 30 };
            particleTimer.Tick += ParticleTimer_Tick;
            particleTimer.Start();
        }

        // Simulation methods
        public static int Binomial(int n, double p)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
                if (rnd.NextDouble() < p)
                    count++;
            return count;
        }

        public static string RoundSimulation(int BPAlly, int BPEnemy, int CNAlly, int CNEnemy,
                                             int CPAlly, int CPEnemy, double CHAlly, double CHEnemy)
        {
            int succAlly = Binomial(CNAlly, CHAlly);
            int succEnemy = Binomial(CNEnemy, CHEnemy);
            int PWAlly = BPAlly + CPAlly * succAlly;
            int PWEnemy = BPEnemy + CPEnemy * succEnemy;
            if (PWAlly > PWEnemy) return "Ally";
            if (PWEnemy > PWAlly) return "Enemy";
            return "Tie";
        }

        public static double MonteCarloFinalSimulation(int SMNumbers, int BPAlly, int BPEnemy,
                                                       int CNAlly, int CNEnemy,
                                                       int CPAlly, int CPEnemy,
                                                       double CHAlly, double CHEnemy)
        {
            int WNAlly = 0, WNEnemy = 0;
            for (int i = 0; i < SMNumbers; i++)
            {
                int CNSMAlly = CNAlly;
                int CNSMEnemy = CNEnemy;
                while (CNSMAlly > 0 && CNSMEnemy > 0)
                {
                    string result = RoundSimulation(BPAlly, BPEnemy, CNSMAlly, CNSMEnemy,
                                                    CPAlly, CPEnemy, CHAlly, CHEnemy);
                    if (result == "Ally") CNSMEnemy--;
                    else if (result == "Enemy") CNSMAlly--;
                }
                if (CNSMEnemy == 0) WNAlly++;
                else if (CNSMAlly == 0) WNEnemy++;
            }
            return (double)WNAlly / SMNumbers;
        }

        private void ParticleTimer_Tick(object sender, EventArgs e)
        {
            UpdateParticles();
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var p in particles)
            {
                using (var brush = new SolidBrush(Color.FromArgb(200, Color.DarkRed)))
                {
                    e.Graphics.FillEllipse(brush, p.X, p.Y, 5, 5);
                }
            }
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

                double allyWinChance = MonteCarloFinalSimulation(SMNumbers,
                                        BPAlly, BPEnemy, CNAlly, CNEnemy,
                                        CPAlly, CPEnemy, CHAlly, CHEnemy) * 100.0;

                VictoryChance.Text = $"Victory Chance: {allyWinChance:F2}%";

                if (allyWinChance >= 50)
                {
                    using (var ms = new MemoryStream(Properties.Resources.AllyWinning))
                        Ally.Image = Image.FromStream(ms);
                    using (var ms = new MemoryStream(Properties.Resources.EnemyLosing))
                        Enemy.Image = Image.FromStream(ms);

                    ExplodeParticles(Enemy.Location.X + Enemy.Width / 2f,
                                     Enemy.Location.Y + Enemy.Height / 2f);
                }
                else
                {
                    using (var ms = new MemoryStream(Properties.Resources.AllyLosing))
                        Ally.Image = Image.FromStream(ms);
                    using (var ms = new MemoryStream(Properties.Resources.EnemyWinning))
                        Enemy.Image = Image.FromStream(ms);

                    ExplodeParticles(Ally.Location.X + Ally.Width / 2f,
                                     Ally.Location.Y + Ally.Height / 2f);
                }
            }
            catch (Exception ex)
            {
                VictoryChance.Text = "Error: " + ex.Message;
            }
        }

        private void ExplodeParticles(float centerX, float centerY)
        {
            for (int i = 0; i < 150; i++)
            {
                particles.Add(new Particle
                {
                    X = centerX,
                    Y = centerY,
                    VX = (float)(rnd.NextDouble() * 4 - 2),
                    VY = (float)(rnd.NextDouble() * -4),
                    Life = rnd.Next(20, 40)
                });
            }
        }

        private void UpdateParticles()
        {
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                var p = particles[i];
                p.X += p.VX;
                p.Y += p.VY;
                p.VY += 0.2f;
                if (--p.Life <= 0)
                    particles.RemoveAt(i);
            }
        }

        private void AllySanity_TextChanged(object sender, EventArgs e) { }
    }
}
