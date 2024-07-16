namespace BallsWinFormsLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            this.form = form;
            size.Height = random.Next(50, 200);
            size.Width = size.Height;

        }

    }
}
