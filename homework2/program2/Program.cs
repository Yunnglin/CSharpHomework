using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] array = new int[] {64,2,3,2};
            program.MaxNum(array);
            program.MinNum(array);
            program.AverNum(array);
            program.SumNum(array);

        }

        public void MaxNum(int[] array)
        {
            int max;
            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine("最大值为：" + max);
        }

        public void MinNum(int[] array)
        {
            int min;
            min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("最小值为：" + min);
        }

        public void AverNum(int[] array)
        {
           
            double sum = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double aver = 0;
            aver = sum / array.Length;
            Console.WriteLine("平均值为：" +aver);
        }

        public void SumNum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("总值为：" + sum);
        }
    }
}
