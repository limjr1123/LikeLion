using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_4
{
    class Program
    {
        //화살표 함수
        static int AddArrow(int a, int b) => a + b;

        //일반적인 함수
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요");
        }

        //화살표
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요");
        

        static void Main(string[] args)
        {
            Console.WriteLine(AddArrow(3, 5));
            PrintMessage();
            PrintMessageArrow();

        }
    }
}
