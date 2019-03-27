using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Calculate calculate = new Calculate();
            Console.WriteLine("请输入将要生成的题目数：");
            int j = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < j; i++)
            {
                calculate.Calculator();
            }
        }
    }
    class GetSeed
    {
        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }
    class Calculate
    {
        public void Calculator()
        {
            Random random = new Random(GetSeed.GetRandomSeed());
            Thread.Sleep(100);
            Random ran = new Random();
            int num1 = ran.Next(1, 100);
            int num2 = ran.Next(1, 100);
            int num3 = ran.Next(4);//随机产生1.2.3.4分别代表加减乘除
            int sum;
            switch (num3)
            {
                case 0:
                    sum = num1 + num2;
                    Console.WriteLine(num1.ToString() + '+' + num2.ToString() + '=' + sum.ToString());
                    break;
                case 1:
                    sum = num1 - num2;
                    Console.WriteLine(num1.ToString() + '-' + num2.ToString() + '=' + sum.ToString());
                    break;
                case 2:
                    sum = num1 * num2;
                    Console.WriteLine(num1.ToString() + '*' + num2.ToString() + '=' + sum.ToString());
                    break;
                case 3:
                    sum = num1 / num2;
                    Console.WriteLine(num1.ToString() + '/' + num2.ToString() + '=' + sum.ToString());
                    break;

            }

        }
    }
}
