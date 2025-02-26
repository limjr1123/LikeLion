using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////배열
            //int[] num = new int[3];

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            //Console.WriteLine(num[2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}


            //int[] numbers = { 3, 2, 1 };    //간단한 선언과 초기화
            //int[] numbers2 = new int[3];    //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언


            //for (int i = 0; i<3; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //// 3명의 
            //// 국어, 영어, 수학 점수를 입력받고 
            //// 총점과 평균을 출력하세요. 

            //int[] kor   = new int[3];
            //int[] eng   = new int[3];
            //int[] math  = new int[3];

            //int[] sum   = new int[3];
            //float[] avg = new float[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1} 번째 학생의 성적을 입력하세요.");
            //    Console.Write("국어 : ");
            //    kor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    eng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    math[i] = int.Parse(Console.ReadLine());

            //    sum[i] = kor[i] + eng[i] + math[i];
            //    avg[i] = (float)sum[i]/3;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1} 번째 학생의 총점은{sum[i]}점 평균은{avg[i].ToString("F2")}점 입니다.");
            //}

            ////1차원 배열
            //int[] scores = new int[3];
            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수{i + 1}:{scores[i]}");
            //}


            ////소수점 자릿수 설정하는 포멧
            //double value = 123.456789;
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점 둘째자리 : {value:F2}");
            //Console.WriteLine(String.Format("소수점 둘재짜리: {0:F2}", value));


            //double value2 = 112312323.456789;
            //Console.WriteLine(value2.ToString("N2"));
            //Console.WriteLine($"소수점 둘째자리 : {value2:N2}");
            //Console.WriteLine(String.Format("소수점 둘재짜리: {0:N2}", value2));

            ////2차원 배열 선언
            //int[,] matrix = new int[2, 3]{ {1,2,3},{4,5,6} };

            //for(int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("i:"+i);
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(" j:"+j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"{matrix[i,j]}");
            //    }
            //    Console.WriteLine();
            //}


            //int[][] matrix = new int[2][];
            //matrix[0] = new int[3];
            //matrix[1] = new int[3];

            ////값 입력
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;
            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            ////출력
            //for(int i =0; i < matrix.Length; i++)
            //{
            //    for(int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.WriteLine($"{matrix[i][j]}");
            //    }
            //    Console.WriteLine();
            //}


            ////가변배열
            //Console.WriteLine("가변 배열");
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4 ,5};
            //jaggedArray[2] = new int[] { 6 };

            //for(int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine($"{jaggedArray[i][j]}");
            //    }
            //    Console.WriteLine();
            //}
            //// var를 사용한 가변 데이터타입 
            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //var charct = new[] { '1', '2', '3', '4', '5' };
            //var stringi = new[] { "1", "2", "3", "4", "5" };
            //// 데이터 타입 확인
            //Console.WriteLine($"배열 타입:{numbers.GetType()}");
            //Console.WriteLine($"배열 타입:{charct.GetType()}");
            //Console.WriteLine($"배열 타입:{stringi.GetType()}");

        }
    }
}
