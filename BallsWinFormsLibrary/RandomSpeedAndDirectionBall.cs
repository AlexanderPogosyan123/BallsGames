
namespace BallsWinFormsLibrary
{
    public class RandomSpeedAndDirectionBall : RandomPointBall
    {
        public RandomSpeedAndDirectionBall(Form form) : base(form)
        {
            vx = SetRandomNumber();
            vy = SetRandomNumber();
        }
        private int SetRandomNumber()
        {
            return random.Next(-5, 5);
        }
    }
}
