using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_TEXTRPG
{
    public class Monster
    {
        public INFO m_tMonster; //몬스터 데이터

        public void SetDamage(int iAttack) { m_tMonster.iHp -= iAttack; } //들어오는 인자값으로  hp갑소
        public void SetMonster(INFO tMonster) { m_tMonster = tMonster; }
        public INFO GetMonster() { return m_tMonster; }

        public void Render()
        {
            Console.WriteLine("+====================");
            Console.WriteLine("몬스터 이름 : " + m_tMonster.strName);
            Console.WriteLine("체력 : " + m_tMonster.iHp + "공격력 : " + m_tMonster.iAttack);
            Console.WriteLine("+====================");
        }

        public Monster()
        {

        }
        ~Monster() { }
    }
}
