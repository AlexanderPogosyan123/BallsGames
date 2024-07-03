namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
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
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            PointBall pointBall = new PointBall(this, new Point(e.X, e.Y));
            pointBall.Show();
        }


    }
}
