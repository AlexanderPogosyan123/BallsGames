using BallGameWinFormsApp;

namespace CatchMeWinFormsApp
{
    internal class HardBallLevel : MoveBall
    {
        public HardBallLevel(Form form) : base(form)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
            
        }
        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 15)
            {
                size.Width = size.Height-=1;
            }
            Show();
        }
    }
}
