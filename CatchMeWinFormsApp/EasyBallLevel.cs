using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class EasyBallLevel : RandomSpeedAndDirectionBall
    {
        
        public EasyBallLevel(Form form) : base(form)
        {
            vx = SetRandomNumber();
            vy = SetRandomNumber();

        }
        protected override int SetRandomNumber()
        {
            return random.Next(-3, 3);
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
