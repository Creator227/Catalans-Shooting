using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Calc___Dem_
{
    public partial class Form1 : Form
    {
        int count = 0;
        private int shoot_pause = 800;
        private int shoot_size = 80;
        public Demonstrator demonstrator;
        public Form1()
        {
            InitializeComponent();
           // demonstrator = new Demonstrator(1500, 60);
            //Подписываемся на событие
            //demonstrator.DisplayEvent += Demonstrator_DisplayEvent;
            
        }

        private void Demonstrator_DisplayEvent(object sender, DisplayEventArgs e)
        {
            TBResult?.Invoke((MethodInvoker)(
                () => TBResult.AppendText((++count) + ") " + e.Result + Environment.NewLine)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BStart_Click(object sender, EventArgs e)
        {
            int rest;
            if(int.TryParse(TBRestTime.Text, out rest))
            {
                if (int.Parse(TBShootPause.Text) > 0 && int.Parse(TBShootSize.Text) > 0)
                {
                    shoot_pause = int.Parse(TBShootPause.Text);
                    shoot_size = int.Parse(TBShootSize.Text);
                    TBShootPause.Enabled = false;
                    TBShootSize.Enabled = false;
                    TBRestTime.Enabled = false;
                    BStart.Enabled = false;
                    BClear.Enabled = false;
                    Bstop.Enabled = true;
                    demonstrator = new Demonstrator(shoot_pause, shoot_size);
                    demonstrator.DisplayEvent += Demonstrator_DisplayEvent;
                    demonstrator.CalcInit(rest);
                }
                else
                {
                    MessageBox.Show("Проверьте параметры мишени!");
                }
                
            }
            else
            {
                TBRestTime.Clear();
                MessageBox.Show("Время отдыха должно быть целым числом!");
            }
        }

        //Нажали стоп
        private void button1_Click(object sender, EventArgs e)
        {
            Bstop.Enabled = false;
            BStart.Enabled = true;
            BClear.Enabled = true;
            TBRestTime.Enabled = true;
            TBShootPause.Enabled = true;
            TBShootSize.Enabled = true;
            demonstrator.StopCalc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BClear_Click(object sender, EventArgs e)
        {
            TBResult.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            demonstrator.calculator.T.Abort();
        }
    }
}
