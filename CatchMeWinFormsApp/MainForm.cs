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
            string color = startForm.Color;
            ChangeFormBackColor(color);

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            string levelChoice = startForm.LevelChoice;
            —reateBallsForLevelChoice(levelChoice);
            createButton.Enabled = false;

        }

        private void —reateBallsForLevelChoice(string levelChoice)
        {
            switch (levelChoice)
            {
                case "ÀÂ„ÍËÈ":
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            var ball = new EasyBallLevel(this);
                            moveBalls.Add(ball);
                            moveBalls[i].Start();
                        }

                        break;
                    }

                case "—Â‰ÌËÈ":
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            var ball = new MediumBallLevel(this);
                            moveBalls.Add(ball);
                            moveBalls[i].Start();
                        }

                        break;
                    }

                case "—ÎÓÊÌ˚È":
                    {
                        for (int i = 0; i < 10; i++)
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

        private void clearButton_Click(object sender, EventArgs e)
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

        private void ChangeFormBackColor(string color)
        {
            if (string.Equals(color, "˜ÂÌ˚È", StringComparison.OrdinalIgnoreCase))
            {
                BackColor = Color.Black;
                label2.ForeColor = Color.White;
                ballsCountLabel.ForeColor = Color.White;
            }
            else if (string.Equals(color, "·ÂÎ˚È", StringComparison.OrdinalIgnoreCase))
            {
                BackColor = Color.White;
            }
            else if (string.Equals(color, "Í‡ÒÌ˚È", StringComparison.OrdinalIgnoreCase))
            {
                BackColor = Color.Red;
            }
            else if (string.Equals(color, "ÒËÌËÈ", StringComparison.OrdinalIgnoreCase))
            {
                BackColor = Color.Blue;
            }
        }
    }
}
