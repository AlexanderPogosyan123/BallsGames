
using BallsWinFormsLibrary;

namespace BillyardBallsWinFormsApp
{
    public class BillyardBall : RandomSpeedAndDirectionBall
    {
        public event EventHandler<HitEventArgs> OnHitted;
        public BillyardBall(MainForm form) : base(form)
        {
            this.form = form;

        }
        protected override void Go()
        {
            base.Go();
            // При достижении нижней границы
            if (centerY >= DownSide())
            {
                vy = -vy; // Изменяем направление по оси Y
                OnHitted.Invoke(this, new HitEventArgs(Side.Down));
            }

            // При достижении правой границы
            if (centerX >= RightSide())
            {
                vx = -vx; // Изменяем направление по оси X
                OnHitted.Invoke(this, new HitEventArgs(Side.Right));

            }

            // При достижении верхней границы
            if (centerY <= TopSide())
            {
                vy = -vy; // Изменяем направление по оси Y
                OnHitted.Invoke(this, new HitEventArgs(Side.Top));

            }

            // При достижении левой границы
            if (centerX <= LeftSide())
            {
                vx = -vx; // Изменяем направление по оси X
                OnHitted.Invoke(this, new HitEventArgs(Side.Left));

            }

        }
    }
}
