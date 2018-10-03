using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace program1
{
    partial class User
    {
        static void Main(string[] args)
        {//使用事件机制，模拟实现一个闹钟的定时功能，可以设置闹钟，在闹钟时间到了以后，在控制台显示提示信息
            try
            {
                Timer timer = new System.Timers.Timer();

                AlarmClock clock = new AlarmClock();
                clock.SetAlarmClock();
                clock.TimeStart(timer);
            }
            catch(TimeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("Please wait... ...");
            }
            Console.ReadKey();

        }

    }
}

public class TimeException : ApplicationException
{
    public TimeException(string message) : base(message)
    {

    }
}
