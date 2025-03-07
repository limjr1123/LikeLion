using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11_1
{
    class Program
    {
        //delegate - 메시지 출력을 위한 메서드 참조
        //string 매개변수를 받고 반환값이 없는 void 매서드를 참조할수 있는타입
        delegate void MessageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드형과 타입이 일치해야함

        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메시지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메시지 : {message.ToUpper()}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("델리게이트와 이벤트 예제");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트1");

            //델리게이트 변수 선언 및 매서드 연결
            // DisplayMessage 매서드를 messageHandler 변수에 할당
            MessageHandler message = DisplayMessage;
            message("안녕하세요");

            //델리게이트 다른 매서드 추가(멀티캐스트 델리게이트)
            // +=연산자로 매서드 추가
            message += DisplayUpperMessage;

            //여러 매서드가 연결된 델리게이트 호출
            //등록 모든 매서드가 순서대로 호출됨
            Console.WriteLine("여러 메서드 호출:");
            message("Hello");

        }
    }
}
