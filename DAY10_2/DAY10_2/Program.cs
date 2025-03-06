using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_2
{
    //1. 추상클래스 (Abstract Class)?
    //추상클래스는 객체를 생성할수 없는 클래스로, 상속을 통해서만 사용할 수있습니다.
    //공통적인 기능을 정의하고, 상속받은 클래스가 이를 구현하도록 강제할때 사용됩니다.
    //abstract 키워드를 사용
    //추상 메서드는 선언만 하고, 구현은 하지 않습니다.
    //상속받은 클래스는 반드시 구현해야한다.



    //추상 매서드 (구현X , 상속받은 클래스가 구현)
    abstract class Animal
    {
        public abstract void MakeSound();

        //일반 매서드 (공통 기능 제공)
        public void Sleep()
        {
            Console.WriteLine("동물이 잠을 잔다.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("야옹!");
        }
    }

    //2. 부모클래스의 생성자 호출
    class Parent
    {
        protected string name;
        public Parent(string name)
        {
            this.name = name;
            Console.WriteLine("부모생성자"+ name); // 2) 실행
        }
    }

    class Child : Parent
    {
        private int age;
        public Child() : base("하하하하하성공") //1)부모 생성자 호출
        {
            Console.WriteLine("자식 생성자 호출"); // 3) 실행
        }
        public Child(string name, int age) : base(name)  //1
        {
            this.age = age;
            Console.WriteLine($"자식 생성자: 나이 = {age}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {name}, 나이 : {age} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Animal myDog = new Dog();
            //myDog.MakeSound();
            //myDog.Sleep();

            //Animal myCat = new Cat();
            //myCat.MakeSound();
            //myCat.Sleep();

            ////2. 부모 생성자 
            //Child child = new Child();  //0) 객체 생성 시작

            Child child = new Child("홍길동", 25);
            child.ShowInfo();
        }
    }
}
