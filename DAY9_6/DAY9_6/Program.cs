using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY9_6
{

    //1. up/down casting
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }

    //2. base
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모클래스 메시지");
        }
    }

    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식클래스 메시지");
            base.ShowMessage(); //부모함수 실행
        }
    }

    //3. protected
    class Player
    {
        protected string Name;  //protected 부모/자식 상속관계에서만 사용하고 싶을때
        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("부모 생성자 입니다.");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizard : Player
    {
        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("자식 생성자 입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////1. up/down casting
            //Animal myAnimal = new Dog(); //업캐스팅 - 부모 메모리 + 자식 메모리 할당
            //myAnimal.Speak();   //Speak함수 확인 - virtual 보고 overried 함수로 이동 -> 멍멍!   

            ////myAnimal.WagTail(); //오류

            //Dog myDog = (Dog)myAnimal;  //다운캐스팅 - 

            //myDog.WagTail();

            ////2. base
            //Child child = new Child();
            //child.ShowMessage();


            //Player p = new Player();
            //p.Show();

            Wizard wizard = new Wizard();
            wizard.Show();

            //부모 생성자 입니다. - 부모 먼저 생성자 구동
            //자식 생성자 입니다.
            //마법사
        }
    }
}
