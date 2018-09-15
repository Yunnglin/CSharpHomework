using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            do
            {
                Console.WriteLine("请输入一个正整数：(输入-1退出程序)");
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == -1)
                    {
                        break;
                    }
                    if (num <= 0 || num == 1)
                    {
                        Console.WriteLine("emmmmm");
                        continue;
                    }
                    Console.Write(num + " = ");
                    program.Factorization(num);
                }
                catch (Exception e)
                {
                    Console.WriteLine("请输入正确的数字！！！");
                    Console.WriteLine();
                }
            } while (true);
        }

        public void Factorization(int num)//计算素因子
        {
            ArrayList factors = new ArrayList();
            for (int i = 2; i < num; i++)
            {
                while (num != i)
                {
                    if (num % i == 0)
                    {
                        factors.Add(i);
                        num = num / i;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            factors.TrimToSize();
            foreach (int i in factors)
            {
                Console.Write(i + " * ");
            }
            Console.Write(num);//跳出时最后的质数
            Console.WriteLine("");
        }
    }
}
