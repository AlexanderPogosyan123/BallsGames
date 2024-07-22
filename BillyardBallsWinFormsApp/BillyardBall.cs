
using BallsWinFormsLibrary;

namespace BillyardBallsWinFormsApp
{
    public class BillyardBall : RandomColorBall
    {
        public BillyardBall(Form form) : base(form)
        {

        }
        protected override void Go()
        {
            base.Go();
            // При достижении нижней границы
            if (centerY >= DownSide())
            {
                vy = -vy; // Изменяем направление по оси Y
            }

            // При достижении правой границы
            if (centerX >= RightSide())
            {
                vx = -vx; // Изменяем направление по оси X
            }

            // При достижении верхней границы
            if (centerY <= TopSide())
            {
                vy = -vy; // Изменяем направление по оси Y
            }

            // При достижении левой границы
            if (centerX <= LeftSide())
            {
                vx = -vx; // Изменяем направление по оси X
            }

        }
    }
}
