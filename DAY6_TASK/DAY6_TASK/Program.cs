using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] player = new string[]
            {
                "->",">>>","->",
            };  //배열 문자열로 그리기

            int playerX = 0;
            int playerY = 11;

            ConsoleKeyInfo KeyInfo;
            Console.CursorVisible = false;

            Console.SetCursorPosition(playerX, playerY);

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; //  1/1000 

            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 200)
                {
                    Console.Clear();

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔 좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //콘솔 좌표 설정 플레이어X 플레이어Y
                        Console.WriteLine(player[i]);
                    }

                    KeyInfo = Console.ReadKey();

                    switch (KeyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 3) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                        case ConsoleKey.Escape: return; //ESC키로 종료
                    }
                }

                    
            } 
        }
    }
}
