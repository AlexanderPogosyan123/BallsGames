using BallsWinFormsLibrary;

namespace BallGameWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            ClearButton.Enabled = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            ClearButton.Enabled = false;
            moveBalls = new List<MoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var ball = new MoveBall(this);
                moveBalls.Add(ball);
                moveBalls[i].Start();
            }

            stopButton.Enabled = true;
            createButton.Enabled = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var ballsOnFormCount = 0;
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
            ClearButton.Enabled = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ballsCountLabel.Text =" ";

            if (moveBalls != null)
            {

                foreach (var ball in moveBalls)
                {
                    ball.Clear();
                }
                createButton.Enabled = true;
            }
        }
    }
}
