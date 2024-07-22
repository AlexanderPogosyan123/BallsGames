namespace BallsWinFormsLibrary
{
    public class RandomPointBall : RandomColorBall
    {
        public RandomPointBall(Form form) : base(form)
        {
            this.form = form;
            SetRandomPoint();
        }

        private void SetRandomPoint()
        {
            var x = random.Next(LeftSide(), RightSide());
            var y = random.Next(TopSide(), DownSide());
            var point =  new Point(x, y);
            centerX = point.X;
            centerY = point.Y;
        }

    }

}
