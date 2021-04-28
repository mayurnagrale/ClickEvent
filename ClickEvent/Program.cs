using System;

namespace ClickEvent
{
    class Program
    {
        //static void keyPressed()
        //{
        //    Button button = new Button();
        //    button.ClickEvent += (s, args) =>
        //    {
        //        Console.WriteLine("You click a button");
        //    };
        //    button.OnClick();
        //}
        delegate double ProcessDelegate(double param1, double param2);

        private static double Divide(double pa1, double pa2)
        {
            return pa1 / pa2;
        }

        private static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        public static void Callback(int i)
        {
            Console.WriteLine(i);
        }
        public static void Callback(float i)
        {
            Console.WriteLine(i*2);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Press a A button to simulate the click event");
            //var key = Console.ReadLine();
            //if (key == "a")
            //{
            //    keyPressed();
            //}

            //Declaring a variabl of type delegate
            //ProcessDelegate process;
            ////Program p = new Program();
            //double res = Divide(10,5);
            //Console.WriteLine(res);
            //process = new ProcessDelegate(Divide);
            //double res2 = process(9,3);
            //Console.WriteLine(res2);
            //process = new ProcessDelegate(Multiply);
            //double res1 = process(3, 3);
            //Console.WriteLine(res1);

            //Calling a method of MyClass using object
            MyClass1 myclass = new MyClass1();
            myclass.SomeMethod(Callback);
            //myclass.SomeOtherMethod();

            //Calling a method of my class using a delegate 
            //SomeMethodPtr obj = new SomeMethodPtr(SomeMethod);

        }

        //private double Divide(double v1, double v2)
        //{
        //    return v1 / v2;
        //}
    }

    //public class Button
    //{
    //    public EventHandler ClickEvent;
    //    public void OnClick()
    //    {
    //        ClickEvent.Invoke(this, EventArgs.Empty); // invke method requires two arguments sender and the arguments
    //    }
    //}
}
