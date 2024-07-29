namespace BillyardBallsWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                BillyardBall billyardBall = new BillyardBall(this);
                billyardBall.Start();
                billyardBall.OnHitted+=BillyardBall_OnHitted;
            }
        }

        private void BillyardBall_OnHitted(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Down:
                    DownSideLabel.Text = (Convert.ToInt32(DownSideLabel.Text)+1).ToString(); break;
                case Side.Top:
                    TopSideLabel.Text =  (Convert.ToInt32(TopSideLabel.Text)+1).ToString(); break;
                case Side.Right:
                    RightSideLabel.Text = (Convert.ToInt32(RightSideLabel.Text) + 1).ToString(); break;
                case Side.Left:
                    LeftSideLabel.Text = (Convert.ToInt32(LeftSideLabel.Text) + 1).ToString(); break;
                default:
                    break;
            }
        }
    }
}
