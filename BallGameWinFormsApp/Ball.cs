using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGameWinFormsApp
{
    public class Ball
    {
        //Это уже другой объект, нам нужен именно наш объект формочки чтобы на ней нарисовать шар(из-за этого мы передаем его в конструкторе)
        protected MainForm form;
        //установка значений по умолчанию
        protected Point location = new Point(100, 100);
        private Random random = new Random();

        protected Size size = new Size(50, 50);
        private Brush[] brushes = { Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Black };

        private Brush brush;
        private Brush color;
        protected int vx = 10;
        protected int vy = 10;
        public Ball(MainForm form)
        {
            this.form = form;
            brush = brushes[random.Next(brushes.Length)];
            color = brush;
        }

        public void Show()
        {
            //создал массив возможных цветов
            //рандомно генерю цвет исходя из массива цветов
            var graphics = form.CreateGraphics();
            //прямоугольник создается для площади где будет рисоваться шар
            Rectangle rectangle = new Rectangle(location, size);
            graphics.FillEllipse(color, rectangle);
        }

        private void Go()
        {
            location.X+=vx;
            location.Y+=vy;
        }
        private void Clear()
        {
            brush = Brushes.WhiteSmoke;
            //рандомно генерю цвет исходя из массива цветов
            var graphics = form.CreateGraphics();
            //прямоугольник создается для площади где будет рисоваться шар
            Rectangle rectangle = new Rectangle(location, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool OnForm()
        {
            return location.X > 0 && location.Y > 0 && location.X < form.ClientSize.Width - size.Width && location.Y < form.ClientSize.Height - size.Height;
        }
    }
}
