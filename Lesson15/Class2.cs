using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson15
{
    public abstract class Class2
    {
        public abstract string _change { get; set; }
    }

    public class Example : Class2
    {
        private string newString = "I";
        public override string _change { get; set; }
    }
}
