using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY7_1
{
    //마린 클래스 만들기
    //이름 , 미네랄

    class Scv
    {
        public string Name;
        public int Mineral;

        public Scv()
        {
            Name = "Scv";
            Mineral = 50;
        }

        public Scv(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    class Marin
    {
        public string Name;
        public int Mineral;

        public Marin()
        {
            Name = "Marin";
            Mineral = 50;
        }
        public Marin(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }


    //배럭 클래스 생성
    // this 키워드 이용
    // this 자기 자신을 가르킨다.
    class Barracks
    {
        public string Name;
        public int Mineral;

        public Barracks()
        {
            Name = "Barracks";
            Mineral = 150;
        }

        public Barracks(string _name, int _mineral)
        {
            this.Name = _name;
            this.Mineral = _mineral;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    class Person
    {
        public string Name;
        public int Age;
        
        //3. 기본생성자
        //  클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //  클래스와 같은 이름 가지며, 변환형이 없다. (void도 사용하지 않음)
        //  객체를 만들 때 필요한 초기값을 설정할때 많이 사용한다.
        public Person() //오버로딩(overloading)
        {
            
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("기본 생성자 실행됨.");
        }


        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name + ", 나이 :"+ Age);
        }
    }

    //미네랄 클래스 만들기
    //Minearal 1500 default
    //7개
    //클래스화

    class Mineral
    {
        public string Name;
        public int Recource;

        public Mineral()
        {
            Name = "mineral";
            Recource = 1500;
        }

        public Mineral(string Name, int Recource)
        {
            this.Name = Name;
            this.Recource = Recource;
        }

        public void ShowInfo()
        {
            Console.WriteLine("이름 : " + Name + " ,자원 :" + Recource);
        }

    }

    //Game 클래스 생성
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄 : {mineral}, 가스 :{gas}, 인구수 :{charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////1. 내장형 함수 (시간)
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"Current Date and Time:{now}"); //현재 날짜 시간   form : 2025-02-28 오전 9:29:43

            //TimeSpan duration = new TimeSpan(1, 30, 0); //1시간 30분   form : 01:30:00
            //Console.WriteLine($"Duration :{duration}");

            ////2. 클래스
            //// 데이터 모음
            //Person p1 = new Person("철수", 25);   //객체 생성 instance
            //p1.ShowInfo();

            //Person p2 = new Person("영희", 30);
            //p2.ShowInfo();


            Marin marin = new Marin("불꽃마린",100);
            Scv scv = new Scv("불꽃마린", 70);
            Barracks barracks = new Barracks();
            Mineral mineral = new Mineral();

            Mineral[] minerals = new Mineral[7];

            for(int i = 0; i <minerals.Length; i++)
            {
                minerals[i] = new Mineral();
                minerals[i].ShowInfo();
            }

            marin.ShowInfo();
            scv.ShowInfo();
            barracks.ShowInfo();
            mineral.ShowInfo();

            //Game 
            Game.charCount = 4;
            Game.gas = 0;
            Game.mineral = 50;

            Game g = new Game();
            Game.ShowInfo();
        }
    }
}
