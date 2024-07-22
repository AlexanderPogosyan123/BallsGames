namespace BallsWinFormsLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            this.form = form;
            size = SetRandomSize();
        }

        private Size SetRandomSize()
        {
            var height = random.Next(50, 200);
            var width = height;//bug
           
            return new Size(width, height);
        }
    }
}
