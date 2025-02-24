using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 값을 비교하여 관계를 평가한다.
            // == 같다 != 같지않다 A < B C>D <= =>

            //int x = 5, y = 10;

            //Console.WriteLine(x < y);   //true
            //Console.WriteLine(x == y);  //false
            //Console.WriteLine(x != y);  //true
            //Console.WriteLine(x > y);   //false
            //Console.WriteLine(x >= y);  //false
            //Console.WriteLine(x <= y);  //true

            ////논리 연산자
            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            ////AND : 1:1 t
            ////      1:0 f
            ////      0:1 f
            ////      0:0 f
            //Console.WriteLine(a || b);
            ////AND : 1:1 t
            ////      1:0 t
            ////      0:1 t
            ////      0:0 f

            ////비트연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y);   //AND   : 1 (0001)
            //Console.WriteLine(x | y);   //OR    : 7 (0111)
            //Console.WriteLine(x ^ y);   //XOR   : 6 (0110)
            ////0101
            ////0011
            ////0110 -> 서로 다른것만 1
            //Console.WriteLine(~x);      //NOT   : -6 (-0110)

            //int value = 4; //0100

            //Console.WriteLine(value << 1);  //왼쪽 이동 : 8 (1000)
            //Console.WriteLine(value >> 1);  //오른쪽 이동 : 2 (0010)
            //Console.WriteLine(value << 2);  //왼쪽 이동 : 16 (0001 0000)
            //Console.WriteLine(value >> 2);  //오른쪽 이동 : 1 (0001)

            //int a = 10, b = 20;

            //int max;

            //max = a < b ? a : b;    //삼항 연산자
            //Console.WriteLine(max);

            //int key = 1;
            //string str;
            //str = key == 2 ? "문이 열렸습니다." : "문을 열지 못했습니다.";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;
            //Console.WriteLine(result);          // 20
            //int adjustedResult = (10 + 2) * 5;
            //Console.WriteLine(adjustedResult);  // 60 

            //int score = 90;
            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B 학점");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C 학점");
            //}
            //else
            //{
            //    Console.WriteLine("F 학점");
            //}

            //if (false)
            //{
            //    Console.WriteLine("트루");
            //}
            //else
            //{
            //    Console.WriteLine("팔스");
            //}

            //소지금 입력 :
            //   0 ~ 100 무한의 대검   +1
            // 101 ~ 200 카타나        +2
            // 201 ~ 300 진은검        +3
            // 301 ~ 400 집판검        +4
            // 401 ~ 500 엑스칼리버    +5
            // 501 ~ 600 유령검        +6
            // 601 ~ 전설의 검 +7

            //캐릭터 이름
            //공격력 : 100 + 1

            //Console.Write("소지금 입력 : ");
            //int gold = int.Parse(Console.ReadLine());

            //var weaponName  = "";
            //var attpoint    = 0;

            //if (gold <= 100)
            //{
            //    weaponName = "무한의 대검";
            //    attpoint = 1;
            //}
            //else if (gold <= 200)
            //{
            //    weaponName = "카타나";
            //    attpoint = 2;
            //}
            //else if (gold <= 300)
            //{
            //    weaponName = "진은검";
            //    attpoint = 3;
            //}
            //else if (gold <= 400)
            //{
            //    weaponName = "집판검";
            //    attpoint = 4;
            //}
            //else if (gold <= 500)
            //{
            //    weaponName = "엑스칼리버";
            //    attpoint = 5;
            //}
            //else if (gold <= 600)
            //{
            //    weaponName = "유령검";
            //    attpoint = 6;
            //}
            //else
            //{
            //    weaponName = "전설의 검";
            //    attpoint = 7;
            //}

            //Console.WriteLine("캐릭터 : 멋사검존");
            //Console.WriteLine($"무기 : {weaponName}");
            //Console.WriteLine($"공격력 : 100 + {attpoint}");

            /**********************************************************/
            Console.WriteLine("Q1) 세 정수의 최댓값 구하기");

            Console.Write("1. 정수1을(를) 입력하세요 : ");
            int int1 = int.Parse(Console.ReadLine());
            Console.Write("2. 정수2을(를) 입력하세요 : ");
            int int2 = int.Parse(Console.ReadLine());
            Console.Write("3. 정수3을(를) 입력하세요 : ");
            int int3 = int.Parse(Console.ReadLine());

            int max1 = int1 > int2 ? int1 : int2;
            int max2 = max1 > int3 ? max1 : int3;
            Console.WriteLine($"최댓값은 {max2} 입니다.\n");

            ///**********************************************************/
            Console.WriteLine("Q2) 점수에 따른 학점 평가");
            int point;
            string grade;
            Console.Write("점수를 입력하세요 : ");
            point = int.Parse(Console.ReadLine());

            if (point >= 90) { grade = "A"; }
            else if (point >= 80 && point < 90) { grade = "B"; }
            else if (point >= 70 && point < 80) { grade = "C"; }
            else if (point >= 60 && point < 70) { grade = "D"; }
            else { grade = "F"; }
            Console.WriteLine($"{grade}학점 입니다.\n");

            /**********************************************************/
            Console.WriteLine("Q3) 간단한 사칙연산 계산기");
            int a;
            int b;

            Console.Write("숫자1을 입력하세요 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("숫자2를 입력하세요 : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("연산자를 입력하세요 : ");
            string opt = Console.ReadLine();
            int result;


            if (opt == "+") { result = a + b; }
            else if (opt == "-") { result = a - b; }
            else if (opt == "*") { result = a * b; }
            else if (opt == "/")
            {
                if (b == 0)
                {
                    Console.Write("0으로 나눌 수 없습니다.");
                    return;
                }
                result = a / b;
            }
            else
            {
                Console.Write("사칙연산 기호를 입력해야 합니다.");
                return;
            }

            Console.WriteLine("결과 : " + result);
        }
    }
}
