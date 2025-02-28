using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_2
{
    //// 1. getter,setter
    //class Person
    //{
    //    private string name;

    //    //값 설정하기(setter)
    //    public void SetName(string newName)
    //    {
    //        name = newName;
    //    }

    //    //값 가져오기(Getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}


    //// 2. C#의 getter,setter
    //class Person
    //{
    //    private string name;  //내부 변수
    //    public string Name    //프로퍼티
    //    {
    //        get { return name; }    //Getter
    //        set { name = value; }   //Setter
    //    }
    //}

    //// 3. 프로퍼티 자동 구현
    //class Person
    //{
    //    private int count = 100;
    //    public string Name { get; set; }    //자동 구현


    //    public int Count
    //    {
    //        get { return count; }   //읽기만 가능
    //    }

    //    public float Balance { get; private set; }  //외부 변경 불가
    //    public void AddBal()
    //    {
    //        Balance += 100;
    //    }
    //}

    //마린 클래스
    //프로퍼티 이용해서 이름과 미네랄을 만드시오. 이름 마린 미네랄 50
    class Marine
    {
        public string Name { get; set; }
        public int Mineral { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            // 1. getter,setter
            //C#에서 Get/Set 방식의 함수와 프로퍼티 비교
            //Person p = new Person();
            //p.SetName("길동이");
            //Console.WriteLine("이름:" + p.GetName());

            // 2. C#의 getter,setter
            //Person p = new Person();
            //p.Name = "길동이";
            //Console.WriteLine("이름:" + p.Name);

            //// 3. 프로퍼티 자동 구현
            //Person p = new Person();
            //p.Name = "길동이";
            //p.AddBal();
            //Console.WriteLine("이름:" + p.Name + ", Count :" + p.Count + "Balance : " + p.Balance);

            Marine marine = new Marine();

            marine.Name = "마린보이";
            marine.Mineral = 50;
            Console.WriteLine("이름:" + marine.Name + ", Mineral :" + marine.Mineral);

        }
    }
}
