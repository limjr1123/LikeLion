using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY9_2
{
    class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name}이(가) 음식을 먹고 있습니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "바둑스"; //부모 클래스 속성 사용가능
            myDog.Eat();    //부모 클래스 매서드 호출
            myDog.Bark();   //자신의 매서드 호출
        }


    }
}
