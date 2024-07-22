namespace BallsWinFormsLibrary
{
    public class RandomPointBall : RandomColorBall
    {
        public RandomPointBall(Form form) : base(form)
        {
            this.form = form;
            centerX = SetRandomPoint().X;
            centerY = SetRandomPoint().Y;
        }

        private Point SetRandomPoint()
        {
            var x = random.Next(LeftSide(), RightSide());
            var y = random.Next(TopSide(), DownSide());
            return new Point(x, y);
        }

    }

}
