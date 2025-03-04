using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("프로그램 종료");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");
            //Environment.Exit(0);

            //Random random = new Random();
            //int redom numver

            //Random random = new Random();


            int valueType = 10;
            object referenceType = valueType;

            valueType = 20;

            Console.WriteLine($"ValueType : {valueType}"); //20
            Console.WriteLine($"ReferenceType: {referenceType}");

            //박싱 언박싱
            //값 형식을 참조형식으로 변환(박싱) , 다시 값 형식으로 변환(언박싱)
            int value = 42;
            object boxed = value; //박싱
            int unboxed = (int)boxed; //언박싱

            Console.WriteLine($"Boxed:{boxed},unboxed : {unboxed} ");

            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할 수 있다.
            object obj = "Hello";
            Console.WriteLine(obj is string);   // true
            Console.WriteLine(obj is int );   // false

            //as 연산자로 형식 변환
            //as 연산자를 사용해 안전하게 형 변환 수행.

            object stringObj = "Hello";
            string str = stringObj as string;
            Console.WriteLine(str is string);   // false

            string greeting = "Hello";
            string name = "Alice";

            string message = greeting + "," + name + "!";
            Console.WriteLine(message); //Hello,Alice

            Console.WriteLine($"Length of name: {name.Length}"); //문자열 길이
            Console.WriteLine($"To Upper: {name.ToUpper()}"); //대문자 변환
            Console.WriteLine($"Substring: {name.Substring(1)}"); //부분 문자열
        }
    }
}
