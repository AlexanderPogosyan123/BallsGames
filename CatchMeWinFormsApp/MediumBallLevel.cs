using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class MediumBallLevel : RandomSpeedAndDirectionBall
    {
        public MediumBallLevel(Form form) : base(form)
        {
            vx = SetRandomNumber();
            vy = SetRandomNumber();
        }

        protected override int SetRandomNumber()
        {
            return random.Next(-5, 5);
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
