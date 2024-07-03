namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
       List< RandomSizeAndPointBall> balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Ball ball = new Ball(this);
            ball.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            balls = new List<RandomSizeAndPointBall>();
            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomSizeAndPointBall(this);
                ball.Show();
                balls.Add(ball);
            }
            timer.Start();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            PointBall pointBall = new PointBall(this, new Point(e.X, e.Y));
            pointBall.Show();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                balls[i].Move();
            }
        }
    }
}
