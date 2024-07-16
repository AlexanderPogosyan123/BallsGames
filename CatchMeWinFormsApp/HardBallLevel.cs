using BallGameWinFormsApp;

namespace CatchMeWinFormsApp
{
    internal class HardBallLevel : MoveBall
    {
        public HardBallLevel(Form form) : base(form)
        {
            vx = random.Next(-15, 15);
            vy = random.Next(-15, 15);
        }
    }
}
