using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    class Figure : IFigure
    {
        protected Point position;
        protected Size size;
        protected Brush brush;

        public delegate void RailDelegate();

        public virtual void Draw(Graphics context)
        {
            throw new NotImplementedException();
        }

        public virtual void GoDown()
        {
            throw new NotImplementedException();
        }

        public virtual void GoTop()
        {
            throw new NotImplementedException();
        }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
