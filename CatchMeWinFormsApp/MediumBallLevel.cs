using BallGameWinFormsApp;

namespace CatchMeWinFormsApp
{
    internal class MediumBallLevel : MoveBall
    {
        public MediumBallLevel(Form form) : base(form)
        {
            vx = random.Next(-6, -6);
            vy = random.Next(-6, -6);
        }
    }
}
