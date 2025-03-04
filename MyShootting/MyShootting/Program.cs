using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static MyShootting.Program;

namespace MyShootting
{
    public class ReadyScrean
    {
        public void FrameDraw()
        {
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.
            do
            {
                dwTime = Environment.TickCount;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("┃                                                ┃");
                }

                Console.WriteLine("┃ ####  #    #   #        ###   #  # #####   ##  ┃");
                Console.WriteLine("┃ #     #    #   #         #    ## #   #    #  # ┃");
                Console.WriteLine("┃ #     #     # #          #    ## #   #    #  # ┃");
                Console.WriteLine("┃ ###   #      #           #    # ##   #    #  # ┃");
                Console.WriteLine("┃ #     #      #           #    # ##   #    #  # ┃");
                Console.WriteLine("┃ #     #      #           #    #  #   #    #  # ┃");
                Console.WriteLine("┃ #     ####   #          ###   #  #   #     ##  ┃");
                Console.WriteLine("┃                                                ┃");
                Console.WriteLine("┃           ##   ###    ##    ##   ####          ┃");
                Console.WriteLine("┃          #  #  #  #  #  #  #  #  #             ┃");
                Console.WriteLine("┃          #     #  #  #  #  #     #             ┃");
                Console.WriteLine("┃           ##   ###   ####  #     ###           ┃");
                Console.WriteLine("┃             #  #     #  #  #     #             ┃");
                Console.WriteLine("┃          #  #  #     #  #  #  #  #             ┃");
                Console.WriteLine("┃           ##   #     #  #   ##   ####          ┃");

                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine("┃                                                ┃");
                }

                Console.WriteLine("┃         - 시작하려면 엔터를 누르세요 -         ┃");

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("┃                                                ┃");
                }

                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            } while (Console.ReadLine() == null);
        }
    }
    public class Frame
    {
        public void FrameDraw()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 0; i < 36; i++)
            {
                Console.WriteLine("┃                                                ┃");
            }
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }
    }

    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class BossBullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 : 하나의 키를 입력받는 함수

        public int playerX;   //플레이어 X좌표
        public int playerY;   //플레이어 Y좌표
        public int score = 0;   //플레이어 점수
        public Bullet[] playerBullet = new Bullet[35];
        ////수정중 bullet Legacy
        //public Bullet[] playerBullet2 = new Bullet[35];
        //public Bullet[] playerBullet3 = new Bullet[35];

        public Item item = new Item();
        public int itemCount = 0;
        int bulletPower = 1;

        public int playerLife = 3;    //플레이어 생명력
        public Player() //생성자
        {
            playerX = 25;
            playerY = 36;


            for (int i = 0; i < 30; i++) //총알 초기화
            {
                playerBullet[i] = new Bullet();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }
        }

        public void KeyControl()
        {
            int pressKey;  //입력된 키값 Ascii코드로 저장

            if (Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }
                switch (pressKey)
                {
                    case 72:  //위쪽방향 아스키코드                    
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        //왼쪽 화살표키
                        playerX = playerX - 2;
                        if (playerX < 1)
                            playerX = 1;
                        break;
                    case 77:
                        //오른쪽
                        //playerX++;
                        playerX = playerX + 2;
                        if (playerX > 45)
                            playerX = 45;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 37)
                            playerY = 37;
                        break;
                    case 32: //스페이스바
                        //총알 발사
                        for (int i = 0; i < 30; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 1
                                playerBullet[i].x = playerX + 2;
                                playerBullet[i].y = playerY - 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이얼를 그려준다.
            PlayerDraw();

            //UI점수
            UI();
            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                ClashItem();
            }
        }
        public void UI()
        {
            Console.SetCursorPosition(3, 38);
            Console.WriteLine("▶ SCORE :" + score.ToString("D8") + "  ▶ POWER : " + bulletPower + "   ▶ LIFE :" + playerLife);
        }
        //미사일 그리기
        public void BulletDraw()
        {
            string bullet;
            string bulletLv1 = "º";     //미사일모습
            string bulletLv2 = "º º";    //미사일모습
            string bulletLv3 = "ººº";   //미사일모습

            if (itemCount == 0)
            {
                bullet = bulletLv1;
                for (int i = 0; i < 30; i++)
                {
                    //미사일이 살아있는 상태
                    if (playerBullet[i].fire == true)
                    {
                        //좌표설정
                        Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                        //총알 출력
                        Console.Write(bullet);

                        playerBullet[i].y--; //미사일 위로 날리기

                        if (playerBullet[i].y < 2)
                        {
                            playerBullet[i].fire = false;  //미사일 false 다시 준비상태
                        }
                    }
                }
            }
            else if (itemCount == 1)
            {
                bullet = bulletLv2;
                for (int i = 0; i < 30; i++)
                {
                    //미사일이 살아있는 상태
                    if (playerBullet[i].fire == true)
                    {
                        //좌표설정
                        Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                        //총알 출력
                        Console.Write(bullet);

                        playerBullet[i].y--; //미사일 위로 날리기

                        if (playerBullet[i].y < 2)
                        {
                            playerBullet[i].fire = false;  //미사일 false 다시 준비상태
                        }
                    }
                }
            }
            else if (itemCount >= 2)
            {
                bullet = bulletLv3;
                for (int i = 0; i < 30; i++)
                {
                    //미사일이 살아있는 상태
                    if (playerBullet[i].fire == true)
                    {
                        //좌표설정
                        Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                        //총알 출력
                        Console.Write(bullet);

                        playerBullet[i].y--; //미사일 위로 날리기

                        if (playerBullet[i].y < 2)
                        {
                            playerBullet[i].fire = false;  //미사일 false 다시 준비상태
                        }
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string player = "§-⊙-§";
            Console.SetCursorPosition(playerX, playerY);
            Console.WriteLine(player);
        }

        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            if (itemCount == 0)
                bulletPower = 1;
            else if (itemCount == 1)
                bulletPower = 2;
            else if (itemCount >= 2)
                bulletPower = 3;

            //미사일20
            for (int i = 0; i < 30; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을때 
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        if (playerBullet[i].x >= enemy.enemyX && playerBullet[i].x <= (enemy.enemyX + 6)) //충돌
                        {
                            if (enemy.enemyLife > bulletPower)
                                enemy.enemyLife = enemy.enemyLife - bulletPower;
                            else if (enemy.enemyLife <= bulletPower)
                            {
                                if (bulletPower != 3)
                                    item.ItemLife = true;

                                item.itemX = enemy.enemyX + 3;
                                item.itemY = enemy.enemyY;

                                score += 100;

                                Random rand = new Random();
                                if (score <= 1000)
                                    enemy.enemyLife = 3;
                                else
                                    enemy.enemyLife = 9;
                                enemy.enemyX = rand.Next(5, 40);
                                enemy.enemyY = 2;
                            }
                            playerBullet[i].fire = false; //미사일도 준비상태로 만들어주기


                        }
                    }
                }
            }
        }

        public void ClashItem()
        {
            if (playerY == item.itemY)
            {
                if (item.itemX >= playerX && item.itemX <= playerX + 5)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 30; i++) //총알 초기화
                    {
                        playerBullet[i] = new Bullet();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;
                    }
                }
            }
        }
        public void CrashEnemyAndPlayer(Enemy enemy)
        {
            if (score <= 1000)
            {
                if (((playerX + 3) >= enemy.enemyX && playerX -3 <= enemy.enemyX)
                    && (playerY == enemy.enemyY))
                {
                    playerLife -= 1;

                    if (playerLife == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(15, 11);
                        Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                        Console.SetCursorPosition(15, 12);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 12);
                        Console.Write("Game Over");

                        Console.SetCursorPosition(15, 13);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 13);
                        Console.Write($"최종 점수:");
                        Console.SetCursorPosition(15, 14);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 14);
                        Console.Write("      " + score.ToString("D8"));
                        Console.SetCursorPosition(15, 15);
                        Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");

                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Random rand = new Random();
                    enemy.enemyX = rand.Next(5, 40);
                    enemy.enemyY = 2;
                    enemy.enemyLife = 3;
                }
            }
            else
            {
                if ((playerX + 5 >= enemy.enemyX && playerX - 5 <= enemy.enemyX)
                    && (playerY == enemy.enemyY))
                {
                    playerLife -= 1;

                    if (playerLife == 0)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(15, 11);
                        Console.Write("┏━━━━━━━━━━━━━━━━━━━┓");
                        Console.SetCursorPosition(15, 12);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 12);
                        Console.Write("Game Over");

                        Console.SetCursorPosition(15, 13);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 13);
                        Console.Write($"최종 점수:");
                        Console.SetCursorPosition(15, 14);
                        Console.Write("┃                   ┃");
                        Console.SetCursorPosition(17, 14);
                        Console.Write("      " + score.ToString("D8"));
                        Console.SetCursorPosition(15, 15);
                        Console.Write("┗━━━━━━━━━━━━━━━━━━━┛");

                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Random rand = new Random();
                    enemy.enemyX = rand.Next(5, 40);
                    enemy.enemyY = 2;
                    enemy.enemyLife = 3;
                }
            }

        }
    }
    public class Boss 
    {
        public int bossX;  //X좌표
        public int bossY;  //Y좌표
        public int bossLife;
        public int bossDirection;
        public Bullet[] BossBullet = new Bullet[35];
        public Bullet[] BossBullet2 = new Bullet[35];
        public BossBullet BossBullet3 ;


        int moveTimeing = 1;

        public Boss()
        {
            //적 좌표 초기화
            bossX  = 15;
            bossY  = 3;
            bossLife  = 45;
            bossDirection = 1;

            for (int i = 0; i < 35; i++) //총알 초기화
            {
                BossBullet[i] = new Bullet();
                BossBullet[i].x = 0;
                BossBullet[i].y = 0;
                BossBullet[i].fire = false;

                BossBullet2[i] = new Bullet();
                BossBullet2[i].x = 0;
                BossBullet2[i].y = 0;
                BossBullet2[i].fire = false;

                BossBullet3 =  new BossBullet();
                BossBullet3.x = 0;
                BossBullet3.y = 0;
                BossBullet3.fire = false;
            }

            for (int i = 0; i < 35; i++)
            {
                //미사일이 false 발사가능
                
                    BossBullet[i].fire = true;
                    //플레이어 앞에서 미사일 쏘기 + 5
                    BossBullet[i].x = bossX + 3;
                    BossBullet[i].y = bossY + 1;
                    //한발씩 쏘겠다.
                    break;
                
            }

            for (int i = 0; i < 35; i++)
            {
                //미사일이 false 발사가능
                if (BossBullet2[i].fire == false)
                {
                    BossBullet2[i].fire = true;
                    //플레이어 앞에서 미사일 쏘기 + 5
                    BossBullet2[i].x = bossX + 10;
                    BossBullet2[i].y = bossY + 1;
                    //한발씩 쏘겠다.
                    
                }
            }

            for (int i = 0; i < 35; i++)
            {
                //미사일이 false 발사가능
                if (BossBullet3.fire == false)
                {
                    BossBullet3.fire = true;
                    //플레이어 앞에서 미사일 쏘기 + 5
                    BossBullet3.x = bossX + 13;
                    BossBullet3.y = bossY + 1;
                    
                }
            }

        }

        public void BossDraw()
        {
            string[] boss = { "       __|__", "--@--@--(_)--@--@--" }; //문자열로 표현
            
            for(int i = 0;i < boss.Length; i++)
            {
                
                Console.SetCursorPosition(bossX, bossY+i); //좌표설정
                Console.WriteLine(boss[i]);//출력
            }
            
        }



        public void BossBulletDraw()
        {
            string bullet = "♨"; //미사일모습
            
            //20개
            for (int i = 0; i < 35; i++)
            {
                //미사일이 살아있는 상태
                if (BossBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(BossBullet[i].x - 1, BossBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    BossBullet[i].y++; //미사일 오른쪽으로 날라가기

                    if (BossBullet[i].y > 35)
                    {
                        BossBullet[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }
        public void BossBulletDraw2()
        {
            string bullet = "♨"; //미사일모습

            //20개
            for (int i = 0; i < 35; i++)
            {
                //미사일이 살아있는 상태
                if (BossBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(BossBullet2[i].x - 3, BossBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    BossBullet2[i].y++; //미사일 오른쪽으로 날라가기

                    if (BossBullet[i].y > 35)
                    {
                        BossBullet2[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }

        }
        public void BossBulletDraw3()
        {
            string bullet = "♨"; //미사일모습

            do
            {
                Console.SetCursorPosition(BossBullet3.x - 3, BossBullet3.y);
                Console.Write(bullet);
                BossBullet3.y++;
            } while (BossBullet3.y > 35);
            BossBullet3.fire = false;
            //플레이어 앞에서 미사일 쏘기 + 5
            BossBullet3.x = bossX + 13;
            BossBullet3.y = bossY + 1;

        }



        //public void BossMove()
        //{
        //    //andom rand = new Random(); //랜덤
        //    moveTimeing++;
        //    //bossX--;

        //    if (bossX > )

        //    do
        //    {
        //        do
        //        {
        //            bossX--;
        //        } while (bossX == 7);

        //        do
        //        {
        //            bossX++;
        //        } while (bossX == 20);
        //    } while (bossLife == 0);
        //}





    }

    public class Enemy //적 클래스
    {
        public int enemyX;  //X좌표
        public int enemyY;  //Y좌표
        public int enemyLife;

        int moveTimeing = 1;

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 14;
            enemyY = 2;
            enemyLife = 3;
        }

        public void EnemyDraw()//적그리기
        {
            string enemy = "<-[+]->"; //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력
        }

        public void EnemyDraw2()//적그리기
        {
            string enemy = "--@-[+]-@--"; //문자열로 표현
            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력
        }

        public void EnmeyMove(Player player)
        {
            Random rand = new Random(); //랜덤
            moveTimeing++;
            if (moveTimeing % 2 == 0)
            {
                enemyY++;
            }
            if (enemyY > 37)
            {
                if (player.score <= 1000)
                {
                    enemyLife = 3;
                }
                else
                {
                    enemyLife = 9;
                }
                enemyX = rand.Next(5, 40);
                enemyY = 2;

            }
        }
    }

    public class EnemyB //적 클래스
    {
        public int enemyX;  //X좌표
        public int enemyY;  //Y좌표
        public int enemyLife;

        int moveTimeing = 1;

        public EnemyB()
        {
            //적 좌표 초기화
            enemyX = 28;
            enemyY = 2;
            enemyLife = 3;
        }

        public void EnemyDraw()//적그리기
        {
            string enemy = "<-[+]->"; //문자열로 표현

            string enemy2 = "--@-[++]-@--";

            Console.SetCursorPosition(enemyX, enemyY); //좌표설정
            Console.Write(enemy);//출력
        }

        public void EnmeyMove(Player player)
        {
            Random rand = new Random(); //랜덤
            moveTimeing++;
            if (moveTimeing % 2 == 0)
            {
                enemyY++;
            }
            if (enemyY > 37)
            {
                if (player.score <= 1000)
                {
                    enemyLife = 3;
                }
                else
                {
                    enemyLife = 9;
                }
                enemyX = rand.Next(5, 40);
                enemyY = 2;
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;
        int moveTimeing = 1;
        public void ItemDraw()
        {
            ItemSprite = "⭐";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            moveTimeing++;
            if (moveTimeing % 2 == 0)
            {
                itemY++;
            }

            Console.SetCursorPosition(itemX, itemY);

            if (itemY > 38)
            {
                ItemLife = false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReadyScrean Screan = new ReadyScrean();

            

            //특수문자 보이게
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //커서 제거
            Console.CursorVisible = false;
            Screan.FrameDraw();

            Console.SetWindowSize(50, 40);
            Console.SetBufferSize(50, 40);


            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy();
            Enemy enemy2 = new Enemy();
            Boss boss = new Boss();
            Frame frame = new Frame();

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.
            int dwTime2 = Environment.TickCount;
            while (true)
            {
                //0.08초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();
                    //테두리
                    frame.FrameDraw();
                    //플레이어
                    player.GameMain();
                    //총알

                    player.BulletDraw();
                    if (player.score <= 1000)
                    {
                        enemy.EnmeyMove(player);//적이동
                        enemy.EnemyDraw();//적그리기

                        if (dwTime2 + 2000 < Environment.TickCount)
                        {
                            enemy2.EnmeyMove(player);//적이동
                            enemy2.EnemyDraw();//적그리기
                        }
                    }
                    else if (player.score > 1000)
                    {
                        enemy.EnmeyMove(player);//적이동
                        enemy.EnemyDraw2();//적그리기

                        if (dwTime2 + 2000 < Environment.TickCount)
                        {
                            enemy2.EnmeyMove(player);//적이동
                            enemy2.EnemyDraw2();//적그리기
                        }
                    }
                    else if (player.score > 2500)
                    {
                        boss.BossDraw();
                    }
                    //boss.BossDraw();
                    //boss.BossBulletDraw();
                    //boss.BossBulletDraw2();
                    //boss.BossBulletDraw3();

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                    player.ClashEnemyAndBullet(enemy2);
                    player.CrashEnemyAndPlayer(enemy);
                    player.CrashEnemyAndPlayer(enemy2);

                }
            }
        }
    }
}
