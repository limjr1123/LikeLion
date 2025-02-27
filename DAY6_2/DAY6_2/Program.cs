using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_2
{
    class Program
    {
        //1. params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }

        //2. 재귀 함수(자기자신 호출)
        static void Print()
        {
            Console.WriteLine("I am 재귀함수.");
            Print();
        }

        static int Factorial(int num)
        {
            
            if (num <= 1) return 1;
            Console.WriteLine(num);
            return num * Factorial(num - 1);

        }

        static void Main(string[] args)
        {
            ////1. params 키워드 (가변 매개변수)
            //Console.WriteLine(Sum(1, 2, 3));    //출력 6
            //Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9));

            ////2. 재귀 함수(자기자신 호출)
            //Print();

            Console.WriteLine(Factorial(5));
        }
    }
}
