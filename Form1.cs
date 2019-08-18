using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//
namespace CarRace
{
    public partial class Form1 : Form
    {
        Car[] CarsArray = new Car[4];
        private Timer timer1;
        private IContainer components;
        int SandeepBet = 0;
        int SukhmanBet = 0;
        int GuriBet = 0;
        bool Bet = false;
        public string winningCar;
        decimal dbOddsAgainst;
        public decimal Test;       





        Player[] PlayerArray = new Player[3];
        private Label lblSandeep;
        private Label lblSukhman;
        private Label lblGuri;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private Label label1;
        Random Randomizer = new Random();
        // Bet Mybet = new Bet();


        public Form1()
        {
            InitializeComponent();

            //
            CarsArray[0] = new Car() { MyPictureBox = pictureBox1, Name = "Car #1", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox1.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1,3), oddsAgainst = Randomizer.Next(2,8) };
            CarsArray[1] = new Car() { MyPictureBox = pictureBox2, Name = "Car #2", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox2.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2,14) };
            CarsArray[2] = new Car() { MyPictureBox = pictureBox3, Name = "Car #3", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox3.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 12) };
            CarsArray[3] = new Car() { MyPictureBox = pictureBox4, Name = "Car #4", RaceTrackLength = racetrackPictureBox.Width - pictureBox1.Width, StartingPosition = pictureBox4.Left, Randomizer = Randomizer, oddsFor = Randomizer.Next(1, 3), oddsAgainst = Randomizer.Next(2, 10) };

            PlayerArray[0] = new Player() { MyBet = null, Name = "Sandeep", Cash = 50, MyLabel = lblSandeep, MyRadioButton = rdbtnSandeep, MyLabel2 = lblSandeepBet };
            PlayerArray[1] = new Player() { MyBet = null, Name = "Sukhman", Cash = 50, MyLabel = lblSukhman, MyRadioButton = rdbtnSukhman, MyLabel2 = lblSukhmanBet };
            PlayerArray[2] = new Player() { MyBet = null, Name = "Guri", Cash = 50, MyLabel = lblGuri, MyRadioButton = rdbtnGuri, MyLabel2 = lblGuriBet };

            PlayerArray[0].StatusUpdate();
            PlayerArray[1].StatusUpdate();
            PlayerArray[2].StatusUpdate();

         


        }

        private void btnRace_Click_1(object sender, EventArgs e)
        {

            CarsArray[0].TakeStartingPosition();
            CarsArray[1].TakeStartingPosition();
            CarsArray[2].TakeStartingPosition();
            CarsArray[3].TakeStartingPosition();
            SandeepBet = 0;
            SukhmanBet = 0;
            GuriBet = 0;
            btnRace.Enabled = false;
            timer1.Start();
          
        }

        private PictureBox racetrackPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rdbtnSandeep = new System.Windows.Forms.RadioButton();
            this.rdbtnSukhman = new System.Windows.Forms.RadioButton();
            this.rdbtnGuri = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSandeepBet = new System.Windows.Forms.Label();
            this.lblSukhmanBet = new System.Windows.Forms.Label();
            this.lblGuriBet = new System.Windows.Forms.Label();
            this.lblBetter = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSandeep = new System.Windows.Forms.Label();
            this.lblSukhman = new System.Windows.Forms.Label();
            this.lblGuri = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnSandeep
            //  this is the button for start the race
            this.rdbtnSandeep.AutoSize = true;
            this.rdbtnSandeep.Checked = true;
            this.rdbtnSandeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSandeep.Location = new System.Drawing.Point(33, 302);
            this.rdbtnSandeep.Name = "rdbtnSandeep";
            this.rdbtnSandeep.Size = new System.Drawing.Size(14, 13);
            this.rdbtnSandeep.TabIndex = 7;
            this.rdbtnSandeep.TabStop = true;
            this.rdbtnSandeep.UseVisualStyleBackColor = true;
            this.rdbtnSandeep.CheckedChanged += new System.EventHandler(this.rdbtnSandeep_CheckedChanged);
            // 
            // rdbtnSukhman
            
            this.rdbtnSukhman.AutoSize = true;
            this.rdbtnSukhman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSukhman.Location = new System.Drawing.Point(33, 326);
            this.rdbtnSukhman.Name = "rdbtnSukhman";
            this.rdbtnSukhman.Size = new System.Drawing.Size(14, 13);
            this.rdbtnSukhman.TabIndex = 8;
            this.rdbtnSukhman.UseVisualStyleBackColor = true;
            this.rdbtnSukhman.CheckedChanged += new System.EventHandler(this.rdbtnSukhman_CheckedChanged);
            // 
            // rdbtnGuri
            
            this.rdbtnGuri.AutoSize = true;
            this.rdbtnGuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnGuri.Location = new System.Drawing.Point(33, 349);
            this.rdbtnGuri.Name = "rdbtnGuri";
            this.rdbtnGuri.Size = new System.Drawing.Size(14, 13);
            this.rdbtnGuri.TabIndex = 9;
            this.rdbtnGuri.UseVisualStyleBackColor = true;
            this.rdbtnGuri.CheckedChanged += new System.EventHandler(this.rdbtnGuri_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // lblSandeepBet
            // this is the button for a punter which he can use to  place a bet
            this.lblSandeepBet.AutoSize = true;
            this.lblSandeepBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandeepBet.Location = new System.Drawing.Point(266, 304);
            this.lblSandeepBet.Name = "lblSandeepBet";
            this.lblSandeepBet.Size = new System.Drawing.Size(180, 16);
            this.lblSandeepBet.TabIndex = 11;
            this.lblSandeepBet.Text = "Sandeep hasn\'t placed a bet";
            // 
            // lblSukhmanBet
            //  this is the button for a punter which he can use to  place a bet
            this.lblSukhmanBet.AutoSize = true;
            this.lblSukhmanBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukhmanBet.Location = new System.Drawing.Point(266, 328);
            this.lblSukhmanBet.Name = "lblSukhmanBet";
            this.lblSukhmanBet.Size = new System.Drawing.Size(180, 16);
            this.lblSukhmanBet.TabIndex = 12;
            this.lblSukhmanBet.Text = "Sukhman hasn\'t placed a bet";
            // 
            // lblGuriBet
            // 
            this.lblGuriBet.AutoSize = true;
            this.lblGuriBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuriBet.Location = new System.Drawing.Point(266, 350);
            this.lblGuriBet.Name = "lblGuriBet";
            this.lblGuriBet.Size = new System.Drawing.Size(148, 16);
            this.lblGuriBet.TabIndex = 13;
            this.lblGuriBet.Text = "Guri hasn\'t placed a bet";
            // 
            // lblBetter
            // 
            this.lblBetter.AutoSize = true;
            this.lblBetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetter.Location = new System.Drawing.Point(12, 391);
            this.lblBetter.Name = "lblBetter";
            this.lblBetter.Size = new System.Drawing.Size(74, 20);
            this.lblBetter.TabIndex = 14;
            this.lblBetter.Text = "Sandeep";
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(107, 391);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 15;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "$";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.Red;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(451, 379);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(66, 44);
            this.btnRace.TabIndex = 18;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSandeep
            // 
            this.lblSandeep.AutoSize = true;
            this.lblSandeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandeep.Location = new System.Drawing.Point(51, 300);
            this.lblSandeep.Name = "lblSandeep";
            this.lblSandeep.Size = new System.Drawing.Size(0, 16);
            this.lblSandeep.TabIndex = 23;
            // 
            // lblSukhman
            // 
            this.lblSukhman.AutoSize = true;
            this.lblSukhman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSukhman.Location = new System.Drawing.Point(51, 324);
            this.lblSukhman.Name = "lblSukhman";
            this.lblSukhman.Size = new System.Drawing.Size(0, 16);
            this.lblSukhman.TabIndex = 24;
            // 
            // lblGuri
            // 
            this.lblGuri.AutoSize = true;
            this.lblGuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuri.Location = new System.Drawing.Point(51, 347);
            this.lblGuri.Name = "lblGuri";
            this.lblGuri.Size = new System.Drawing.Size(0, 16);
            this.lblGuri.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(229, 391);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "#1",
            "#2",
            "#3",
            "#4"});
            this.comboBox1.Location = new System.Drawing.Point(354, 391);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "#1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::CarRace.Properties.Resources.carimg;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(72, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 28);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CarRace.Properties.Resources.carimg;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(72, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 28);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CarRace.Properties.Resources.carimg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(72, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 28);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarRace.Properties.Resources.carimg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(72, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.BackgroundImage = global::CarRace.Properties.Resources.track;
            this.racetrackPictureBox.Location = new System.Drawing.Point(57, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(602, 205);
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "on";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(671, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblGuri);
            this.Controls.Add(this.lblSukhman);
            this.Controls.Add(this.lblSandeep);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lblBetter);
            this.Controls.Add(this.lblGuriBet);
            this.Controls.Add(this.lblSukhmanBet);
            this.Controls.Add(this.lblSandeepBet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbtnGuri);
            this.Controls.Add(this.rdbtnSukhman);
            this.Controls.Add(this.rdbtnSandeep);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "CarRace";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private RadioButton rdbtnSandeep;
        private RadioButton rdbtnSukhman;
        private RadioButton rdbtnGuri;
        private Label label3;
        private Label lblSandeepBet;
        private Label lblSukhmanBet;
        private Label lblGuriBet;
        private Label lblBetter;
        private Button btnBet;
        private Label label8;
        private Button btnRace;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < CarsArray.Length; i++)
            {

                CarsArray[i].Run();
                if (CarsArray[i].Run() == true)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show(CarsArray[i].Name + " IS THE WINNER!");
                    winningCar = CarsArray[i].Name;
                    i = CarsArray.Length;
                    btnRace.Enabled = true;
                    PlayerArray[0].Collect(winningCar);
                    PlayerArray[1].Collect(winningCar);
                    PlayerArray[2].Collect(winningCar);
                }

            }
        }

        private void rdbtnSandeep_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSandeep.Enabled)
                lblBetter.Text = "Sandeep";
        }

        private void rdbtnSukhman_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnSukhman.Enabled)
                lblBetter.Text = "Sukhman";
        }

        private void rdbtnGuri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnGuri.Enabled)
                lblBetter.Text = "Guri";
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "#1")
                Test = CarsArray[0].oddsAgainst / CarsArray[0].oddsFor;
            if (comboBox1.Text.ToString() == "#2")
                Test = CarsArray[1].oddsAgainst / CarsArray[1].oddsFor;
            if (comboBox1.Text.ToString() == "#3")
                Test = CarsArray[2].oddsAgainst / CarsArray[2].oddsFor;
            if (comboBox1.Text.ToString() == "#4")
                Test = CarsArray[3].oddsAgainst / CarsArray[3].oddsFor;

            if (lblBetter.Text == "Sandeep")
            {
                if (SandeepBet == 0)
                {

                    Bet = PlayerArray[0].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                    if (Bet == true)
                    {
                        SandeepBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Sandeep Has Already Placed a Bet");
                }
                             
            }
            if (lblBetter.Text == "Sukhman")
            {
                 if (SukhmanBet == 0)
                 {
                     Bet = PlayerArray[1].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                     if (Bet == true)
                     {
                         SukhmanBet = 1;
                     }
                 }
                 else
                 {
                     MessageBox.Show("Sukhman Has Already Placed a Bet");
                 }
               
            }
            if (lblBetter.Text == "Guri")
            {
                if (GuriBet == 0)
                {
                    Bet = PlayerArray[2].PlaceBet(Convert.ToInt16(numericUpDown2.Value), comboBox1.Text.ToString(), Test);
                    if (Bet == true)
                    {
                        GuriBet = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Guri Has Already Placed a Bet");
                }             

            }
        }

    }
}

      
    

