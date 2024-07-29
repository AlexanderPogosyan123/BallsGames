
namespace BallsWinFormsLibrary
{
    public class RandomColorBall : Ball
    {
        protected Random random = new Random();
        private Brush[] brushes = { Brushes.Brown, Brushes.Orange, Brushes.Gray, Brushes.Purple };

        public RandomColorBall(Form form) : base(form)
        {
            SetRandomColor();
        }

        private void SetRandomColor()
        {
             color = brushes[random.Next(brushes.Length)];
        }
    }
}
