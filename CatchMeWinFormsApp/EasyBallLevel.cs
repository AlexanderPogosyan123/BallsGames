using BallGameWinFormsApp;

namespace CatchMeWinFormsApp
{
    internal class EasyBallLevel : MoveBall
    {
        public EasyBallLevel(Form form) : base(form)
        {
            vx = random.Next(-3, 3);
            vy = random.Next(-3, 3);
        }
    }
}
