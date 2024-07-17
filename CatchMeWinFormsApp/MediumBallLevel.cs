﻿using BallsWinFormsLibrary;

namespace CatchMeWinFormsApp
{
    internal class MediumBallLevel : MoveBall
    {
        public MediumBallLevel(Form form) : base(form)
        {
            vx = random.Next(-5, 5);
            vy = random.Next(-5, 5);
        }
        protected override void ReduceBallSize()
        {
            Clear();
            if (size.Width != 20)
            {
               base.ReduceBallSize();
            }
            Show();
        }
    }
}
