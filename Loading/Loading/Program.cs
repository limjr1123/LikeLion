using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String square = "□□□□□□□□□□";
            char replacement = '■';
            for (int i = 0 ; i < square.Length; i++)
            {
                Console.WriteLine(square);
                Thread.Sleep(500); //1000 1초다 (1000ms)
                Console.Clear();    //콘솔 화면 지우기

                square = square.Remove(i, 1).Insert(i, replacement.ToString());
            }
        }
    }
}
