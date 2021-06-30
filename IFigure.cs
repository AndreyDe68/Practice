using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift
{
    interface IFigure
    {
        void Draw();
        void GoDown();
        void GoTop();
        void Move();
    }
}
