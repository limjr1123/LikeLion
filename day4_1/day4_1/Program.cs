using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////switch 문
            //Console.WriteLine("번호입력(1~100):");
            //int day;
            //day = int.Parse(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("목요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("금요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말");
            //        break;
            //}

            //캐릭터 선택 ( 1.검사, 2.마법사, 3.도적)
            //검사
            //공격력 100
            //방어력 90

            //마법사
            //공격력 110
            //방어력 80

            //도적
            //공격력 115
            //방어력 70

            //Console.Write("캐릭터를 선택하세요 (1.검사, 2.마법사, 3.도적):");

            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;
            //    default:
            //        Console.WriteLine("번호를 입력해주세요(1~3)");
            //        break;
            //}

            ////반복문
            //for(int i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}

            //반복문
            //for (; ; )
            //{
            //    Console.WriteLine("명륜진사갈비");
            //}

            //0~9 출력
            //for(int i = 0; i < 10; i++)
            //{
            //    if (i == 9)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //    Console.Write(i + ", ");
            //}

            //// 1~ 10 합구하기
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.Write(sum);


            ////1부터 10까지의 합 구하기
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //sum += i;
            //    sum = sum + i;

            //    Console.WriteLine($"sum : {sum} i : {i}");
            //}
            //Console.WriteLine("1부터 10까지의 합 : " + sum);

            //int count = 1;      //초기화
            //while(count <= 5)   //조건식
            //{
            //    Console.WriteLine("count:" + count);
            //    count++;        //증가,감소

            //    if (count == 3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}

            ////랜덤
            //Random rand = new Random(); //Random 객체를 생성한다.

            ////0이상 10미만의 랜덤 정수 생성
            //int randomInRange = 0;
            //for(int i = 0; i < 100; i++)
            //{
            //    //int randomNumber = rand.Next(0, 10); // 0~9
            //    //double randomNumber = rand.NextDouble(); // 랜덤double
            //    randomInRange = rand.Next(5, 15);
            //    Console.WriteLine("0이상 10미만 정수 :" + randomInRange);
            //}

            ////대장장이 키우기
            ////도끼등급 SSS  10 %
            ////도끼등급 SS   40 %
            ////도끼등급 S    50 %

            //Random rand = new Random(); //랜덤값을 뽑는 문장

            //int rnd = 0;

            //for(int i = 0; i < 20; i++)
            //{
            //    rnd = rand.Next(1, 101); //1~100
            //    if (rnd >=1 && rnd <= 10)
            //        Console.WriteLine("도끼등급 SSS");
            //    else if (rnd >= 11 && rnd <=40)
            //        Console.WriteLine("도끼등급 SS");
            //    else if (rnd >= 41 && rnd <=100)
            //        Console.WriteLine("도끼등급 S");
            //    Thread.Sleep(500);
            //}

            //int x = 5;
            //do
            //{
            //    Console.WriteLine("최소1회 이상 실행.");
            //    x--;

            //} while (x > 0);

            ////break문
            ////반복문 탈출.
            //for (int i=1; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //countinue
            //현재 반복을건너뛰고 다음 반복으로 넘어간다.

            //for(int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i); //홀수만 출력
            //}

            ////goto 
            ////유지보수 매우힘들어서 잘 안씀(이거 쓸바에 객체사용)
            //int n = 1;
            //start:
            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;

            //    goto start;
            //}
        }
    }
}
