using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_1
{
    class Program
    {
        // 전역 변수
        static int num = 20;

        //1. 매개변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요.");
        }
        //2. 매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3. 반환값만 있는 함수
        static int GetNumber()
        {
            return 42;
        }

        //4. 매개변수와 반환값이 있는 함수
        static int Add(int a,int b)
        {
            return a + b;
        }

        //5. 기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6. 함수 오버로딩(Overloading)

        /// <summary>
        /// 두 수를 곱하는 함수
        /// </summary>
        /// <param name="a">오버로딩 해놓음</param>
        /// <param name="b">오버로딩 해놓음</param>
        /// <returns></returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }


        static void Main(string[] args)
        {
            //PrintHello();   //출력
            //PrintMessage("반갑습니다.");
            //Console.WriteLine(GetNumber());
            //Console.WriteLine(num);

            //int result = Add(3, 5);
            //Console.WriteLine(result);


            ////5. 기본값을 가진 매개변수 (디폴트 매개변수)
            //Greet();
            //Greet("철수");


            ////6. 함수 오버로딩(Overloading)
            //Console.WriteLine(Multiply(3,4));
            //Console.WriteLine(Multiply(3.123,4.543));


            ////7. out 키워드 (여러 값을 반환할때)
            //int q, r;
            //Divide(10, 3, out q, out r);

            //Console.WriteLine($"몫 : {q}, 나머지 : {r}"); //출력 : 몫:3, 나머지:1

            ////8. ref 키워드 
            //int value = 5;

            //Increase(ref value);
            //Console.WriteLine(value);

        }


        //8. ref 키워드 
        static void Increase(ref int num)
        {
            num += 10;
        }

        //7. out 키워드 (여러 값을 반환할때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;

            remainder = a % b;


        }
    }
}
