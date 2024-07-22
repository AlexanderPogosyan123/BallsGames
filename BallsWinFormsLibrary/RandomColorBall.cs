
namespace BallsWinFormsLibrary
{
    public class RandomColorBall : Ball
    {
        protected Random random = new Random();
        private Brush[] brushes = { Brushes.Brown, Brushes.Orange, Brushes.Gray, Brushes.Purple };

        public RandomColorBall(Form form) : base(form)
        {
            color = SetRandomColor();
        }

        private Brush SetRandomColor()
        {
            var color = brushes[random.Next(brushes.Length)];
            return color;
        }
    }
}
