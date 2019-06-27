using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events_Calc___Dem_
{
    // Для стрельбы
    public class ShotEventArgs : EventArgs
    {
        public int X;
        public int Y;
       
        public ShotEventArgs(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
    }

    public class DisplayEventArgs : EventArgs
    {
        string result;

        public string Result { get => result; }

        public DisplayEventArgs(string str) : base()
        {
            result = str;
        }
    }

    public class Demonstrator
    {
        public Calculator calculator;
        public delegate void DisplayEventHandler(object sender, DisplayEventArgs e);
        public event DisplayEventHandler DisplayEvent;

        public delegate void StopEventHandler(object sender, EventArgs e);
        public event StopEventHandler StopEvent;

        public delegate void StartEventHandler(object sender, EventArgs e);
        public event StartEventHandler StartEvent;


        // Стрельба
        public int shot_pause;
        public int R;
        public delegate void GetShotEventHandler(object sender, ShotEventArgs e);
        public event GetShotEventHandler ShotEvent;
        Random X = new Random();
        Random Y = new Random();
        public Thread ShootThread;
        public bool calc_active = true;
        //Добавляем Мишень
        public Demonstrator(int shot_pause, int radius)
        {
            this.shot_pause = shot_pause;
            this.R = radius;
            var shooting = new ShootingForm(this);
            shooting.Show();
            ShootThread = new Thread(StartShooting);
            ShootThread.Start();
        }
        /// <summary>
        /// Для вычислителя чисел Каталана
        /// </summary>
        /// <param name="time"></param>
        public void CalcInit(int time)
        {
            calc_active = true;
            if (calculator == null || calculator.rest_time != time)
            {
                calculator = new Calculator(time, this);
                //Подписываемся на собтие
                calculator.Finished += Calculator_CalcFinish;
            }
            else
            {
                StartEvent(this, new EventArgs());
            }
        }
        private void Calculator_CalcFinish(object sender, CalculatorFinishEventArgs e)
        {
            string str = "Число Каталана номер " + e.num.ToString() + ": " + e.Catalan.ToString();
            DisplayEvent?.Invoke(this, new DisplayEventArgs(str));
        }
        public void StopCalc()
        {
            StopEvent?.Invoke(this, new EventArgs());
            calc_active = false;
        }

        //Для стрельбы
        public void StartShooting()
        {
            while (true)
            {
                X = new Random();
                var XN = X.Next(-2 * R, 2 * R);
                //Thread.Sleep(shot_pause - 150);
                Y = new Random();
                var YN = X.Next(-2 * R, 2 * R);
                ShotEvent?.Invoke(this, new ShotEventArgs(XN, YN));
                Thread.Sleep(shot_pause);
            }
        }
    }
}
