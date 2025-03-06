using System;

namespace Cstudy1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10 ;i++)
            //{
            //    for (int j = 2; j < 10; j++)
            //    {
            //        Console.Write($"{j} X {i} = {i*j}\t");
            //    }
            //    Console.WriteLine();
            //}

            ////while 문 사용

            //int num=1;
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine($"숫자 {num}");
            //    num++;
            //} while (num == 5);

            //while (true)
            //{
            //    Console.WriteLine($"숫자 {num}");
            //    num++;
            //    if (num > 5) break;
            //}

            //1~10 합

            //while (true)
            //{

            //    sum += num;
            //    Console.WriteLine($"숫자 {num}");
            //    Console.WriteLine($"합 {sum}");
            //    num++;
            //    if (num > 10) break;
            //}

            // 가위, 바위, 보 게임을 만들건데
            // if, switch, while문을 사용해서 (둘중에 아무거나 if나 switch)
            // 나는 1~3번으로 선택해서 가위바위보를 선택하고 상대는 랜덤으로 가위바위보를해서
            // 내가 이겼는지 비겻는지 졌는지
            // 만들고 쉬는시간까지해서 7시 30분
            // 시간부족하다 말씀해주시면 조금 더드려볼게요 일단 30분풀어보시고
            // 지피티쓰면안되요

            // 풀만하신가요? 어렵나요?
            // 가위바위보...생각보다어렵네..?

            Random random = new Random();

            while (true)
            {
                Console.WriteLine("========가위바위보 게임========");
                Console.WriteLine("1:가위, 2:바위, 3:보");
                Console.WriteLine("숫자를 입력하세요 :) (0번을 입력하면 게임이 종료됩니다)");

                string input = Console.ReadLine();
                int useChoice;
                try
                {
                    useChoice = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 입력입니다. 숫자를 입력하세요.\n");
                    continue;
                }

                if (useChoice == 0) break;

                if (useChoice < 1 || useChoice > 3)
                {
                    Console.WriteLine("1,2,3중 하나의 숫자를 입력하세요\n");
                    continue;
                }


                int computerChoice = random.Next(1, 4);



                string userMove = "";
                //if (useChoice == 1) userMove = "가위";
                //else if (useChoice == 2) userMove = "바위";
                //else if (useChoice == 3) userMove = "보";

                string computerMove = "";
                //if (computerChoice == 1)
                //{
                //    computerMove = "가위";
                //    Console.WriteLine(computerMove);
                //}
                //else if (computerChoice == 2) computerMove = "바위";
                //else if (computerChoice == 3) computerMove = "보";

                switch (useChoice)
                {
                    case 1: userMove = "가위"; break;
                    case 2: userMove = "바위"; break;
                    case 3: userMove = "보"; break;
                }

                switch (computerChoice)
                {
                    case 1: computerMove = "가위"; break;
                    case 2: computerMove = "바위"; break;
                    case 3: computerMove = "보"; break;
                }

                Console.WriteLine($"나 : {userMove}, 컴퓨터 : {computerMove}");

                if (useChoice == computerChoice)
                {
                    Console.WriteLine("비겼슴둥...\n");
                }
                else if ((useChoice == 1 && computerChoice == 3) ||
                        (useChoice == 2 && computerChoice == 1) ||
                        (useChoice == 3 && computerChoice == 2))
                {
                    Console.WriteLine("이겼슴둥!!!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("졌슴둥......ㅠㅠ\n");
                }
            }

            //1. 가위, 2. 바위, 3.보
            while (true)
            {
                string[] mook =  {"가위","바위","보"};

                Console.Write("(1. 가위, 2. 바위, 3. 보 )입력 : ");
                int numb = int.Parse(Console.ReadLine());
                Console.WriteLine($"나 : {mook[numb-1]}"); 
                
                Random rand = new Random();
                int randNumb = rand.Next(1, 4);
                Console.WriteLine("computer : " + mook[randNumb-1]); 
                if (numb == randNumb)
                {
                    Console.WriteLine("비겼습니다.");
                }
                switch (numb)
                {
                    case 1:
                        if (randNumb == 2)
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        else if (randNumb == 3)
                        {
                            Console.WriteLine("이겼습니다.");

                        }
                        break;
                    case 2:
                        if (randNumb == 3)
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        else if (randNumb == 1)
                        {
                            Console.WriteLine("이겼습니다.");

                        }
                        break;
                    case 3:
                        if (randNumb == 1)
                        {
                            Console.WriteLine("졌습니다.");
                        }
                        else if (randNumb == 2)
                        {
                            Console.WriteLine("이겼습니다.");

                        }
                        break;
                }
            }  
        }
    }
}
