using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY8_2
{
    //Q1) 클래스를 만들고 속성추가
    class Warrior
    {
        public string Name { get; set; }
        public int score { get; set; }
        public int Strength { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Q1) 클래스와 상속
            //Warrior 클래스를 만들고 Name과 Score 속성을 추가하세요.
            //Warrior Strength 속성을 추가하세요.
            //Main 메서드에서 Warrior 객체를 생성하고, Name, Score, Strength 값을 설정한 후 출력하세요.

            Warrior warrior = new Warrior();

            warrior.Name = "전사";
            warrior.score = 12500;
            warrior.Strength = 150;

            Console.WriteLine("name : " + warrior.Name);
            Console.WriteLine("score : " + warrior.score);
            Console.WriteLine("Strength : " + warrior.Strength);

            //Q2) 예외처리
            //사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
            //숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
            //변환이 성공하면 입력한 숫자를 출력하세요.
            Console.Write("정수를 입력하세요 : ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"입력한 숫자는 {num}입니다.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }

            ////Q3)컬렉션 (List, Queue, Stack) 활용
            ////List<string> 을 생성하고 "사과", "바나나", "포도"를 추가하세요.
            ////Queue<string> 을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
            ////Stack<int> 을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.

            //List<string> fruit = new List<string> { };

            //fruit.Add("사과");
            //fruit.Add("바나나");
            //fruit.Add("포도");
            //foreach (var name in fruit) 
            //{ 
            //    Console.WriteLine(name); 
            //}

            //Queue<string> job = new Queue<string> { };
            //job.Enqueue("첫 번째 작업");
            //job.Enqueue("두 번째 작업");
            //job.Enqueue("세 번째 작업");
            //foreach (var njob in job)
            //{
            //    Console.WriteLine(njob);
            //}

            //Stack<int> numb = new Stack<int> { };
            //numb.Push(10);
            //numb.Push(20);
            //numb.Push(30);
            //foreach (var num in numb)
            //{
            //    Console.WriteLine(num);
            //}

            ////Q4) 문자열 처리
            ////사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
            ////전체 문자열을 대문자로 변환
            ////"C#"을 "CSharp"으로 변경
            ////문자열의 길이 출력
            //Console.Write("문자열을 입력하세요 : ");
            //string str = Console.ReadLine();
            //string replace = str.ToUpper().Replace("C#", "CSharp");
            //Console.WriteLine($"문자열 변환 : {replace}");
            //Console.WriteLine($"문자열 길이 : {replace.Length}");

            //Q5) LINQ 활용
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
            //LINQ를 사용하여 짝수만 필터링하고 출력하세요.
            //LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            var evenNumbers = numbers.Where(n => n % 2 == 1);
            Console.Write("짝수 거르기 : ");
            foreach (int numb in evenNumbers)
            {
                Console.Write(numb +"  ");
                sum += numb;
            }
            Console.WriteLine();
            Console.WriteLine($"총 합 : {sum}");




            ////배열과 컬렉션
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////List : 배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            //List<string> names = new List<string> { "Alice","Bob","charlie"};
            //names.Add("Dave");

            //names.Remove("Bob");

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}





            string str = null;

            if (str == null)
            {
                Console.WriteLine("DefaultValue");
            }

            Console.WriteLine(str ?? "DefaultValue"); //str이 null이면 "Default Value

            //LINQ는 확장메서드 형태로 제공된다. 
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할 수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


            //task


        }
    }
}
