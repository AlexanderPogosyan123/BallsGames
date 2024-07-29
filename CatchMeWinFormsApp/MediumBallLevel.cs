using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class MediumBallLevel : RandomSpeedAndDirectionBall
    {
        public MediumBallLevel(Form form) : base(form)
        {
            SetRandomSpeed();
            SetRandomSpeed();
        }

        protected override void SetRandomSpeed()
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }
        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 20)
            {
                size.Width = size.Height-=1;
            }
            Show();
        }
    }
}
