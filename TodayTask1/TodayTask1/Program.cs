using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임 스토리1
            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.WriteLine("                『 MIST 』                ");
            Console.WriteLine("                                          ");
            Console.WriteLine("                                          ");
            Console.WriteLine("   --엔터를 치면 스토리가 시작됩니다.--   ");

            
            Console.ReadLine();
            Console.Clear();
            Console.Write("서기 2414년 거대 기업들이 정부를 대체한 도시.");
            Console.ReadLine();
            Console.Write("이곳은 고층 빌딩과 네온 불빛이 가득하지만, ");
            Console.ReadLine();
            Console.Write("그 아래에는 기업의 실험 대상으로 쓰이다 버려진 인간들, ");
            Console.ReadLine();
            Console.WriteLine("사이버네틱 강화인간, 해커들, 그리고 반란 조직이 얽혀 살아가는 곳이다.");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                 -- Enter (다음)--                 ");
            Console.WriteLine("                                                  ");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("당신은 기억을 잃은 채 폐허가 된 뒷골목에서 깨어난 사이버네틱 용병.");
            Console.WriteLine("당신의 두뇌에는 강제로 이식된 칩이 있으며, 그 안에는 단서가 하나 있다. ");
            Console.WriteLine("\"코드네임 『MIST』. 메모리 코어를 찾고 진실을 밝혀라. \" ");
            Console.WriteLine("당신은 자신의 정체를 되찾기 위해, 그리고 이 도시의 어두운 비밀을 파헤치기 위해 움직이게 된다.");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                 -- Enter (다음)--                 ");
            Console.WriteLine("                                                  ");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                 1장. 기억을 쫒는 자.             ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                 -- Enter (다음)--                ");
            Console.WriteLine("                                                  ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("『MIST』는 기억이 사라진 상태로, 노바 프리즘 도시의 뒷골목 \"블랙 바자(Black");
            Console.WriteLine("Bazaar)\"에서 깨어난다. 몸에는 낡은 사이버네틱 보조 장치가 붙어 있으며, 머릿속에서는 계속해서 ");
            Console.WriteLine("이상한 데이터 오류 메시지가 떠오른다.");
            Console.WriteLine("\"시스템 오류... 데이터 복구 중... 메모리 코어를 찾으십시오.\"");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                 -- Enter (다음)--                ");
            Console.WriteLine("                                                  ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("정보를 얻기 위해 플레이어는 \"시부야 거리(Shibuya District)\"에 위치한 불법 데이터 마켓을 찾아간다.");
            Console.WriteLine("그곳에서 블랙 마켓 정보 브로커 \"비트(BIT)\"를 만나게 되었다.");
            Console.WriteLine("하지만 비트는 현재 MIST에게 호의적으로 정보를 제공할것으로는 보이지 않는다.");
            Console.WriteLine("그에게 좋은 인상을 주어 정보를 얻어야한다.");
            Console.WriteLine("                                                  ");
            Console.WriteLine("                 -- Enter (다음)--                ");
            Console.WriteLine("                                                  ");
            Console.ReadLine();
            Console.Clear();
           

            Console.WriteLine("당신은 비트에게 어떠한 행동을 하시겠습니까?");
            Console.WriteLine("1. 뉴로넷 칩을 가지고 있다는 사실을 알린다. ");
            Console.WriteLine("2. 퇴근하고 술한잔 어떠냐고 묻는다.");
            Console.WriteLine("3. 총구를 면상에 들이밀며 쏘아붙인다.");
            Console.WriteLine("당신의 선택은? [수행 할 행동 번호 입력후 Enter] : ");
            string input = Console.ReadLine();
            int numb = int.Parse(input);

            Console.Clear();


            if (numb ==null)
            {
                Console.WriteLine("번호를 정확히 입력하세요.");
            }

            if (numb == 3)
            {
                Console.WriteLine("당신은 비트의 권총에 벌집이 되었습니다.");
                Console.WriteLine("                                      ");
                Console.WriteLine("          -- game over --             ");
                Console.WriteLine("                                      ");
                Console.ReadLine();
                Console.Clear();
            }

            if (numb == 2)
            {
                Console.WriteLine("당신은 개꽐라가 되어서 장기를 적출당하고 통나무가 되었습니다.");
                Console.WriteLine("                                      ");
                Console.WriteLine("          -- game over --             ");
                Console.WriteLine("                                      ");
                Console.ReadLine();
                Console.Clear();
            }

            if (numb == 1)
            {
                Console.WriteLine("플레이어가 뉴로넷 칩을 가지고 있다는 사실을 알게 되자 비트는 태도를 바꾼다.");
                Console.WriteLine("그는 플레이어에게 충격적인 사실을 알려준다.");
                Console.WriteLine("\"그 칩... 네 머릿속에 있는 거, 오로라 코어의 실험체들에게만 이식되는 거야.");
                Console.WriteLine("네가 뭘 기억하든 간에, 그놈들은 네가 기억하지 못하기를 바랄 거다.");
                Console.WriteLine("하지만... 네 기억을 되찾을 방법이 있긴 해.\"");
                Console.WriteLine("                                                  ");
                Console.WriteLine("                 -- Enter (다음)--                ");
                Console.WriteLine("                                                  ");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
