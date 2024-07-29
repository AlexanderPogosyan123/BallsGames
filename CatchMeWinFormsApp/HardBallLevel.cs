using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class HardBallLevel : RandomSpeedAndDirectionBall
    {
        public HardBallLevel(Form form) : base(form)
        {
            SetRandomSpeed();
            SetRandomSpeed();
        }

        protected override void SetRandomSpeed()
        {
            vx = random.Next(-15, 15);
            vy = random.Next(-15, 15);
        }

        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 15)
            {
                size.Width = size.Height-=1;
            }
            RandomPositionMoving();
            Show();
        }

        private void RandomPositionMoving()
        {
            vy = random.Next(-10, 10);
        }
    }
}
