

using Timer = System.Windows.Forms.Timer;

namespace BallGameWinFormsApp
{
    internal class MoveBall : RandomPointBall
    {
        private Timer timer;
        public MoveBall(MainForm form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick+=Timer_Tick;
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
       
    }
}
