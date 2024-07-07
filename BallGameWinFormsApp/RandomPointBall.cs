using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGameWinFormsApp
{
    public class RandomPointBall:Ball
    {
        protected Random random = new Random();
        public RandomPointBall(Form form):base(form)
        {
            this.form = form;
            var x = random.Next(0, form.ClientSize.Width);
            var y = random.Next(0, form.ClientSize.Height);
            location = new Point(x, y);
        }
    }

}
