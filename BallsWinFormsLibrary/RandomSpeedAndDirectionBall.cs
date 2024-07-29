
namespace BallsWinFormsLibrary
{
    public class RandomSpeedAndDirectionBall : RandomPointBall
    {
        public RandomSpeedAndDirectionBall(Form form) : base(form)
        {
            SetRandomSpeed();
            SetRandomSpeed();
        }
        protected virtual void SetRandomSpeed()
        {
            vx =  random.Next(-5, 5);
            vy =  random.Next(-5, 5);
        }
    }
}
