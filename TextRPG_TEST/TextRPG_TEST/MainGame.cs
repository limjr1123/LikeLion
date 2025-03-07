using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TEST
{
    class MainGame
    {
        public Player player = null;
        public Field field = null;

        public void initiallize()
        {
            player = new Player();
            player.SelectJob();
        }

        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                player.Render(); //플레이어 출력
                Console.WriteLine("1.사냥터  2.처음으로 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 2)
                    break;
                if (iInput == 1)
                {
                    //사냥터 구현
                    if (field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref player);
                    }
                    field.Progress();
                }
            }
        }
        public MainGame() { }
        ~MainGame() { }
    }
}
