using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class HardBallLevel : MoveBall
    {
        public HardBallLevel(Form form) : base(form)
        {
            vx = random.Next(-15, 15);
            vy = random.Next(-15, 15);

        }
        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 15)
            {
                base.ReduceBallSize();
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
