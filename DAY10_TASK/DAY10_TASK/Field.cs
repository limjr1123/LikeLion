using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAY10_TASK
{
    public class Field
    {
        Player fplayer = null;
        Monster fMonster = null;

        public void SetPlayer(ref Player pPlayer) { fplayer = pPlayer; }


        public void Progress()
        {
            int input = 0;

            Console.WriteLine("사냥터에 입장하였습니다.");
            Console.Write("난이도 선택 (1. 초보 사냥터, 2. 중수 사냥터, 3. 고수 사냥터) : ");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    fMonster = new Monster();
                    Info monster = new Info();
                    monster.className = "고블린";
                    monster.HP = 40;
                    monster.AD = 4;
                    break;

            }
        }

        public void Fight()
        {
            int input = 0;

            while (true)
            {
                fplayer.Render();
                fMonster.Render();

                Console.WriteLine("1.공격 2.도망 : "); //1,2 선택 표시
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    fplayer.setDamage(fMonster.GetMonster().AD);
                    fMonster.SetDamage(fplayer.GetInfo().AD);

                    if (fplayer.GetInfo().HP <= 0)
                    {
                        fplayer.SetHp(100);
                        break;
                    }
                }

                if (input == 2 || fMonster.GetMonster().HP <= 0)
                {
                    fMonster = null;
                    break; //탈출
                }
            }
            
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("=============");
            Console.WriteLine("맵을 선택하세요 : ");
        }
        public Field() { }
        ~Field() { }
    }
}
