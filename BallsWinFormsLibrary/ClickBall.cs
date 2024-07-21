
namespace BallsWinFormsLibrary
{
    //Класс нарушает принцип LSP
    public class ClickBall:Ball
    {
        private int pointX; private int pointY;

        public ClickBall(Form form,int x, int y):base(form)
        {
            pointX = x - radius;
            pointY = y - radius;
        }

        protected override void Draw(Brush brush)
        {
            //создал массив возможных цветов
            //рандомно генерю цвет исходя из массива цветов
            var graphics = form.CreateGraphics();
            //прямоугольник создается для площади где будет рисоваться шар
            Rectangle rectangle = new Rectangle(pointX, pointY, size.Width, size.Height);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
