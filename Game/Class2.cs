using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("비밀 문자를 입력하세요");

            const char SECRET_NUMBER = 's';

            bool findCode = false;

            int a = Console.Read();
          
            if (a == SECRET_NUMBER)
            {
                Console.WriteLine("정답입니다");
            }
            else if (a > SECRET_NUMBER)
            {
                Console.WriteLine("비밀 숫자보다 큽니다");
            }
            else if (a < SECRET_NUMBER)
            {
                Console.WriteLine("비밀 숫자보다 작습니다");

            }
            
            


            Console.WriteLine("3개의 정수 중 가장 큰 수를 찾으세요");
            Console.Write("1번 정수를 입력하세요: ");
            string oneNumber = Console.ReadLine();
            int number1 = int.Parse(oneNumber);

            Console.Write("2번 정수를 입력하세요: ");
            string twoNumber = Console.ReadLine();
            int number2 = int.Parse(twoNumber);

            Console.Write("3번 정수를 입력하세요: ");
            string threeNumber = Console.ReadLine();
            int number3 = int.Parse(threeNumber);

            if (number1 < number2 && number3 < number2)
            {
                Console.WriteLine("가장 큰 정수는 {0} 입니다", number2);
            }
            else if (number3 < number1 && number2 < number1)
            {
                Console.WriteLine("가장 큰 정수는 {0} 입니다", number1);
            }
            else if (number1 < number3 && number2 < number3)
            {
                Console.WriteLine("가장 큰 정수는 {0} 입니다", number3);
            }
            else
            {
                Console.WriteLine("세 정수가 다 같습니다");

            }

        }





    }
}
