using Timer = System.Windows.Forms.Timer;

namespace BallsWinFormsLibrary
{
    public class MoveBall : RandomPointBall
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

        public bool Consists(int pointX, int pointY)
        {
            var radius = size.Width/2;
            var centerX = location.X + radius;
            var centerY = location.Y + radius;
            return (centerX - pointX)* (centerX - pointX) + (centerY - pointY)*(centerY - pointY) <=radius*radius;
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        protected virtual void ReduceBallSize()
        {
            
        }
    }
}
