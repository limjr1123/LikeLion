using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 리터럴 : 코드에서 고정된 값을 의미.
            int number  = 10;       // 정수 리터럴
            double pi   = 3.14;     // 실수형 리터럴
            char letter = 'A';      // 문자 리터럴
            string name = "Alice";  // 문자열 리터럴

            Console.WriteLine(number);  // 출력 : 10
            Console.WriteLine(pi);      // 출력 : 3.14
            Console.WriteLine(letter);  // 출력 : A
            Console.WriteLine(name);    // 출력 : Alice

            Console.WriteLine("**********************************");

            //캐릭터
            int hp      = 100;
            double att  = 56.7;
            string CharacterName = "LJR";
            char Rank   = 'S';

            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " + att);
            Console.WriteLine("캐릭터이름 : " + CharacterName);
            Console.WriteLine("등급 : " + Rank);
        }
    }
}
