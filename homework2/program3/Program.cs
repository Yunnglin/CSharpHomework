using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("你想要计算多大数值内的素数？");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                program.SieveOfEratosthenes(num);
            }
            catch(Exception e)
            {
                Console.WriteLine("请输入正确的数值！！！");
            }

        }

        public void SieveOfEratosthenes(int num)//埃拉托斯特尼筛法
        {
            //生成动态数组
            ArrayList primes = new ArrayList();

            //储存所需要的数
            for (int i = 2; i <=num; i++)
            {
                primes.Add(i);
            }
            //第一次情况
            int prePrime = 2;
            int count = primes.Count;
            int lastNum = (int)primes[count - 1];
            int j = 0;
            //开始遍历，最多根号n次
            while (prePrime * prePrime <= lastNum)
            {
                count = primes.Count;
                lastNum = (int)primes[count - 1];
                for (int i = 0; i < count; i++)
                {
                    if (((int)primes[i] % prePrime == 0) && ((int)primes[i]!=2))
                    {//移除掉各种倍数
                        primes.RemoveAt(i);
                        count--; 
                    }
                }
                //下一个素数后移一位
                j++;
                prePrime = (int)primes[j];
            }

            foreach(int i in primes)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
    }

}
