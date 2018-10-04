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
        {
            //使用事件机制，模拟实现一个闹钟的定时功能，可以设置闹钟，在闹钟时间到了以后，在控制台显示提示信息

            AlarmClock clock1 = new AlarmClock();
            clock1.SetAlarmClock();
            clock1.TimeStart();

            AlarmClock clock2 = new AlarmClock();
            clock2.SetAlarmClock();
            clock2.TimeStart();

            Console.ReadKey();

        }

    }
}
