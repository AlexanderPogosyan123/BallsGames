using Timer = System.Windows.Forms.Timer;

namespace BallsWinFormsLibrary
{
    public abstract class MoveBall : RandomPointBall
    {
        private Timer timer;
        public MoveBall(Form form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 1;
            timer.Tick+=Timer_Tick;
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ReduceBallSize();
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

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public bool Exists(int pointX, int pointY)
        {
            return (centerX - pointX)* (centerX - pointX) + (centerY - pointY)*(centerY - pointY) <=radius*radius;
        }

        protected void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected abstract void ReduceBallSize();

        private void Go()
        {
            centerX += vx;
            centerY += vy;
        }
    }
}
