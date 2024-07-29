using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class EasyBallLevel : RandomSpeedAndDirectionBall
    {
        
        public EasyBallLevel(Form form) : base(form)
        {
            SetRandomSpeed();
            SetRandomSpeed();

        }
        protected override void SetRandomSpeed()
        {
            vx = random.Next(-3, 3);
            vy = random.Next(-3, 3);
        }
        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 30)
            {
                size.Width = size.Height-=1;
            }
            Show();
        }
    }
}
