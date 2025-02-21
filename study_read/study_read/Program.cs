using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_read
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자로부터 입력받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            //// 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();  // 사용자로부터 입력받기
            //int age = int.Parse(input);         // 문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!");
            //Console.WriteLine("내년에는 " + age + " 살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age + 1);

             
            Console.Write("루인 스킬 피해 입력: ");
            float ruin = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량 입력: ");
            float gage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해 입력: ");
            float fin = float.Parse(Console.ReadLine());

            Console.Write("최대 마나 입력: ");
            int maxMana = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량 입력: ");
            int manaRecovery = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나회복량 입력: ");
            int manaRecoveryIdle = int.Parse(Console.ReadLine());

            Console.Write("이동 속도 입력: ");
            float moveSpeed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도 입력: ");
            float carMoveSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도 입력: ");
            float carrySpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소 입력: ");
            float skillRecycle = float.Parse(Console.ReadLine());


            Console.WriteLine("#########입력정보#########");
            Console.WriteLine("루인 스킬 피해       : " + ruin + "%");
            Console.WriteLine("카드 게이지 획득량   : " + gage + "%");
            Console.WriteLine("각성기 피해          : " + fin + "%");
            Console.WriteLine("최대 마나            : " + maxMana);
            Console.WriteLine("전투 중 마나 회복량  : " + manaRecovery);
            Console.WriteLine("비전투 중 마나회복량 : " + manaRecoveryIdle);
            Console.WriteLine("이동 속도            : " + moveSpeed + "%");
            Console.WriteLine("탈 것 속도           : " + carMoveSpeed + "%");
            Console.WriteLine("운반 속도            : " + carrySpeed + "%");
            Console.WriteLine("스킬 재사용 대기시간 감소 : " + skillRecycle + "%");
        }
    }
}
