namespace BillyardBallsWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BillyardBall billyardBall = new BillyardBall(this);
            billyardBall.Start();
        }
    }
}
