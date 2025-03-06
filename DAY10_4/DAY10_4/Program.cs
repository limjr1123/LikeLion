using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_4
{
    //C# 인터페이스(interface)란
    //인터페이스는 클래스나 구조체에서 구현하ㅐ야하는
    //즉. 어떤 기능ㅇ르 반드시 포함하도록 강제하는 역할을 합니다.

    //인터페이스의 특징
    //interface 키워드를 사용해서 정의
    //추상 매서드만 포함 (구현X) -> 인터페이스를 구현하는 클래스에서 반드시 구현해야함.
    //다중 상속 가능(C#에서는 클래스 다중상속이 불가능하지만. 인터페이스는 여러개 구현 가능)
    //객체를 생성할 수 없음(추상클래스와 유사)

    //인터페이스 정의
    interface IAinmal
    {
        void MakeSound(); //인터페이스의 매서드 (구현X)

    }

    //인터페이스 구현 (클래스에서 반드시 구현해야함)
    class Dog : IAinmal
    {
        public void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Cat : IAinmal
    {
        public void MakeSound()
        {
            Console.WriteLine("야옹!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IAinmal dog = new Dog();
            dog.MakeSound();

            IAinmal cat = new Cat();
            cat.MakeSound();
        }
    }
}
