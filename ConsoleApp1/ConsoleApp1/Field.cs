using System;

namespace ConsoleApp1
{
    public class Field
    {
        Player fPlayer;
        Monster PMonster = new Monster();
        INFO player = null;

        public void SetPlayer (ref Player pPlayer) { fPlayer = pPlayer; }
        public void FieldSelect()
        {
            while (true)
            {
                Console.Clear();
                fPlayer.PlayerInfoPrint();
                Console.WriteLine("1. 초보 사냥터");
                Console.WriteLine("2. 중급 사냥터");
                Console.WriteLine("3. 고급 사냥터");
                Console.WriteLine("4. (뒤로 가기)");
                Console.WriteLine("===================");
                Console.Write("사냥터 선택 :");
                int num3 = int.Parse(Console.ReadLine());
                INFO monster = new INFO();

                if (num3 == 4)
                {
                    break;
                }
                switch (num3)
                {
                    case 1:
                        monster.strName = "초보 몬스터";
                        monster.AD = 5;
                        monster.HP = 20;
                        break;
                    case 2:
                        monster.strName = "중급 몬스터";
                        monster.AD = 10;
                        monster.HP = 35;
                        break;
                    case 3:
                        monster.strName = "고급 몬스터";
                        monster.AD = 15;
                        monster.HP = 50;
                        break;

                }
                while (true)
                {
                    Console.Clear();
                    fPlayer.PlayerInfoPrint();
                    PMonster.MonsterInfoPrint(monster);
                    
                    Console.WriteLine("1. 전투    2. 나가기");
                    Console.Write("행동을 선택하세요 : ");
                    int num4 = int.Parse(Console.ReadLine());
                    
                    player = fPlayer.SetPlayer();
                    int playerHP = player.HP - monster.AD;
                    int monHP = monster.HP - player.AD;

                    if (num4 == 1)
                    {
                        player.HP = playerHP;
                        monster.HP = monHP;

                        if (playerHP <= 0)
                        {
                            player.HP = 100;
                            break;
                        }

                        if (monHP <= 0)
                        {
                            break;
                        }
                    }
                    else if (num4 == 2)
                    {
                        break;
                    }
                }

            }
        }
    }
}