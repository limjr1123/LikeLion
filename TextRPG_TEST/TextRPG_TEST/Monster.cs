using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TEST
{

    public class Monster
    {
        INFO monster = null;

        public INFO GetMonster()
        {
            return monster;
        }
        public void SetDamage(int AD)
        {
            monster.HP -= AD;
        }

        public void SetMonster(INFO iMonster)
        {
            monster = iMonster;
        }

        public void Render()
        {
            Console.WriteLine("몬스터등급: " + monster.strName);
            Console.WriteLine("체력 : " + monster.HP + " 공격력 : " + monster.Attack);
            Console.WriteLine("===========================");

        }

        public Monster() { }
        ~Monster() { }

    }
}
