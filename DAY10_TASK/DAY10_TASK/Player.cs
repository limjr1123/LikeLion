using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_TASK
{
    //1. GetInfo    플레이어 정보 확인
    //2. SetDamage  플레이어가 입은 데미지
    //3. SetHp      플레이어 HP 계산
    //4. SelectJob  직업 선택
    //5. Render     플레이어 실시간 정보 확인
    

    public class Player
    {
        public Info pinfo;

        //1. GetInfo    플레이어 정보 확인
        public Info GetInfo()
        {
            return pinfo;
        }

        //2. SetDamage  플레이어가 입은 데미지
        public void setDamage(int AD)
        {
             pinfo.HP -= AD;
        }

        //3. SetHp      플레이어 HP 계산
        public void SetHp(int HP)
        {
            pinfo.HP = HP;
        }



        //4. SelectJob  직업 선택
        public void SelectJob()
        {
            Console.Write("직업을 선택하세요.(1. 전사, 2. 마법사, 3. 도적) :");
            int selectedNum = int.Parse(Console.ReadLine());

            switch (selectedNum)
            {
                case 1:
                    pinfo.className = "전사";
                    pinfo.HP = 120;
                    pinfo.AD = 10;
                    break;
                case 2:
                    pinfo.className = "마법사";
                    pinfo.HP = 80;
                    pinfo.AD = 25;
                    break;
                case 3:
                    pinfo.className = "전사";
                    pinfo.HP = 90;
                    pinfo.AD = 20;
                    break;
            }
        }

        //5. Render     플레이어 실시간 정보 확인
        public void Render()
        {
            Console.WriteLine( "=================================");
            Console.WriteLine( "직업 : " + pinfo.className);
            Console.WriteLine( "체력 : " + pinfo.HP);
            Console.WriteLine( "공격력 : " + pinfo.AD);
            Console.WriteLine( "=================================");
        }

        public Player() { }
        ~Player() { }

    }
}