using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TEST
{
    public class Field
    {
        Player fplayer = null;
        //Monster fmonster = null;
        INFO ifmonster = null;
        Monster fmonster = null;
        public void SetPlayer(ref Player sPlayer) { fplayer = sPlayer; }

        public void Progress()
        {
            while (true)
            {
                Console.Clear();
                fplayer.Render();
                LevelSelect();

                int level = int.Parse(Console.ReadLine());
                ifmonster = new INFO();
                fmonster = new Monster();
                if (level == 4)
                    break;
                switch (level)
                {
                    case 1:
                        ifmonster.strName = "초급 몬스터";
                        ifmonster.Attack = 5;
                        ifmonster.HP = 20;
                        break;
                    case 2:
                        ifmonster.strName = "중급 몬스터";
                        ifmonster.Attack = 10;
                        ifmonster.HP = 40;
                        break;
                    case 3:
                        ifmonster.strName = "고급 몬스터";
                        ifmonster.Attack = 15;
                        ifmonster.HP = 60;
                        break;
                    
                }

                fmonster.SetMonster(ifmonster);
                fmonster.Render();
                Fight();
            }
        }

        //몬스터 설정
        public void monsterLevel()
        {

        }
        
        public void LevelSelect()
        {
            Console.WriteLine("1. 초보");
            Console.WriteLine("2. 중수");
            Console.WriteLine("3. 숙련");
            Console.WriteLine("4. 뒤로가기");
            Console.WriteLine("===========================");
            Console.WriteLine("난이도를 설정하세요 : ");
        }

        public void Fight()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                fplayer.Render();
                fmonster.Render();

                Console.WriteLine("1.공격,   2.도망 : ");
                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    fplayer.SetDamage(fmonster.GetMonster().Attack);
                    fmonster.SetDamage(fplayer.GetInfo().Attack);

                    if (fplayer.GetInfo().HP <= 0)
                    {
                        fplayer.SetHP(100);
                        break;
                    }
                }
                if(input == 2|| fmonster.GetMonster().HP <= 0)
                {
                    fmonster = null;
                    break;
                }
            }
        }

        public Field() { }
        ~Field() { }
    }
}
