namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
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
           
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            PointBall pointBall = new PointBall(this, new Point(e.X, e.Y));
            pointBall.Show();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {

        }

      
    }
}
