using System;
using System.Timers;

namespace program1
{
    partial class User
    {

        public class AlarmClock
        {

            public int Hour;
            public int Minute;
            public int Second;

            public AlarmClock(int hour = 0, int minute = 0, int second = 0)
            {
                Hour = hour;
                Minute = minute;
                Second = second;
            }

            public void SetAlarmClock()//设置闹钟时间
            {
                try
                {
                    Console.WriteLine("Please set the hour: ");
                    int hour = Convert.ToInt32(Console.ReadLine());
                    if (hour < 0 || hour > 23)
                    {
                        throw new TimeException("Hours out of range");
                    }

                    Console.WriteLine("Please set the minutes: ");
                    int minute = Convert.ToInt32(Console.ReadLine());
                    if (minute < 0 || minute > 60)
                    {
                        throw new TimeException("Minutes out of range");
                    }

                    Console.WriteLine("Please set the seconds");
                    int second = Convert.ToInt32(Console.ReadLine());
                    if (second < 0 || second > 60)
                    {
                        throw new TimeException("Second out of range");
                    }

                    Hour = hour;
                    Minute = minute;
                    Second = second;
                }

                catch (TimeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: " + e);
                }
                finally
                {
                    Console.WriteLine("Please wait... ...");
                }
            }


            public void TimeStart()//开始计时
            {
                Timer timer = new Timer
                {
                    Enabled = true,
                    Interval = 1000//执行间隔时间,单位为毫秒;此时时间间隔为1秒
                };
                timer.Start();
                timer.Elapsed += Ring;
            }

            public void Ring(object source, ElapsedEventArgs e)//时间到了，执行操作
            {

                if (DateTime.Now.Hour == Hour && DateTime.Now.Minute == Minute && DateTime.Now.Second == Second)  //如果当前时间是10点30分
                {
                    Console.WriteLine("It's " + DateTime.Now.ToString() + " now!!! ");
                    Console.WriteLine("早く起きなさい！！！");
                }

            }
        }

    }
}
