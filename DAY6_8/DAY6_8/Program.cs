using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAY6_8
{
    class Program
    {

        struct PlayerPosition
        {
            public int x;
            public int y;
        }

        static void movePoint(ConsoleKeyInfo keyInfo, int x ,  int y)
        {
            
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow: if (y > 0) y--; break;
                case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
                case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                case ConsoleKey.Escape: return; //ESC키로 종료 
            }
        }

        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25); // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(80, 25); // 버퍼 크기도 동일하게 설정 (스크롤 방지)
            
            //배열 문자열로 player 만들기
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            };

            //plater 초기 위치
            PlayerPosition position;
            position.x = 0;
            position.y = 12;

            //int playerX = 0;
            //int playerY = 11;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            //시간 1초루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; // 1/1000    1000일때 1초

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 150)
                {
                    Console.Clear();


                    keyInfo = Console.ReadKey(true); //키 입력 받기 (화면 출력 X)

                    movePoint(keyInfo, position.x, position.y);
                    
                    //switch (keyInfo.Key)
                    //{
                    //    case ConsoleKey.UpArrow: if (position.y > 0) position.y--; break;
                    //    case ConsoleKey.DownArrow: if (position.y < Console.WindowHeight - 1) position.y++; break;
                    //    case ConsoleKey.LeftArrow: if (position.x > 0) position.x--; break;
                    //    case ConsoleKey.RightArrow: if (position.x < Console.WindowWidth - 1) position.x++; break;
                    //    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    //    case ConsoleKey.Escape: return; //ESC키로 종료 

                    //        //    //case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                    //        //    //case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                    //        //    //case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                    //        //    //case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 3) playerX++; break;
                    //        //    //case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    //        //    //case ConsoleKey.Escape: return; //ESC키로 종료
                    //}
                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(position.x, position.y + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);

                        ////콘솔 좌표 설정 플레이어X 플레이어Y
                        //Console.SetCursorPosition(playerX, playerY + i);
                        ////콘솔 좌표 설정 플레이어X 플레이어Y
                        //Console.WriteLine(player[i]);
                    }

                    prevSecond = currentSecond;//이전 시간 업데이트
                }
            }





        }
    }
}
