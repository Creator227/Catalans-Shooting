using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Events_Calc___Dem_
{
    public partial class ShootingForm : Form
    {
        Demonstrator creator;
        private int _allShoots = 0;
        private int _targetShoots = 0;
        private int R;
        List<Point> shoots = new List<Point>();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawTarget(e.Graphics, R);
            DrawShoots(e.Graphics);
        }


        private void DrawTarget(Graphics g, int R)
        {
            Pen pen = new Pen(Color.Red);
            int X0 = ClientRectangle.Width / 2 + 60;
            int Y0 = ClientRectangle.Height / 2;
            g.DrawLine(pen, X0, Y0, X0 + 3 * R, Y0);
            g.DrawLine(pen, X0, Y0, X0 - 3 * R, Y0);
            g.DrawLine(pen, X0, Y0, X0, Y0 + 3 * R);
            g.DrawLine(pen, X0, Y0, X0, Y0 - 3 * R);

            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, X0 - 2 * R, Y0 - 2 * R, 2 * R, 2 * R);
            g.FillRectangle(brush, X0, Y0, 2 * R, R);
        }
        private void DrawShoots(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Green);
            foreach (var shoot in shoots)
            {
                g.FillEllipse(brush, shoot.X - 5, shoot.Y - 5, 10, 10);
            }

        }

        public void GetShot(object sender, ShotEventArgs e)
        {
          
            int XC = ClientRectangle.Width / 2 + 60 - R;
            int YC = ClientRectangle.Height / 2 - R;
            int X0 = ClientRectangle.Width / 2 + 60;
            int Y0 = ClientRectangle.Height / 2;

            var shoot = new Point(X0 + e.X, Y0 - e.Y);
            shoots.Add(shoot);

            if (Math.Sqrt(Math.Pow(XC - shoot.X, 2) + Math.Pow(YC - shoot.Y, 2)) <= R
                || ((shoot.X >= X0 && shoot.X <= X0 + 2 * R) && (shoot.Y >= Y0 && shoot.Y <= Y0 + R)))
            {
                _targetShoots += 1;
                LTShoots.Invoke((MethodInvoker)(
                () => LTShoots.Text = "Попадания: " + _targetShoots.ToString()));
            }
            _allShoots += 1;
            LAllShoots.Invoke((MethodInvoker)(
                () => LAllShoots.Text = "Все выстрелы: " + _allShoots.ToString()));

            Invalidate();
        }

        public ShootingForm(Demonstrator creator)
        {
            this.creator = creator;
            InitializeComponent();
            creator.ShotEvent += GetShot;
            this.R = creator.R;
        }

        private void ShootingForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (creator.calc_active)
                MessageBox.Show("Вычислитель не завершил свою работу!");
            else
            {
                creator.ShootThread.Abort();
                button1.Enabled = false;
            }
        }

        private void ShootingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            creator.ShootThread.Abort();
        }
    }
}
