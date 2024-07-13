using BallGameWinFormsApp;

namespace CatchMeWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls;
        private int ballsCount = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var ball = new MoveBall(this);
                moveBalls.Add(ball);
                moveBalls[i].Start();
            }
            createButton.Enabled = false;

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
    }
}
