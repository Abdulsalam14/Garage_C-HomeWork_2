using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////1

            //Console.Write("M:");
            //int M = int.Parse(Console.ReadLine());
            //float Sum=0;
            //int Count = 0;

            //for (int i = 1; i <M; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        Sum += i;
            //        Count++;
            //    }
            //}
            //float result= Sum/Count;
            //Console.WriteLine(result);


            ////2

            //Console.Write("Num1:");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Num2:");
            //int num2=int.Parse(Console.ReadLine());

            //int sum = 0;

            //for(int i = num1;i <num2+1;i++)
            //{
            //    sum+= i;
            //}

            //Console.WriteLine(sum);



            //3

            Console.Write("M:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = m; i < n; i++)
            {
                if (i > 9)
                {
                    int sum = 0;
                    int bolen = 1;
                    while (bolen <= i)
                    {
                        sum += i / bolen % 10;
                        bolen *= 10;
                    }
                    if (sum % 2 == 0) count++;
                }
            }

            Console.WriteLine(count);

        }
    }
}
