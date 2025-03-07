using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TEST
{

    public class Player
    {
        public INFO player ;

        public INFO GetInfo()
        {
            return player;
        }

        public void SetHP(int HP)
        {
            player.HP = HP;
        }

        public void SetDamage(int AD)
        {
            player.HP -= AD;
        }

        public void SelectJob()
        {
            player = new INFO();

            Console.WriteLine("직업을 선택하세요. (1. 전사, 2. 마법사, 3. 도적)");
            int num = 0;
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    player.strName = "전사";
                    player.Attack = 10;
                    player.HP = 120;
                    break;
                case 2:
                    player.strName = "마법사";
                    player.Attack = 20;
                    player.HP = 70;
                    break;
                case 3:
                    player.strName = "도적";
                    player.Attack = 15;
                    player.HP = 85;
                    break;
            }
            Render();
        }

        public void Render()
        {
            Console.WriteLine("===========================");
            Console.WriteLine("직업 : "+ player.strName);
            Console.WriteLine("체력 : " + player.HP + "   공격력 : " + player.Attack);
            Console.WriteLine("===========================");

        }

        public Player() { }
        ~Player() { }
    }
}
