using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_TEST
{
    class Program
    {

        static void Main(string[] args)
        {

            MainGame mainGame = new MainGame();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("용사를 키워라!");

                mainGame.initiallize();
                mainGame.Progress();
            }
        }
    }
}
