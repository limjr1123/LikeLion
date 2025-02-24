using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag);   //논리 부정 : false

            ////~ 비트 반전
            //// 10 1010 -> 01 0101
            //int num = 10;
            //int result = ~num;
            //Console.WriteLine("원본 :" + num);
            //Console.WriteLine("~연산자 사용 결과 : " + result);

            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi;    //실수형 -> 정수형으로 변환

            //Console.WriteLine(integerPi);

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            ////float average = 0.0f;
            //double average = 0.00d;

            //sum = iKor + iEng + iMath;
            //average = sum / 3.0f; //평균

            //Console.WriteLine("총점 : "+ sum);
            //Console.WriteLine("평균 : "+ average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            //// 출력 연산자
            //string firstName = "Alice"; 
            //string lastName = "Smith"; 

            //Console.WriteLine(firstName + " " + lastName); // 출력: Alice Smith

            //int a = 10;
            //a += 5;     // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5;     // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5;     // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5;     // a = a / 5;
            //Console.WriteLine(a);
            //a %= 5;     // a = a % 5;
            //Console.WriteLine(a);


            Console.WriteLine("Q1)");

            int iKor = 0;
            int iEng = 0;
            int iMath = 0;

            int sum;
            double avg = 0.0d;

            Console.Write("국어 점수를 입력하세요 : ");
            iKor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 : ");
            iEng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 : ");
            iMath = int.Parse(Console.ReadLine());

            sum = iKor + iEng + iMath;
            avg = (double)sum / 3;
            String result = avg.ToString("F2");

            Console.WriteLine($"평균 점수는 {result}점 입니다.");

            Console.WriteLine("Q2)");

            int orgInt = 0;
            int revInt;
            
            Console.Write("정수를 입력하세요 : ");
            orgInt = int.Parse(Console.ReadLine());
            revInt = ~orgInt;
            Console.WriteLine($"입력한 정수는 {orgInt} 입니다.");
            Console.WriteLine($"입력한 정수의 비트반전은 {revInt} 입니다.");

        }
    }
}
