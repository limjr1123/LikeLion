using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_TASK
{
    //1. SetMonster 몬스터 정보 세팅
    //2. SetDamage  몬스터가 받은 피해
    //3. GetMonster 몬스터 현재 상태 get
    //4. Render     현재 상태 전달

    public class Monster
    {
        public Info minfo;


        //1.SetMonster 몬스터 정보 세팅
        public void SetMonster(Info MonInfo)
        {
            minfo = MonInfo;
        }
        //2. SetDamage 몬스터가 받은 피해
        public void SetDamage(int AD)
        {
            minfo.HP -= AD;
        }
        //3. GetMonster 몬스터 현재 상태 get
        public Info GetMonster()
        {
            return minfo;
        }

        public void Render()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("몬스터 난이도 : " + minfo.className);
            Console.WriteLine("몬스터 체력 : " + minfo.HP);
            Console.WriteLine("몬스터 공격력 : " + minfo.AD);
            Console.WriteLine("=================================");
        }

        public Monster() { }
        ~Monster() { }
    }
}
