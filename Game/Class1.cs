using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("최대한도의 사탕 사기");

            Console.Write("돈을 입력해 주세요 :");
            string dollar = Console.ReadLine();
            int money = int.Parse(dollar);


            Console.Write("캔디의 가격은 얼마인가요 :");
            string sweet = Console.ReadLine();
            int candy = int.Parse(sweet);


            int ea = money / candy;
            int cash = money % candy;

            Console.WriteLine("현재가지고 있는돈은 {0}", money);
            Console.WriteLine("캔디의 가격은 {0}", candy);
            Console.WriteLine("최대로 살 수 있는 캔디는? {0}", ea);
            Console.WriteLine("캔디 구입 후 남은 돈은? {0}", cash);

            Console.WriteLine("섭씨 온도를 화씨 온도로 바꾸는 방법");

            Console.Write("화씨 온도를 입력해 주세요: ");
            string hwa = Console.ReadLine();
            float hwac = float.Parse(hwa);

            float supc;
            supc = (hwac - 32) / 1.8f;
            float changee = supc;

            Console.WriteLine("화씨 온도 {0}는 섭씨온도 {1} 입니다.", hwa, changee);

            Console.WriteLine("주사위 게임을 시작합니다");

            Random dice = new Random();

            int six = dice.Next(1, 7);
            Console.WriteLine("첫번쨰 주사위의 숫자는: {0}", six);
            int seven = dice.Next(1, 7);
            Console.WriteLine("두번째 주사위의 숫자는: {0} ", seven);

            Console.WriteLine("두 주사위의 합은 : {0} 입니다", six + seven);



            /**
             * 제어문 소개
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문)
             * 반복 구조(반복문)가 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main() 매서드 시작 지점부터 끝 지점까지 코드가 나열되면
             * 실행 후 종료한다.
             * 
             * 제어문 
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건의 창또는 거짓에 따라 서로다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             * 하기도 한다.
             * 반복문
             * 특정 명령문을 지정된 수 만큼 반복해서 실행할 때 조건식이 참일 동안 반복 시킬 때 사용한다.
             */


            /** 
             * if /else 문
             * 프로그램 흐름을 여러 가지 가갈래로 가지치기(Branching)할 수있는데, 이때 if 문을 사용한다.
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.
             */

            // 02챕터 3번예제 #1
            // 두개의 정수 중에서 더 큰 수를 찾는 프로그램

            int numberx, numbery;
            Console.Write("x갑을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numberx);
            Console.Write("y갑을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numbery);

            if (numbery < numberx)
            {
                Console.WriteLine("x가 y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("y가 x보다 큽니다.");
            }
            Console.WriteLine("아무 의미 없는 출력문");

            /**
             * 02.4 중간 점검1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml미만은 medium, 200ml이상은
             * large라고 출력하는 if-else 문을 작성
             */

            int number;
            Console.Write("컵의 사이즈를 입력하시오: ");
            string csize = Console.ReadLine();
            int cup = int.Parse(csize);


            if(0 < cup )
            {
                Console.WriteLine("small");
            
            }    
            else 
            {
                Console.WriteLine("large");
            }



            

        }
    }
}
