namespace LimbusClashBuddy
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            VictoryChance = new Label();
            SimulateButton = new Button();
            EnemyClashPower = new TextBox();
            AllyClashPower = new TextBox();
            EnemyCoinNumber = new TextBox();
            AllyCoinNumber = new TextBox();
            AllyCoinPower = new TextBox();
            AllySanity = new TextBox();
            EnemyCoinPower = new TextBox();
            EnemySanity = new TextBox();
            SimulationNumbers = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            Ally = new PictureBox();
            Enemy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Ally).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy).BeginInit();
            SuspendLayout();
            // 
            // VictoryChance
            // 
            VictoryChance.AutoSize = true;
            VictoryChance.BackColor = SystemColors.Control;
            VictoryChance.BorderStyle = BorderStyle.Fixed3D;
            VictoryChance.FlatStyle = FlatStyle.Flat;
            VictoryChance.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VictoryChance.ForeColor = SystemColors.ActiveCaptionText;
            VictoryChance.Location = new Point(383, 212);
            VictoryChance.Name = "VictoryChance";
            VictoryChance.Size = new Size(434, 40);
            VictoryChance.TabIndex = 0;
            VictoryChance.Text = "Victory Chance: 0,00%";
            // 
            // SimulateButton
            // 
            SimulateButton.BackColor = SystemColors.Control;
            SimulateButton.BackgroundImageLayout = ImageLayout.None;
            SimulateButton.Cursor = Cursors.Hand;
            SimulateButton.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SimulateButton.ForeColor = SystemColors.ControlText;
            SimulateButton.Location = new Point(548, 270);
            SimulateButton.Name = "SimulateButton";
            SimulateButton.Size = new Size(104, 39);
            SimulateButton.TabIndex = 1;
            SimulateButton.Text = "CLASH!";
            SimulateButton.UseVisualStyleBackColor = false;
            SimulateButton.Click += SimulateButton_Click;
            // 
            // EnemyClashPower
            // 
            EnemyClashPower.Font = new Font("Arial", 24F);
            EnemyClashPower.Location = new Point(1030, 78);
            EnemyClashPower.Name = "EnemyClashPower";
            EnemyClashPower.Size = new Size(120, 44);
            EnemyClashPower.TabIndex = 2;
            // 
            // AllyClashPower
            // 
            AllyClashPower.Font = new Font("Arial", 24F);
            AllyClashPower.Location = new Point(50, 78);
            AllyClashPower.Name = "AllyClashPower";
            AllyClashPower.Size = new Size(120, 44);
            AllyClashPower.TabIndex = 3;
            // 
            // EnemyCoinNumber
            // 
            EnemyCoinNumber.Font = new Font("Arial", 24F);
            EnemyCoinNumber.Location = new Point(1030, 159);
            EnemyCoinNumber.Name = "EnemyCoinNumber";
            EnemyCoinNumber.Size = new Size(120, 44);
            EnemyCoinNumber.TabIndex = 4;
            // 
            // AllyCoinNumber
            // 
            AllyCoinNumber.Font = new Font("Arial", 24F);
            AllyCoinNumber.Location = new Point(50, 159);
            AllyCoinNumber.Name = "AllyCoinNumber";
            AllyCoinNumber.Size = new Size(120, 44);
            AllyCoinNumber.TabIndex = 5;
            // 
            // AllyCoinPower
            // 
            AllyCoinPower.Font = new Font("Arial", 24F);
            AllyCoinPower.Location = new Point(50, 238);
            AllyCoinPower.Name = "AllyCoinPower";
            AllyCoinPower.Size = new Size(120, 44);
            AllyCoinPower.TabIndex = 6;
            // 
            // AllySanity
            // 
            AllySanity.Font = new Font("Arial", 24F);
            AllySanity.Location = new Point(50, 317);
            AllySanity.Name = "AllySanity";
            AllySanity.Size = new Size(120, 44);
            AllySanity.TabIndex = 7;
            AllySanity.TextChanged += AllySanity_TextChanged;
            // 
            // EnemyCoinPower
            // 
            EnemyCoinPower.Font = new Font("Arial", 24F);
            EnemyCoinPower.Location = new Point(1030, 238);
            EnemyCoinPower.Name = "EnemyCoinPower";
            EnemyCoinPower.Size = new Size(120, 44);
            EnemyCoinPower.TabIndex = 8;
            // 
            // EnemySanity
            // 
            EnemySanity.Font = new Font("Arial", 24F);
            EnemySanity.Location = new Point(1030, 317);
            EnemySanity.Name = "EnemySanity";
            EnemySanity.Size = new Size(120, 44);
            EnemySanity.TabIndex = 9;
            // 
            // SimulationNumbers
            // 
            SimulationNumbers.Font = new Font("Arial", 24F);
            SimulationNumbers.Location = new Point(510, 367);
            SimulationNumbers.Name = "SimulationNumbers";
            SimulationNumbers.Size = new Size(180, 44);
            SimulationNumbers.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Arial", 9F);
            textBox1.Location = new Point(50, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 21);
            textBox1.TabIndex = 11;
            textBox1.Text = "Ally Clash Power";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Font = new Font("Arial", 9F);
            textBox2.Location = new Point(50, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 21);
            textBox2.TabIndex = 12;
            textBox2.Text = "Ally Nº of Coins";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("Arial", 9F);
            textBox3.Location = new Point(50, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 21);
            textBox3.TabIndex = 13;
            textBox3.Text = "Ally Coin Power";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Font = new Font("Arial", 9F);
            textBox4.Location = new Point(50, 288);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 21);
            textBox4.TabIndex = 14;
            textBox4.Text = "Ally Sanity";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Font = new Font("Arial", 9F);
            textBox5.Location = new Point(1030, 49);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 21);
            textBox5.TabIndex = 15;
            textBox5.Text = "Enemy Clash Power";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.Font = new Font("Arial", 9F);
            textBox6.Location = new Point(1030, 130);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 21);
            textBox6.TabIndex = 16;
            textBox6.Text = "Enemy Nº of Coins";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.Font = new Font("Arial", 9F);
            textBox7.Location = new Point(1030, 209);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(120, 21);
            textBox7.TabIndex = 17;
            textBox7.Text = "Enemy Coin Power";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Control;
            textBox8.Font = new Font("Arial", 9F);
            textBox8.Location = new Point(1030, 288);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(120, 21);
            textBox8.TabIndex = 18;
            textBox8.Text = "Enemy Sanity";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            textBox9.BackColor = SystemColors.Control;
            textBox9.Location = new Point(510, 338);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(180, 23);
            textBox9.TabIndex = 19;
            textBox9.Text = "Number of Simulations (10k+)";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // Ally
            // 
            Ally.BackColor = Color.Transparent;
            Ally.Image = Properties.Resources.Ally;
            Ally.Location = new Point(210, 270);
            Ally.Name = "Ally";
            Ally.Size = new Size(250, 250);
            Ally.TabIndex = 20;
            Ally.TabStop = false;
            // 
            // Enemy
            // 
            Enemy.BackColor = Color.Transparent;
            Enemy.Image = Properties.Resources.Enemy;
            Enemy.Location = new Point(740, 270);
            Enemy.Name = "Enemy";
            Enemy.Size = new Size(250, 250);
            Enemy.TabIndex = 21;
            Enemy.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1184, 561);
            Controls.Add(Enemy);
            Controls.Add(Ally);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SimulationNumbers);
            Controls.Add(EnemySanity);
            Controls.Add(EnemyCoinPower);
            Controls.Add(AllySanity);
            Controls.Add(AllyCoinPower);
            Controls.Add(AllyCoinNumber);
            Controls.Add(EnemyCoinNumber);
            Controls.Add(AllyClashPower);
            Controls.Add(EnemyClashPower);
            Controls.Add(SimulateButton);
            Controls.Add(VictoryChance);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1200, 600);
            MinimumSize = new Size(1200, 600);
            Name = "Main";
            Text = "[LCB] Limbus Clash Buddy";
            ((System.ComponentModel.ISupportInitialize)Ally).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VictoryChance;
        private Button SimulateButton;
        private TextBox EnemyClashPower;
        private TextBox AllyClashPower;
        private TextBox EnemyCoinNumber;
        private TextBox AllyCoinNumber;
        private TextBox AllyCoinPower;
        private TextBox AllySanity;
        private TextBox EnemyCoinPower;
        private TextBox EnemySanity;
        private TextBox SimulationNumbers;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private PictureBox Ally;
        private PictureBox Enemy;
    }
}
