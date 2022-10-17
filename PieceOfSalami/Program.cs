using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;

namespace PieceOfSalami
{
    struct S
    {
        public int a;
        
    }

    class C
    {
        public int a = 2;
    }

        class Program
    {

        static void Main()
        {
            bool Super(ref int a)
            {
                a++;
                return true;
            }

            int a = 1;
            if(Super(ref a) && Super(ref a)) { }
            Console.WriteLine(a);
            S s = new S() { a = 1 };
            C c = new C();
            Func(c, s);
            Console.WriteLine(c.a);
            Console.WriteLine(s.a);
        }
        static void Func(C c, S s)
        {
            c.a++;
            s.a++;
        }
    }

}

   


