using Timer = System.Windows.Forms.Timer;

namespace BallsWinFormsLibrary
{
    public class Ball
    {
        private Timer timer;
        //Это уже другой объект, нам нужен именно наш объект формочки чтобы на ней нарисовать шар(из-за этого мы передаем его в конструкторе)
        protected Form form;
        protected int centerX = 100;
        protected int centerY = 100;
        protected int radius = 25;
        protected Size size;
        protected Brush color = Brushes.Red;
        protected int vx = 5;
        protected int vy = 5;
        public Ball(Form form)
        {
            this.form = form;
            size = new Size(radius*2, radius*2);
            InitializingTimer();
        }

        

        public void Start()
        {
            timer.Enabled = true;
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Show()
        {
            Draw(color);
        }

        public void Clear()
        {
            color = new SolidBrush(form.BackColor);
            Draw(color);
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public int LeftSide()
        {
            return radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerY >= TopSide() && centerX <= RightSide() && centerY <= DownSide();
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

        protected virtual void ReduceBallSize()
        {

        }


        protected virtual void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            Rectangle rectangle = new Rectangle(centerX - radius, centerY -radius, size.Width, size.Height);
            graphics.FillEllipse(brush, rectangle);
        }

        private void InitializingTimer()
        {
            timer = new Timer();
            timer.Interval = 5;
            timer.Tick+=Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Move();
        }

        private void Go()
         {
            centerX += vx;
            centerY += vy;
        }


    }
}
