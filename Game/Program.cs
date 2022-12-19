using System;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringBinary = Convert.ToString(10, 2);
            Console.WriteLine(stringBinary);
            int intBinary = Convert.ToInt32("0111", 2);
            Console.WriteLine(intBinary);

            /**
             * 연산자
             * 데이터로 연산 작업을 수행할 때는 연산자(operator)를 사용한다.
             * 연산자는 기능에 따라 대입, 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며,
             * 이용 형태에 따라 항 1개로 연산을 하는 단하(Unary) 연산자와 항 2개로 연산을 하는 이항(Binary) 연산자, 
             * 항 3개로 연산을 하는 삼항(Ternary) 연산자로 나눈다.
             * 
             * 단항 연산자
             * 단항 연산자는 연산자와 피연산자 하나로 식을 처리한다.
             * ex) [연사자] [피연산자]
             * +연산자: 특정 정수형 변수 값을 그대로 출력한다.
             * -연산자: 특정 정수형 변수 값을 음수로 변경 출력한다. 음수 값이 들어 있다면 양수로 변환해서 반환한다.
             * 
             * 이항 연산자
             * 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다.
             * ex) [피연산자1] [연산자] [피연산자2]
             * 
             * 삼항 연산자 
             * 삼항 연산자는 식 1개의 항(Expression)과 그 결과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리한다.
             * ex) (식) ? 피연산자1 : 피연산자2
             * 
             * 식과 문
             * 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expression) 또는 표현식이라고 한다.표현식을 사용하여
             * 명령 하나를 진행하는 구문을 문(statement) 문장이라고 한다.
             */

            //단항 연산자 
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;
            const int MINUS_FIVE2 = -5;


            //이항 연산자
            const int PLUS_TEN = 5 + 5;

            //삼항 연산자
            string compareTen = (PLUS_FIVE > 10) ? "{0}은(는) 10보다 크다" : "{0}은(는) 10보다 크지 않다";
            Console.WriteLine(compareTen, PLUS_FIVE);

            //변환 연산자
            //() 기호를 사용하여 특정갑을 원하는 데이터 형ㅅ기으로 변환할 수 있다.
            const int PI_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.141592;
            Console.WriteLine("PI_INT: {0}, PI_FLOAT: {1}", PI_INT, PI_FLOAT);

            /**
             * 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자
             * 
             * 산술 연산자
             * 더하기(Add), 뺴기(Subtract), 곱하기(Multiply), 나누기(Divide), 나머지(Remainder, Modules) 등
             * 수학적 연산을 하는데 사용한다. 보통 정수 형식과 실수 형식의 산술 연산에 사용한다.
             * ex) +, -, *, /, %
             * 
             * 문자열 연결 연산자
             * 산술 연산자 중 하나인 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을
             * 수행한다.
             * 
             * +연산자: 두 항이 숫자일 때는 산술(+) 연산 가능, 문자열일 떄는 문자열 연결 가능
             */

            string addMessage = "String " + "plus " + "string";
            Console.WriteLine(addMessage);

            /**
             * 할당 연산자
             * 할당 연산자(Assignment operator)는 변수에 데이터를 대입하는 데 사용한다. 할당 연산자를 대입 연산자
             * 라고도 한다. C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에
             * 할당하라고 지시하는 것이다.
             * 
             * ex) =, +=, -=, *=, /=, %=
             * 
             * 증감 연산자(Increment / Decrement operator)
             * 변수 값을 1 증가시키거나 1 감소 시키는 연산자이다. 증감 연산자가 변수 앞에 위치 하느냐, 뒤에 위치 하느냐에 따라
             * 연산 처리 우선 순위가 결정 된다.
             * 
             * ++(증가 연산자): 변수 값에 1을 더한다.
             * --(감소 연산자): 변수 값에 1을 뺸다.
             * 
             * 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
             * 
             * 전위(Prefix) 증감 연산자: 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수행한다.
             * 
             * 후위(Postfix) 증감 연산자: 정수형 변수 뒤에 연산자가 위치하ㅕ 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감한다.
             * 
             */

            int number = 0;
            /*  Console.WriteLine(number++); //++를 앞에 붙이나 뒤에 붙이나 결과가 다르다.
              Console.WriteLine(number);
              */
            number = number++;
            Console.WriteLine(number);

            /**
             * 관계형 연산자 
             * 관계형 연산자(Relational operator) 또는 비교 연산자(Comparative operator)는 두항이 큰지
             * 또는 같은지 등을 비교하는 데 사용한다. 관계형 연산자의 결과값은 논리 데이터 형식인 참(True),
             * 거짓(False)으로 출력된다.
             * ex) <, <=, >, >=, ==, !=
             * 
             * 논리 연산자 
             * 논리연산자(Logical operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을
             * 수행한다. 연산의 결과값은 참 또는 거짓의 bool 형식으로 변환되어 Boolean 연산자라고도 한다.
             * ex) &&, ||, !
             * 
             * 비트 연산자
             * 비트연산자(Bit operator)는 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
             * ex) &, |, ^, ~
             * 
             * 시프트 연산자 
             * 시프트 연산자(Shift operator)는 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한
             * 비트만큼 이동시킨다.
             * ex) <<, >>
             * 
             * 조건 연산자
             * 조건연산자(Conditional operator)는 조건에 따라서 참일 떄와 거짓일 때 결과를 다르게 반환하며
             * (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자이다. if~else 문의 축약형이기도 하다.
             * 
             */

            bool isBigger = true; //왜 true false 를 쓰는지?
            isBigger = (5 > 10);
            Console.WriteLine(isBigger);


            int bitNumber = 10;
            int bitResult = 0;

            bitResult = bitNumber & 0b0100; //1111 과 0000 의 or(|)를 하면 15가 나온다 
            Console.WriteLine(bitResult);

            bitResult = bitNumber << 1;
            Console.WriteLine(bitResult);

            // 나열(콤마) 연산자
            // 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용한다.
            int intNumebr1, intNumber2, intNumber3;

            /**
             * sizeof 연산자
             * sizeof 연산자는 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다
             * sizeof([데이터 타입]) 형태로 사용하며, 운영 체제와 CPU 아키텍쳐의 종류에 따라 결과값이
             * 다르게 나올 수 있다.
             */

            Console.WriteLine("int의 메모리 크기는 {0} 바이트입니다.", sizeof(Int32));

            /**
             * 연산자 우선순위
             * 연산자 여러 개를 함께 사용할 떄는 연산자 우선순위(Precedence)에 따라 계산된다.
             * 연산자 우선순위를 잘 모를 때는 일단 괄호 연산자부터 잘 사용하도록 연습 하는게 좋다.
             */

            Console.Write("주어를 입력하세요");
            string subjectt = Console.ReadLine();
            Console.Write("동사를 입력하세요");
            string verbb = Console.ReadLine();
            Console.Write("목적어를 입력하세요");
            string objctt = Console.ReadLine();

            Console.WriteLine(subjectt + " " + verbb + " " + objctt);

            Console.WriteLine("나이가 어떻게 되시나요?");
            string age = Console.ReadLine();
            int age2 = int.Parse(age);
            Console.WriteLine("10년 후의 당신의 나이는 {0} 입니다", age2 + 10);

            Console.WriteLine("윗변을 입력하세요");
            string topLine = Console.ReadLine();
            double top = double.Parse(topLine);
            double toptop = top * top;
            Console.WriteLine("밑변을 입력하세요");
            string bottomLine = Console.ReadLine();
            double bottom = double.Parse(bottomLine);
            double bottom2 = bottom * bottom;

            double result = (toptop + bottom2);
            double resultDou = Math.Sqrt(result);
            Console.WriteLine($"빗변의 길이는 {resultDou}");

            Console.WriteLine("상자의 길이 너비 높이를 입력하세요");
            Console.Write("길이");
            string Length = Console.ReadLine();
            double Lengthh = double.Parse(Length);

            Console.Write("너비");
            string width = Console.ReadLine();
            double widthh = double.Parse(width);

            Console.Write("높이");
            string height = Console.ReadLine();
            double heightt = double.Parse(height);

            double result1 = 2 * (Lengthh * widthh + widthh * heightt + Lengthh * heightt);
            double result2 = Lengthh * widthh * heightt;
            Console.WriteLine("상자의 겉넓이는 {0} 이고 상자의 부피는 {1} 입니다.", result1, result2);

            const double ONE_PYUNG = 3.3058;
            Console.Write("부동산 평수를 입력하세요 :");
            string area = Console.ReadLine();
            double meter = double.Parse(area);
            double result3 = ONE_PYUNG * meter;
            Console.Write("평당 미터는: {0} 입니다", result3);

            Console.WriteLine("시간을 변환하는 프로그램입니다 시 분 초를 입력하세요");
            Console.Write("시:");
            string hourr = Console.ReadLine();
            double hour = double.Parse(hourr);
            Console.Write("분:");
            string minn = Console.ReadLine();
            double min = double.Parse(minn);
            Console.Write("초:");
            string secc = Console.ReadLine();
            double sec = double.Parse(secc);

            Console.WriteLine("전체 초: {0} ", hour * 60 * 60 + min * 60 +sec);

            Console.WriteLine("기말고사 성적을 입력하세요");
            Console.Write("퀴즈   #1 성적: ");
            string quiz11 = Console.ReadLine();
            int quiz1 = int.Parse(quiz11);

            Console.Write("퀴즈   #2 성적: ");
            string quiz22 = Console.ReadLine();
            int quiz2 = int.Parse(quiz22);

            Console.Write("퀴즈   #3 성적: ");
            string quiz33 = Console.ReadLine();
            int quiz3 = int.Parse(quiz33);

            Console.Write("중간고사   성적: ");
            string mid = Console.ReadLine();
            int middle = int.Parse(mid);

            Console.Write("기말고사   성적: ");
            string fin = Console.ReadLine();
            int final = int.Parse(fin);

            int sum = quiz1 + quiz2 + quiz3 + middle + final;            
            Console.WriteLine("=================");
            Console.WriteLine("성적 총합: {0} ", sum);
            Console.WriteLine("=================");




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





        }
    }
}