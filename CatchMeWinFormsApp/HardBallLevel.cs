using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class HardBallLevel : RandomSpeedAndDirectionBall
    {
        public HardBallLevel(Form form) : base(form)
        {
            vx = SetRandomNumber();
            vy = SetRandomNumber();

        }

        protected override int SetRandomNumber()
        {
            return random.Next(-15, 15);
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
