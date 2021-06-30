using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    class Lift : Figure
    {
        public event RailDelegate EventLiftGoTop;
        int dx = 0;
        int dy = 0;
        Pen pen;
        public Lift()
        {
            EventLiftGoTop += GoTop;
            size = new Size(40, 60);
            position = new Point(Form1.centerHorizontalPosition, 20);
            pen = new Pen(Color.Yellow, 3);
        }

        public override void Draw(Graphics context)
        {
            context.DrawRectangle(pen, new Rectangle(position, size));
        }

        public override void GoDown()
        {
            dx = 0;
            dy = 1;
        }
        public override void GoTop()
        {
            dx = 0; 
            dy = -1;
        }
        public override void Move()
        {
            position.X += dx;
            position.Y += dy;
            if (position.Y == Form1.centerVerticalPosition - size.Height / 2)
                EventLiftGoTop();
        }
    }
}
