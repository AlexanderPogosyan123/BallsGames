namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls;
        private int ballsOnFormCount;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;

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

            stopButton.Enabled = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < moveBalls.Count; i++)
            {
                moveBalls[i].Stop();
                if (moveBalls[i].OnForm())
                {
                    ballsOnFormCount++;
                }
            }

          ballsCountLabel.Text =ballsOnFormCount+" ";
            stopButton.Enabled = false;

        }
    }
}
