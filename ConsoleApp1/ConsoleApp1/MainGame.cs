using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MainGame
    {
        public Player pPlayer = null;

        public Field field = null;

        public void initialize()
        {
            Console.Clear();
            pPlayer = new Player();
            //RPG 만들기
            pPlayer.SelectJob();
        }

        public void progress()
        {
            while (true)
            {
                Console.Clear();
                pPlayer.PlayerInfoPrint();
                Console.WriteLine("1. 사냥    2. 나가기");
                Console.Write("행동을 선택하세요 : ");
                int num2 = int.Parse(Console.ReadLine());

                if (num2 == 1)
                {
                    if (field == null)
                    {
                        field = new Field();
                        field.SetPlayer(ref pPlayer);
                    }
                    field.FieldSelect();
                }
                else if (num2 == 2)
                {
                    break;
                }
            }
        }
    }
}