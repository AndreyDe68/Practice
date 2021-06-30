using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    class Circle : Figure
    {
        bool isStop = false;
        public event RailDelegate EventStopCircle;

        int dx = 1, dy = 0;
        public Circle()
        {
            EventStopCircle += Circle_EventStopCircle;
            brush = Brushes.Black;
            size = new Size(25, 25);
            position = new Point(20, Form1.centerVerticalPosition);
        }
        
        private void Circle_EventStopCircle()
        {
            dx = 0;
            dy = 0;
        }

        public override void Draw(Graphics context)
        {
            context.FillEllipse(brush, new Rectangle(position, size));
        }

        public override void Move()
        {
            position.X += dx;
            position.Y += dy;
            if (!isStop && position.X == Form1.centerHorizontalPosition + size.Width / 2 - 4)
            {
                EventStopCircle(); isStop = true;
            }
        }

        public override void GoTop()
        {
            dx = 0; 
            dy = -1;
        }

    }
}
