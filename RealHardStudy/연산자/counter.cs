using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHardStudy.연산자
{
    class counter
    {
        void Main()
        {
            //단항연산자
            int a = 5;
            a++;
            Console.WriteLine(a);
            //이항연산자
            int b = 1;
            b = a;//b에 a값 저장
            Console.WriteLine("b" + "+를 이용해 합침" + b);
            //사칙연산자
            int c = a + b;
            int d = a - b;
            int e = a / b;
            int f = a % b;
            //복합 대입 연산자
            //+= -= *= /= %= &= |= ^= <<= >>=
            //비교연산자
            //== != < > <= >=
            //삼항연산자
            // 한동근
        }
    }
}
