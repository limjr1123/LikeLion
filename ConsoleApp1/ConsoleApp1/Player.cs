using System;

namespace ConsoleApp1
{
    public class Player
    {
        public INFO player;

        public INFO SetPlayer()
        {
            return player;
        }

        public void SelectJob()
        {
            Console.WriteLine("===================용사 키우기=================");
            Console.WriteLine("용사를 선택 하세요. (1. 전사 ,2. 마법사, 3. 도적)");
            int num = int.Parse(Console.ReadLine());

            player = new INFO();

            switch (num)
            {
                case 1:
                    player.strName = "전사";
                    player.AD = 10;
                    player.HP = 120;
                    break;
                case 2:
                    player.strName = "마법사";
                    player.AD = 15;
                    player.HP = 90;
                    break;
                case 3:
                    player.strName = "도적";
                    player.AD = 13;
                    player.HP = 100;
                    break;
                case 4:
                    break;
            }
        }

        public void PlayerInfoPrint()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"직업 : {player.strName}");
            Console.WriteLine($"공격력 : {player.AD}");
            Console.WriteLine($"체력 : {player.HP}");
            Console.WriteLine("===================");
        }
    }
}
