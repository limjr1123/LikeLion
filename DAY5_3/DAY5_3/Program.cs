using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAY5_3
{
    class Program
    {
        //1단계 함수
        //반환형 함수이름 (매개변수)
        //{
        //}

        static void Loading()
        {

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계 : 입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 : " + _Attack);
        }

        //3단계 : 출력
        static int BaseAttack()
        {
            //기본 공격력 10
            int attack = 10;

            return attack;  //출력
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //Loading();

            //Console.WriteLine("게임이 시작됩니다.");
            //Console.ReadLine();

            ////2단계 : 입력
            ////3단계 : 출력
            //int Attack = 0;
            //int bAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본 공격력 
            //bAttack = BaseAttack();

            //AttackFunction(Attack + bAttack);

            ////Q1)두 수를 더하는 함수 만들어서 오류를 해결하세요.
            //int result = Add(10, 20);
            //Console.WriteLine($"10+20 = {result}");


            //string[] fruits = { "사과", "바나나", "체리" };

            ////반복문
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Q1)크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.");

            //int[] five = { 10, 20, 30, 40, 50 };
            //foreach(int fives in five)
            //{
            //    Console.Write(fives+" ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Q2)사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.");

            //int sum = 0;

            //Console.Write("숫자 입력:");
            //string numString = Console.ReadLine();
            //string[] num = numString.Split(' ');

            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += int.Parse(num[i]);
            //}
            //Console.WriteLine($"총 합:{sum}");

            //Console.WriteLine();
            //Console.WriteLine("Q3)정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.");

            //int[] num = { 3, 8, 15, 6, 2 };
            //int max = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    max = max < num[i] ? num[i]:max  ;
            //}
            //Console.WriteLine($"최대값: {max}");

            //Console.WriteLine();
            //Console.WriteLine("Q4. 1부터 10까지 출력 (for문)");

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i+" "); 
            //}

            //Console.WriteLine();
            //Console.WriteLine("Q5. 짝수만 출력 (while문)");

            //int i = 0;
            //do
            //{
            //    i++;
            //    if (i % 2 == 0)
            //        Console.Write(i + " ");

            //} while (i < 10);
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("Q6. 배열 요소 출력 (foreach문)");

            //int[] num = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int numArry in num)
            //{
            //    Console.Write(numArry+" "); 
            //}

            //Console.WriteLine();
            //Console.WriteLine("Q7. 두 수의 합을 구하는 함수");

            //int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine("3과 5의 합: " + Sum(3, 5));

            //Console.WriteLine();
            //Console.WriteLine("Q8. 문자열 길이 반환 함수");

            //int StrLength(string a)
            //{
            //    int lang = a.Length;
            //    return lang;
            //}

            //Console.Write("문자열 입력 :");
            //string str = Console.ReadLine();

            //Console.WriteLine("문자열 길이 :" + StrLength(str));



            //Console.WriteLine();
            //Console.WriteLine("Q9. 가장 큰 수 반환 함수");
            ////함수
            //int MaxNum(string number)
            //{
            //    int max = 0;
            //    string[] numArray = number.Split(' ');
            //    for (int i = 0; i < numArray.Length; i++)
            //    {
            //        max = max > int.Parse(numArray[i]) ? max : int.Parse(numArray[i]);
            //    }

            //    return max;
            //}

            //Console.Write("숫자 입력 :");
            //string num = Console.ReadLine();

            //Console.WriteLine("가장 큰 수 :"+ MaxNum(num));

            //숫자 포멧
            double pi = 3.1415932;
            double result = Math.Round(pi,4);
            string result2 = pi.ToString("N2");
            string result3 = pi.ToString("0.000");
            string result4 = string.Format("{0:0.000000}", pi);
            string result5 = string.Format("{0:N4}",pi);
            Console.WriteLine("소수점 둘재 :" + result);
            Console.WriteLine("소수점 둘재2 :" + result2);
            Console.WriteLine("소수점 둘재3 :" + result3);
            Console.WriteLine($"소수점 둘재2 :" + result4);
            Console.WriteLine($"소수점 둘재3 : {result5}");

        }
    }
}
