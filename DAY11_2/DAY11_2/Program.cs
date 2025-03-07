using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAY11_2
{

    class Character
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        //이벤트 정의 - 캐릭터가 데미지를 입었을 때 발생
        //EventHandler는 C# 에서 제공하는 기본 델리게이트 타입
        //이벤트는 외부에서 직접 호출할 수 없고 , +=과 -= 연산자로만 접근가능
        public event EventHandler OnDamaged;

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            //체력감소
            Health -= amount;
            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은체력 : {Health}");
            //이벤트 발생 (구독자가 있는 경우에만)
            //?. 연산자는 OnDamaged가 null이 아닐 때만 Invoke 메서드 호출
            //EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤트 인자
            OnDamaged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        //이벤트 핸들러 메서드
        //EventHandler 델리게이트와 일치하는 시그니처를 가져야함
        //sender : 이벤트를 발생시킨 객체 (여기서는 Character객체)
        //e: 이벤트와 관련된 추가 데이터(여기서는 사용하지 않음)
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            //sender를 character 타입으로 형변환
            Character character = (Character)sender;
            Console.WriteLine($"이벤트 알림 : {character.Name}이 데미지를 입었습니다." +
                $"현재 체력 : {character.Health}");
        }
        
        static void Main(string[] args)
        {
            //캐릭터 생성
            Character hero = new Character("용사", 100);
            hero.OnDamaged += Hero_OnDamaged;

            //데미지 입히기
            //TakeDamage 메서든 내에서 OnDamaged 이벤트가 발생함
            hero.TakeDamage(30);

            //이벤트 구독 취소 -=
            //더이상 이벤트 발생시 메서드가 호출되지 않음
            hero.OnDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 구독 취소");
            hero.TakeDamage(20);
            
        }
    }
}
