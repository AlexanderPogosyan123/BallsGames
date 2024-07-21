namespace BallsWinFormsLibrary
{
        public class Ball
        {
            private Random random = new Random();
            private Brush[] brushes = { Brushes.Brown, Brushes.Orange, Brushes.Gray, Brushes.Purple };

            private Brush brush;
            private Brush color;
            //Это уже другой объект, нам нужен именно наш объект формочки чтобы на ней нарисовать шар(из-за этого мы передаем его в конструкторе)
            protected Form form;
            //установка значений по умолчанию
            protected int centerX = 100;
            protected int centerY = 100;
            protected int radius = 25;
            protected Size size;
            protected int vx = 5;
            protected int vy = 5;
            public Ball(Form form)
            {
                size = new Size(radius*2, radius*2);
                this.form = form;
                brush = brushes[random.Next(brushes.Length)];
                color = brush;
            }

            public void Show()
            {
                Draw(color);
            }

            public void Clear()
            {
                brush = new SolidBrush(form.BackColor);
                Draw(brush);
            }

           //границы реализованы относительно центра окружности
            public int LeftSide()
            {
                return radius;
            }
            public int TopSide()
            {
                return radius;
            }
            public int RightSide()
            {
                return form.ClientSize.Width - radius;
            }
            public int DownSide()
            {
                return form.ClientSize.Height - radius;
            }

            public bool OnForm()
            {
                return centerX >= LeftSide() && centerY >= TopSide() && centerX <= RightSide() && centerY <= DownSide();
            }

            protected virtual void Draw(Brush brush)
            {
                //создал массив возможных цветов
                //рандомно генерю цвет исходя из массива цветов
                var graphics = form.CreateGraphics();
                //прямоугольник создается для площади где будет рисоваться шар
                Rectangle rectangle = new Rectangle(centerX - radius, centerY -radius, size.Width, size.Height);
                graphics.FillEllipse(brush, rectangle);
            }
        }
}
