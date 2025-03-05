using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9_4
{
    // 매서드 오버라이딩 (Overriding)
    //부모 클래스의 매서드를 자식클래스에서 재정의(Override)하여 다른 동작을 수행할 수 있다.


    class Animal
    {
        public string Name { get; set; }
        public virtual void Speak() //virtual 이 있는 함수만 overridng 가능
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        public override void Speak() //overridng 할 함수에 표시
        {
            Console.WriteLine($"{Name}이(가) 멍멍 소리를 냅니다.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "일반동물";
            myAnimal.Speak();   //부모클래스의 기본메서드 실행

            Dog myDog = new Dog();
            myDog.Name = "바숙이";
            myDog.Speak(); //오버라이딩 된 매서드 실행

        }
    }
}
