using System;
using System.Timers;

namespace program1
{
    partial class User
    {
        //声明事件参数类型
        //public class AlarmClockEventArgs : EventArgs
        //{
        //    public string Times { set; get; }
        //}
        ////声明委托类型
        //public delegate void AlarmClockEventHandler(object sender, AlarmClockEventArgs e);

        //定义事件源（闹钟）
        public class AlarmClock
        {
            //声明事件
            //public event AlarmClockEventHandler TimeOut;

            public static int Hour;
            public static int Minute;
            public static int Second;

           

            public AlarmClock( int hour=0,int minute=0,int second=0)
            {
                Hour = hour;
                Minute = minute;
                Second = second;
            }

            public void SetAlarmClock()
            {
                Console.WriteLine("Please set the hour: ");
                int hour = Convert.ToInt32(Console.ReadLine());
                if (hour < 0 || hour > 23)
                {
                    throw new TimeException("Time out of range");
                }

                Console.WriteLine("Please set the minutes: ");
                int minute = Convert.ToInt32(Console.ReadLine());
                if (minute < 0 || minute > 60)
                {
                    throw new TimeException("Time out of range");
                }

                Console.WriteLine("Please set the seconds");
                int second = Convert.ToInt32(Console.ReadLine());
                if (second < 0 || second > 60)
                {
                    throw new TimeException("Time out of range");
                }

                Hour = hour;
                Minute = minute;
                Second = second;
            }


            public void TimeStart(System.Timers.Timer timer)
            {
                timer.Enabled = true;
                timer.Interval = 1000;//执行间隔时间,单位为毫秒;此时时间间隔为1秒
                timer.Start();
                timer.Elapsed += Ring;
            }

            public static void Ring(object source, ElapsedEventArgs e)
            {

                if (DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute && DateTime.Now.Second == Second)  //如果当前时间是10点30分
                {
                    Console.WriteLine("It's " + DateTime.Now.ToString()+ " now!!! ");
                    Console.WriteLine("早く起きなさい！！！");
                }

            }
        }

    }
}
