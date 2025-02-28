using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DAY7_3.Player;

namespace DAY7_3
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴

        public int playerX;         //player x 좌표
        public int playerY;         //player y 좌표
        public BULLET[] PlayerBullet = new BULLET[20];
        public BULLET[] PlayerBullet2 = new BULLET[20];
        public BULLET[] PlayerBullet3 = new BULLET[20];

        //아이템 클래스 사용
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;




        public Player() //생성자
        {
            //플레이어 위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++)    //총알 초기화
            {
                PlayerBullet[i] = new BULLET();
                PlayerBullet[i].x = 0;
                PlayerBullet[i].y = 0;
                PlayerBullet[i].fire = false;

                PlayerBullet2[i] = new BULLET();
                PlayerBullet2[i].x = 0;
                PlayerBullet2[i].y = 0;
                PlayerBullet2[i].fire = false;

                PlayerBullet3[i] = new BULLET();
                PlayerBullet3[i].x = 0;
                PlayerBullet3[i].y = 0;
                PlayerBullet3[i].fire = false;
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();

            //플레이어를 그린다.
            PlayerDraw();

            //점수 UI
            UIscore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }

        }

        public void KeyControl()
        {
            int pressKey;   //정수형 변수 선언 키값 받음

            if (Console.KeyAvailable)   //키가 눌렀을때 true
            {
                pressKey = _getch(); //C언어 함수 - ASKII값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바 ( 총알 발사)
                        for(int i = 0; i<20; i++)
                        {
                            if (PlayerBullet[i].fire == false)
                            {
                                PlayerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                PlayerBullet[i].x = playerX + 5;
                                PlayerBullet[i].y = playerY + 1;
                                //한발식 쏘겠다.
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {
                            if (PlayerBullet2[i].fire == false)
                            {
                                PlayerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                PlayerBullet2[i].x = playerX + 5;
                                PlayerBullet2[i].y = playerY;
                                //한발식 쏘겠다.
                                break;
                            }
                        }

                        for (int i = 0; i < 20; i++)
                        {

                            if (PlayerBullet3[i].fire == false)
                            {
                                PlayerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                PlayerBullet3[i].x = playerX + 5;
                                PlayerBullet3[i].y = playerY + 2;
                                //한발식 쏘겠다.
                                break;
                            }
                        }
                        break;
                }
            }
            
        }


        public void BulletDraw()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i<20; i++)
            {
                //미사일이 살아있는 상태
                if (PlayerBullet[i].fire == true)
                {
                    // 좌표설정 - 중간 위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(PlayerBullet[i].x - 1, PlayerBullet[i].y);

                    //총알 출력
                    Console.Write(bullet);
                    PlayerBullet[i].x++; //미사일 오른쪽으로 날아가기

                    if (PlayerBullet[i].x > 79)
                    {
                        PlayerBullet[i].fire = false;   //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw2()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (PlayerBullet2[i].fire == true)
                {
                    // 좌표설정 - 중간 위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(PlayerBullet2[i].x - 1, PlayerBullet2[i].y);

                    //총알 출력
                    Console.Write(bullet);
                    PlayerBullet2[i].x++; //미사일 오른쪽으로 날아가기

                    if (PlayerBullet2[i].x > 78)
                    {
                        PlayerBullet2[i].fire = false;   //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (PlayerBullet3[i].fire == true)
                {
                    // 좌표설정 - 중간 위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(PlayerBullet3[i].x - 1, PlayerBullet3[i].y);

                    //총알 출력
                    Console.Write(bullet);
                    PlayerBullet3[i].x++; //미사일 오른쪽으로 날아가기

                    if (PlayerBullet3[i].x > 78)
                    {
                        PlayerBullet3[i].fire = false;   //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->", ">>>","->"
            };  //배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정 플레이어x 플레이어y
                Console.SetCursorPosition(playerX, playerY + i);

                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        //충돌 처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20
            for(int i = 0; i < 20; i++)
            {
                if (PlayerBullet[i].fire == true)
                {
                    //미사일과 적의 y축값이 같을때
                    if (PlayerBullet[i].y == enemy.enemyY)
                    {
                        if (PlayerBullet[i].x >= (enemy.enemyX - 1) && PlayerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            //충돌

                            item.ItemLife = true;
                            item.ItemX = enemy.enemyX;
                            item.ItemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            PlayerBullet[i].fire = false;   //미사일도 준비상태로 만들어 주기

                            //스코어 
                            Score += 100;
                        }
                    }
                }
            }

            //미사일2 20
            for (int i = 0; i < 20; i++)
            {
                if (PlayerBullet2[i].fire == true)
                {
                    //미사일과 적의 y축값이 같을때
                    if (PlayerBullet2[i].y == enemy.enemyY)
                    {
                        if (PlayerBullet2[i].x >= (enemy.enemyX - 1) 
                            && PlayerBullet2[i].x <= (enemy.enemyX + 1))
                        {
                            //충돌 
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            PlayerBullet2[i].fire = false;   //미사일도 준비상태로 만들어 주기

                            //스코어 
                            Score += 100;
                        }
                    }
                }
            }

            //미사일3 20
            for (int i = 0; i < 20; i++)
            {
                if (PlayerBullet3[i].fire == true)
                {
                    //미사일과 적의 y축값이 같을때
                    if (PlayerBullet3[i].y == enemy.enemyY)
                    {
                        if (PlayerBullet3[i].x >= (enemy.enemyX - 1) 
                            && PlayerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            //충돌 
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);
                            PlayerBullet3[i].fire = false;   //미사일도 준비상태로 만들어 주기

                            //스코어 
                            Score += 100;
                        }
                    }
                }
            }
        }

        //점수판 UI
        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if(playerY+1 == item.ItemY)
            {
                if(playerX >= item.ItemX-2 && playerX <= item.ItemX + 2)
                {
                    item.ItemLife = false;
                    if (itemCount < 3)
                        itemCount++;
                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        PlayerBullet[i] = new BULLET();
                        PlayerBullet[i].x = 0;
                        PlayerBullet[i].y = 0;
                        PlayerBullet[i].fire = false;

                        PlayerBullet2[i] = new BULLET();
                        PlayerBullet2[i].x = 0;
                        PlayerBullet2[i].y = 0;
                        PlayerBullet2[i].fire = false;

                        PlayerBullet3[i] = new BULLET();
                        PlayerBullet3[i].x = 0;
                        PlayerBullet3[i].y = 0;
                        PlayerBullet3[i].fire = false;
                    }
                }
            }
        }



        public class Enemy
        {
            public int enemyX;
            public int enemyY;

            public Enemy()
            {
                enemyX = 77;
                enemyY = 12;
            }

            public void EnemyDraw() //적 그리기
            {
                String enemy = "<-0->";
                Console.SetCursorPosition(enemyX, enemyY);
                Console.Write(enemy);
            }

            public void EnemyMove() //적 움직임
            {
                Random rand = new Random(); //랜덤
                enemyX--;

                if(enemyX <2 )//화면 넘어가면 세로 좌표 잡기
                {
                    enemyX = 77;
                    enemyY = rand.Next(2, 22);  //2~21
                }
            }


        }
    }

    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int ItemX = 0;
        public int ItemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(ItemX, ItemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }

        public void ItemMove()
        {
            //if(ItemX <=1 || ItemY <= 1)
            //{
            //    ItemLife = false;
            //}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);


            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            //유니티 처럼 속도 프레임속도
            int dwTime = Environment.TickCount; // 1/1000 초가 흐른다.

            while (true)
            {

                //0.05초 지연
                if(dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //총알 그리기
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else 
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    //적이동
                    enemy.EnemyDraw();
                    //적 그리기
                    enemy.EnemyMove();

                    //충돌 처리
                    player.ClashEnemyAndBullet(enemy);

                }
            }
        }
    }
}
