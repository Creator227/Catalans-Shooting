using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace Events_Calc___Dem_
{

    public class CalculatorFinishEventArgs: EventArgs
    {
        public BigInteger Catalan;
        public int num;
        public CalculatorFinishEventArgs(BigInteger Catalan, int n)
        {
            this.Catalan = Catalan;
            num = n;
        }
    }
    public class Calculator
    {
        public bool is_active = true;
        public int rest_time;
        private Random rand = new Random();
        Thread t;
        public Thread T { get => t; }
        static BigInteger[] Catalans = new BigInteger[1001];
        
        public delegate void CalculatorFinishedEventHandler(object sender, CalculatorFinishEventArgs e);
        public event CalculatorFinishedEventHandler Finished;

        public Calculator(int rest_time, Demonstrator demonstrator)
        {
            this.rest_time = rest_time;
            Catalans[1] = 1;
            //Подписка на события 
            demonstrator.StopEvent += Demonstrator_StopEvent; 
            demonstrator.StartEvent += Demonstrator_StartEvent;
            ToStart();
           
        }
        private void ToStart()
        {
            is_active = true;
            t = new Thread(StartCalculations);
            t.Start();
        }
        private void StartCalculations()
        {
           
            while(is_active)
            {
                int C = rand.Next(1,1000);
                Finished?.Invoke(this, new CalculatorFinishEventArgs(FindCatalansNumber(C), C));
                Thread.Sleep(rest_time);
            }
        }
        private void Demonstrator_StartEvent(object sender, EventArgs e)
        {
            ToStart();
        }

        private void Demonstrator_StopEvent(object sender, EventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
                is_active = false;
                t.Join();
            }
        }
        private BigInteger FindCatalansNumber(int num)
        {
            if (Catalans[num] == 0)
                Catalans[num] = 2 * ((2 * num - 1) / (num + 1)) * FindCatalansNumber(num - 1);
            return Catalans[num];
           
        }
    }
}
