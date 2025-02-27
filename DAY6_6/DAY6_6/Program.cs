using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_6
{
    class Program
    {
        //1. C# 구조체
        // 클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠르다
        // 주로 간단한 데이터 묶음 만들때 사용

        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Print()
            {
                Console.WriteLine($"좌표:{X},{Y}");

            }
        }

        struct Rectangle
        {
            public int Width;
            public int Height;
            public int GetArea() => Width * Height;
        }

        struct Point2
        {
            public int x;
            public int y;
        }
        
        // Q) 학생 배열 선언
        struct Student
        {
            public string name;
            public int kor;
            public int eng;
            public int math;

            public void PrintPoint()
            {
                Console.WriteLine($"{name,-3} {kor,5} {eng,7} {math,8}");
            }
        }

        //struct Point는 X, Y 좌표 값을 저장하는 구조체
        //구조체는 클래스와 다르게 new 없이 사용 가능
        static void Main(string[] args)
        {
            //Point P;    //1. C# 구조체 선언 (초기화 필요)
            //P.X = 10;
            //P.Y = 20;

            //P.Print();

            //Point P1 = new Point(5, 15);    //class 선언
            //P1.Print();


            //Rectangle rect;
            //rect.Width = 10;
            //rect.Height = 20;
            //Console.WriteLine($"Area:{rect.GetArea()}");


            //Point2[] points = new Point2[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;

            //foreach(var point in points)
            //{
            //    Console.WriteLine($"Point:({point.x},{point.y})");
            //}


            // A) 학생 배열 선언 *********************다시보기*******************************
            //구조체를 이용해서 학생3명의 이름,성적을 입력 받고 국,영,수 출력.
            //이름    국어      영어      수학
            //홍길동   100       80       70
            //홍길란   100       80       70
            //홍길순   100       80       70
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("학생 이름과 성적을입력하세요.(성이름 100 80 90) : ");
                string str = Console.ReadLine();
                string[] strArry = str.Split();

                for (int j = 0; j < strArry.Length; j++)
                {
                    int iKor = int.Parse(strArry[j]);
                    int iEng = int.Parse(strArry[j]);
                    int iMath = int.Parse(strArry[j]);

                    students[i].name = strArry[j];
                    students[i].kor = iKor;
                    students[i].eng = iEng;
                    students[i].math = iMath;
                }

            }

            foreach (Student std in students)
            {
                std.PrintPoint();
            }
            // A) 학생 배열 선언 ********************다시보기********************************

            //// A) 학생 배열 선언
            //Student[] students = new Student[3];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("학생성적을 입력하세요.");
            //    Console.Write("학생이름 : ");
            //    students[i].name = Console.ReadLine();
            //    Console.Write("국어 : ");
            //    students[i].kor = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    students[i].eng = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    students[i].math = int.Parse(Console.ReadLine());
            //}


            //Console.WriteLine("이름    국어    영어    수학");

            //foreach (Student std in students)
            //{
            //    std.PrintPoint();
            //}




        }
    }
}
