using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGameWinFormsApp
{
    public class PointBall:Ball
    {
        public PointBall(Form form,Point pointLocation):base(form)
        {
           location = pointLocation;
        }



    }
}
