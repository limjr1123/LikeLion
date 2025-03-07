using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11_3
{
    class Program
    {
        //delegate 와 event를 더 쉽게 만듬 => Action
        static void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }
        static void ShowNotification()
        {
            Console.WriteLine("안녕하세요");
        }

        //인자가 있는 Action
        static void HelloWorld(string message )
        {
            Console.WriteLine("신규 메시지 :" + message);
        }
        
        static void Main(string[] args)
        {

            //Action은 매개변수가 없고 반환값이 없는 매서드를 참조
            //메서드 이름을 변수에 저장한다고 생각하면 쉬움
            Action sayHello = SayHello;
            sayHello += ShowNotification;
            sayHello?.Invoke();
            
            Action<string> h = null;
            h += HelloWorld;
            h?.Invoke("액션");

            Action nti = null;
            nti += () => Console.WriteLine("인자없는 액션");
            nti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number* number);
            Square(5);
        }
    }
}
