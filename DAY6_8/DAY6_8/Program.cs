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
        static void Main(string[] args)
        {
            //int x = 10, y = 10;
            //ConsoleKeyInfo KeyInfo;
            //Console.CursorVisible = false;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("●");

            //    KeyInfo = Console.ReadKey(true); //키 입력 받기

            //    //방향키 입력에 따른 죄표 변경
            //    switch (KeyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow: if (y > 0) y--; break;
            //        case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 1) y++; break;
            //        case ConsoleKey.LeftArrow: if (x > 0) x--; break;
            //        case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
            //        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
            //        case ConsoleKey.Escape: return; //ESC키로 종료

            //    }

            //}


            string[] player = new string[]
            {
                "->",
                ">>>",
                "->",
            };  //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;

            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; //  1/1000 

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 200)
                {
                    //Console.WriteLine("1초 루프");
                    Console.Clear();

                    KeyInfo = Console.ReadKey(true); //키 입력 받기
                                                     //방향키 입력에 따른 죄표 변경
                    switch (KeyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 3) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return; //ESC키로 종료
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔 좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //콘솔 좌표 설정 플레이어X 플레이어Y
                        Console.WriteLine(player[i]);
                    }
                    prevSecond = currentSecond; //이전 시간 업데이트
                }
            }


        }
    }
}
