using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame(); 

            while (true)
            {
                mainGame.initialize();
                mainGame.progress();
            }
        }
    }
}
