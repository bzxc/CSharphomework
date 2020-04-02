using System;
using System.Threading;

namespace Clock
{
    public delegate void AlarmHandler(object sender,
                                    AlarmEventArgs args);
    public class AlarmEventArgs
    {

    }

    public delegate void TickHandler(object sender,
                                    TickEventArgs args);
    public class TickEventArgs
    {

    }
    public class clock
    {
        public event TickHandler Tick;
        public event AlarmHandler Alarm;

        public void tok()
        {
            TickEventArgs args = new TickEventArgs();
            Tick(this, args);
        }

        public void sound()
        {
            AlarmEventArgs args = new AlarmEventArgs();
            Alarm(this, args); 
        }
        
    }
    public class clockAction
    {
        public clock c = new clock();
        public clockAction()
        {
            c.Tick += clk_tik;
            c.Alarm += clk_alarm;
        }
        void clk_tik(object sender, TickEventArgs args)
        {
            Console.WriteLine("tik-tok");
        }
        void clk_alarm(object sender, AlarmEventArgs args)
        {
            Console.WriteLine("beeeeeeeep~");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clockAction a = new clockAction();
            for(int i = 0; i < int.MaxValue; i++)
            {
                a.c.tok();
                if(i==6) a.c.sound();
                Thread.Sleep(1000);
            }
        }
    }
}
