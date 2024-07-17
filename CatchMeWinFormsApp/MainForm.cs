using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    public partial class mainForm : Form
    {

        private List<MoveBall> moveBalls;
        private StartForm startForm = new StartForm();
        private int ballsCount = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            startForm.ShowDialog();
            Color colorNum = startForm.ColorChoice;
            ChangeFormBackColor(colorNum);

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            Level levelChoice = startForm.LevelChoice;
            ÑreateBallsForLevelChoice(levelChoice);
            createButton.Enabled = false;

        }

        private void ÑreateBallsForLevelChoice(Level levelChoice)
        {
            int totalBalls = 8;
            switch (levelChoice)
            {
                case Level.easy:
                    {
                        for (int i = 0; i < totalBalls; i++)
                        {
                            var ball = new EasyBallLevel(this);
                            moveBalls.Add(ball);
                            moveBalls[i].Start();
                        }

                        break;
                    }

                case Level.medium:
                    {
                        for (int i = 0; i < totalBalls; i++)
                        {
                            var ball = new MediumBallLevel(this);
                            moveBalls.Add(ball);
                            moveBalls[i].Start();
                        }

                        break;
                    }

                case Level.hard:
                    {
                        for (int i = 0; i < totalBalls; i++)
                        {
                            var ball = new HardBallLevel(this);
                            moveBalls.Add(ball);
                            moveBalls[i].Start();
                        }

                        break;
                    }
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBalls != null)
            {

                foreach (var ball in moveBalls)
                {
                    if (ball.Consists(e.X, e.Y) && ball.IsMovable())
                    {
                        ball.Stop();
                        ballsCount++;
                    }
                }
                ballsCountLabel.Text = ballsCount.ToString();
                clearButton.Enabled = true;
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
                {
                    ball.Stop();
                    ball.Clear();
                }
                ballsCount = 0;
                ballsCountLabel.Text = ballsCount.ToString();
                createButton.Enabled =true;
            }
        }

        private void ChangeFormBackColor(Color colorNum)
        {
            switch (colorNum)
            {
                case Color.black:
                    base.BackColor = System.Drawing.Color.Black;
                    label2.ForeColor = System.Drawing.Color.White;
                    ballsCountLabel.ForeColor = System.Drawing.Color.White;
                    break;
                case Color.white:
                    base.BackColor = System.Drawing.Color.White;
                    break;
                case Color.red:
                    base.BackColor = System.Drawing.Color.Red;
                    break;
                case Color.blue:
                    base.BackColor = System.Drawing.Color.Blue;
                    break;
            }
        }
    }
}
