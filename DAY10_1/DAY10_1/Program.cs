using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//1. namespace
using Hello;

namespace DAY10_1
{

    class Person
    {
        public string Name; //필드 클래스의 데이터를 저장하는 멤버
        public int Age;
        //public void SetName(string n)
        //{
        //    name = n;
        //}
        //public string GetName()
        //{
        //    return name;
        //}

        public Person() //생성자
        {
            Name = "Unknown";
        }
        public Person(string name) //생성자
        {
            Name = name;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
    }

    //3. 소멸자
    class MyResource
    {
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }


    class Program
    {
        //4. 변수에 ref 사용
        static void Increase(ref int x)
        {
            x++;
        }
        //5. out : 반환이 여러개일때 유용하다 . 반드시 할당해야 하기 때문에 실수하는 상황을 방지할 수 있다
        static void OutFunc(int a , int b , out int x, out int y)
        {
            x = a;
            y = b;
        }

        static void Main(string[] args)
        {
            //1. namespace
            Say sa = new Say();

            Person p = new Person();    //객체로 만들기 인스턴스
            //p.name = "Alice";           //필드에 값넣기
            Person p1 = new Person("Bob");
            Person p2 = new Person("카타리나", 20);
            
            ////3. 소멸자
            //MyResource r = new MyResource();    //GC에 의해 나중에 소멸자 호출

            Console.WriteLine(p.Name + "," + p.Age);
            Console.WriteLine(p1.Name + "," + p1.Age);
            Console.WriteLine(p2.Name + "," + p2.Age);


            //4. 변수에 ref 사용
            int a = 10;
            int b = 20;
            
            //Increase(ref a);
            //Console.WriteLine("A의 값: "+a);

            int x,y;
            OutFunc(a, b, out x, out y);
            Console.WriteLine( "x:" + x +", y:"+y);
            
        }
    }
}

//1. namespace
namespace Hello
{
    class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }
    }
}
