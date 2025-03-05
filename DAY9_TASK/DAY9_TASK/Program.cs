using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;


//LOL 클래스 설계

namespace DAY9_TASK
{
    class Champion
    {
        public string name;
        public int HP;
        public string resource;
        public int AttackDamage;
        public int AbilityPower;
        public int moveSpeed;

        public Champion()
        {
            name    = "Unknown";
            HP      = 500;
            resource = "마나";
            AttackDamage = 50;
            AbilityPower = 20;
            moveSpeed = 300;
        }
        public virtual void Info()
        {
            Console.WriteLine($" 챔피언 '{name}'의 기본 능력치 입니다.");
            Console.WriteLine($"  - 생명력   : {HP}");
            Console.WriteLine($"  - 자원     : {resource}");
            Console.WriteLine($"  - 공격력   : {AttackDamage}");
            Console.WriteLine($"  - 주문력   : {AbilityPower}");
            Console.WriteLine($"  - 이동속도 : {moveSpeed}\n");
        }

        public virtual void Accessories()
        {
            Console.WriteLine(" 투명 와드를 사용합니다.\n");
        }

        public virtual void summonerSpell(string DF)
        {
            if (DF == "D")
                Console.WriteLine(" 점화를 사용합니다.\n");
            else if (DF == "F")
                Console.WriteLine(" 점멸을 사용합니다.\n");
        }
    }

    class Maokai : Champion
    {
        public Maokai()
        {
            name = "마오카이";
            HP = 600;
            AttackDamage = 50;
            AbilityPower = 20;
            moveSpeed = 325;
        }

        public override void summonerSpell(string DF)
        {
            if (DF == "D")
                Console.WriteLine("텔레보트를 사용합니다.\n");
            else if (DF == "F")
                Console.WriteLine("점멸을 사용합니다.\n");
        }
    }

    class Ari : Champion
    {
        public Ari()
        {
            name = "아리";
            HP = 460;
            AttackDamage = 45;
            AbilityPower = 55;
            moveSpeed = 310;
        }
    }

    class Lulu : Champion
    {
        public Lulu()
        {
            name = "룰루";
            HP = 460;
            AttackDamage = 40;
            AbilityPower = 30;
            moveSpeed = 310;
        }
        public override void Accessories()
        {
            Console.WriteLine("예언자의 렌즈를 사용합니다.\n");
        }
    }

    class Jinx : Champion
    {
        public Jinx()
        {
            name = "징크스";
            HP = 440;
            AttackDamage = 55;
            AbilityPower = 0;
            moveSpeed = 310;
        }
        public override void Accessories()
        {
            Console.WriteLine("망원형 개조를 사용합니다.\n");
        }
    }

    class Leesin : Champion
    {
        public Leesin()
        {
            name = "리신";
            HP = 500;
            resource = "기력";
            AttackDamage = 55;
            AbilityPower = 15;
            moveSpeed = 330;
        }

        public override void Accessories()
        {
            Console.WriteLine("예언자의 렌즈를 사용합니다.\n");
        }

        public override void summonerSpell(string DF)
        {
            if (DF == "D")
                Console.WriteLine("강타를 사용합니다.\n");
            else if (DF == "F")
                Console.WriteLine("점멸을 사용합니다.\n");
        }
    }

    class item
    {
        public string itemName;
        public int addHP;
        public int addMP;
        public int addAttack;
        public int addAttackSpeed;
        public int addMoveSpeed;
    }


    class Program
    {
        static void Main(string[] args)
        {
            List <Champion> champs = new List<Champion>();

            champs.Add(new Maokai());
            champs.Add(new Ari());
            champs.Add(new Jinx());
            champs.Add(new Lulu());
            champs.Add(new Leesin());

            while(true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("◎ 챔피언 목록");
                    foreach (var champ in champs)
                    {
                        int num = champs.IndexOf(champ);
                        Console.WriteLine($" {num + 1}. " + champ.name);
                    }
                    Console.Write("챔피언을 선택 하세요: ");
                    int numb = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"◎ {champs[numb - 1].name}를 선택하였습니다.");
                        Console.WriteLine("  입력한 번호를 실행합니다.");
                        Console.WriteLine(" 1. 챔피언 기본 정보 보기");
                        Console.WriteLine(" 2. 장신구 사용");
                        Console.WriteLine(" 3. 소환사 주문 사용");
                        Console.WriteLine(" 0. 이전 메뉴로");
                        Console.Write("   -> 입력 : ");
                        int movement = int.Parse(Console.ReadLine());

                        Console.WriteLine();
                        
                        if (movement == 1)
                        {
                            champs[numb - 1].Info();
                            Console.ReadLine();
                            Console.WriteLine("엔터를 누르면 선택으로 돌아갑니다.");
                        }
                        else if (movement == 2)
                        {
                            champs[numb - 1].Accessories();
                            Thread.Sleep(1000);
                        }
                        else if (movement == 3)
                        {
                            Console.Write("◎ 소환사 스펠을 사용합니다.(D , F) : ");
                            string DF = Console.ReadLine();
                            champs[numb - 1].summonerSpell(DF.ToUpper());

                            Thread.Sleep(1000);
                        }
                        else if (movement == 0) break;
                        else
                        {
                            Console.WriteLine("목록의 숫자를 입력해주세요.\n");
                            Thread.Sleep(1000);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("목록의 숫자를 입력해주세요.\n");
                    Thread.Sleep(1000);
                }
            } 
        }
    }
}
