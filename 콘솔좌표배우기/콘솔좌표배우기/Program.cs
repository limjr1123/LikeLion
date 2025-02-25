using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표배우기
{
    class Program
    {
        static void Main(string[] args)
        {
            ////콘솔 창 크기 설정
            //Console.SetWindowSize(80, 25);

            ////콘솔 버퍼 크기도 설정(스크롤 없이 고정된 창 유지)
            //Console.SetBufferSize(80, 25);

            //특수문자 보이게
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.CursorVisible = false; //커서 숨기기

            Console.Clear(); //화면 지우기

            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            for (int i = 1; i < 24; i++)
            {
                if (i == 10)
                {
                    Console.Write("┃                            🐖 돼지 키우기 🐖                                 ┃");
                }
                else if (i == 15)
                {
                    Console.Write("┃                            - press Enter key -                               ┃");
                }
                else
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("┃                                                                              ┃");
                }

            }
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.ReadKey();

            ConsoleKeyInfo cki;
            int x, y;
            int score = 0;
            x = 38;
            y = 11;


            // 햄버거 랜덤좌표 생성을 위한 객체 생성
            Random rand = new Random();

        restart:
            int starX = rand.Next(1, 75);
            int starY = rand.Next(2, 19);

            while (true)
            {
                Console.Clear();
                if (x == starX && y == starY)
                {
                    score++;
                    goto restart;
                }
                if (score < 5)
                    Console.WriteLine($"-돼지력 5 달성시 🐖로 진화. ({x},{y})");
                else if ( score < 10)
                    Console.WriteLine($"-돼지력 10 달성시 🐗로 진화. ({x},{y})");
                else
                    Console.WriteLine($"-최종 진화 완료. ({x},{y})");
                Console.WriteLine("-돼지력 : " + score);
                Console.SetCursorPosition(starX, starY);
                Console.Write("🍔");


                Console.SetCursorPosition(x, y);
                if (score < 5) 
                    Console.Write("🐷");
                else if (score < 10)
                    Console.Write("🐖");
                else
                    Console.Write("🐗");

                cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y < 3) break;
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (y > 19) break;
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x < 1) break;
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (x > 75) break;
                        x++;
                        break;
                }

            }

        }
    }
}
