using System;

namespace MethodOverloading
{
    class Class1
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
    }

    class Class2 : Class1
    {
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Method Overloading
            Program p = new Program();
            p.Method();
            p.Method(10);
            p.Method("Hello");
            p.Method(10, "Hello");
            p.Method("Hello", 10);

            p.Add(10, 20);
            p.Add(10.5f, 20.5f);
            p.Add("Kien", "Tuong");

            Class2 obj = new Class2();
            obj.Add(10, 20);
            obj.Add(10.5f, 20.5f);
            obj.Add("Kien", "Tuong");

            // Constructor Overloading
            ConstructorOverloading obj1 = new ConstructorOverloading(10);
            obj1.Display();
            ConstructorOverloading obj2 = new ConstructorOverloading(10,20);
            obj1.Display();
            ConstructorOverloading obj3 = new ConstructorOverloading(10,20,30);
            obj1.Display();

            // Method Overloading Realtime Example
            string ClassName = "Program";
            string MethodName = "Main";
            string UniqueId = Guid.NewGuid().ToString();
            Logger.Log(ClassName, MethodName, "Message 1");
            Logger.Log(UniqueId, ClassName, MethodName, "Message 2");
            Logger.Log("Message 3");
            try
            {
                int Num1 = 10, Num2 = 0;
                int result = Num1 / Num2;
                Logger.Log(UniqueId, ClassName, MethodName, "Message 4");
            }
            catch(Exception ex)
            {
                Logger.Log(ClassName, MethodName, ex);
            }            
        }

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }

        public void Method()
        {
            Console.WriteLine("1st Method");
        }

        public void Method(int i)
        {
            Console.WriteLine("2nd Method");
        }

        public void Method(string s)
        {
            Console.WriteLine("3rd Method");
        }

        public void Method(int i, string s)
        {
            Console.WriteLine("4th Method");
        }

        public void Method(string s, int i)
        {
            Console.WriteLine("5th Method");
        }
    }
}