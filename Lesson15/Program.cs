using System;
using System.Text;
using System.Collections.Generic;

namespace _Lesson15
{
    class Program
    {
        protected Program3 Value { get; set; }

        private int _id;
        public int ID 
        {
            get => _id;
            protected set 
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ApplicationException("Попытка присвоить неверный идентификатор");
                }
            }
        }
        public virtual void VirtualMethod() //Метод с возможностью дополнительной перегрузки
        {
            Console.WriteLine(GetType().Name);
        }
    }

    public class Program2
    {
        public class SecondClass
        {
        
        }
    }

    internal class Program3 : Program //internal Класс открыт только внутри данной сборки
    {
        public int _value { get; set; }

        public void Method(object r)
        {
            if (r is int) Console.WriteLine("это целочисленная переменная");
            else Console.WriteLine("это нецелочисленная переменная");
        }
    }

     class Program4: Program
    {
        public void Method2()
        {
            ID = 10;
        }
        public override void VirtualMethod() //Дополнительная перегрузка метода VirtualMethod
        {
            base.VirtualMethod();            
        }
    }
}
