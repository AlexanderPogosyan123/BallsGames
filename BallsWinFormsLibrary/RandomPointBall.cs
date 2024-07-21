namespace BallsWinFormsLibrary
{
    public class RandomPointBall : Ball
    {
        protected Random random = new Random();
        public RandomPointBall(Form form) : base(form)
        {
            this.form = form;
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }

}
