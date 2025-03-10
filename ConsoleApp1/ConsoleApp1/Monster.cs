using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Monster
    {
        public INFO monster;

        public void SetMonster(INFO iMonster)
        {
            monster.strName = iMonster.strName;
            monster.AD = iMonster.AD;
            monster.HP = iMonster.HP;
        }


        public void MonsterInfoPrint(INFO monster)
        {
            Console.WriteLine($"몬스터 : {monster.strName}");
            Console.WriteLine($"공격력 : {monster.AD}");
            Console.WriteLine($"체력 : {monster.HP}");
            Console.WriteLine("===================");
        }
    }
}