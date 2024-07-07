using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGameWinFormsApp
{
    public class RandomSizeAndPointBall:RandomPointBall
    {
        public RandomSizeAndPointBall(Form form):base(form)
        {
            this.form = form;
            size.Height = random.Next(50, 200);
            size.Width = size.Height;

        }

    }
}
