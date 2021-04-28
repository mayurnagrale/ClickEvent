using System;
using System.Collections.Generic;
using System.Text;

namespace ClickEvent
{
    public class MyClass1
    {
        public delegate void Callback(int i);
        //public delegate void Callback(int i);
        public void SomeMethod(Callback obj)
        {
            for (int i=0;i<100;i++)
            {
                obj(i);
            }
            //for (int  j = 0; j < 100; j++)
            //{
            //    obj(j);
            //}
        }
        public void SomeOtherMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
