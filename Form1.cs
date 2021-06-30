using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Form1 : Form
    {
        public static int centerVerticalPosition = 0; 
        public static int centerHorizontalPosition = 0;

        MainMenu mainMenu;
        MenuItem btn1, btn2, btn3, aboutInfo;
        Lift lift;
        Circle circle;

        public Form1()
        {
            InitializeComponent();
            centerHorizontalPosition = ClientSize.Width / 2;
            centerVerticalPosition = ClientSize.Height / 2;
            btn1 = new MenuItem("Старт", new EventHandler(timer1_Tick));
            btn2 = new MenuItem("Стоп", new EventHandler(Timer_Stop));
            btn3 = new MenuItem("Заново", new EventHandler(Restart));
            aboutInfo = new MenuItem("Доп. информация", new EventHandler(About));
            mainMenu = new MainMenu(new MenuItem[] { btn1, btn2, btn3, aboutInfo} );
            Menu = mainMenu;
            lift = new Lift();
            circle = new Circle();
            circle.EventStopCircle += lift.GoDown;
            lift.EventLiftGoTop += circle.GoTop;
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lift.Move();
            circle.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            circle.Draw(graphics);
            lift.Draw(graphics); 
        }

        public void Timer_Stop (object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        public void Restart(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lift = new Lift();
            circle = new Circle();
            circle.EventStopCircle += lift.GoDown;
            lift.EventLiftGoTop += circle.GoTop;
        }
        public void About(object sender, EventArgs e)
        {
            MessageBox.Show("Павлов Андрей", "Инфа о разработчике");
        }
    }
}
