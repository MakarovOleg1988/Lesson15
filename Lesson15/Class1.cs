using _Lesson15; //использование библиотеки

using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15
{
    class Class1
    {
        static void Main(string[] args)
        {
            var r1 = new Program2(); 
            var r2 = new _Lesson15.Program2();
            var r3 = new _Lesson15.Program2.SecondClass();
            var r6 = new Program4();
            r6.VirtualMethod();

            var r5 = new Program3();
            r5.Method(1);
            r5.Method("1");
            r5.Method(3);



            var r4 = new Program4();
        }
    }
}
