using System;

namespace PrivateConstructorDemo
{

    class Example
    {
        private Example()
        {
            Console.WriteLine("Example Private Constructor");
        }

        public Example(int x)
        {
            Console.WriteLine("Example Public Constructor");
        }

        public void Method1()
        {
            Console.WriteLine("Method1 in Example is called");
        }
    }

    class Program
    {
        private Program()
        {
            Console.WriteLine("Private Constructor");
        }

        private Program(string message)
        {
            Console.WriteLine("Private Constructor Parameterized");
        }

        public void Method1()
        {
            Console.WriteLine("Method1 is called");
        }

        static void Main(string[] args)
        {
            // Program obj = new Program();
            // Program obj2 = new Program("Hello");
            // obj.Method1();

            // Example exObj = new Example(10);
            // exObj.Method1();

            //Child childObj = new Child(); 
            // Parent.Child obj = new Parent.Child();

            Singleton fromPlace1 = Singleton.GetSingletonInstance();
            fromPlace1.SomeMethod("From Place 1");

            Singleton fromPlace2 = Singleton.GetSingletonInstance();
            fromPlace2.SomeMethod("From Place 2");
        }


    }

    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();
        public static Singleton GetSingletonInstance()
        {
            lock (Instancelock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Singleton Constructor Executed {counter} Time");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine($"Some Method Called : {Message}");
        }
    }

    public class Parent
    {

        // Private Constructor
        private Parent()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }

        // Public Constructor
        public Parent(string Message)
        {
            Console.WriteLine("Parent Class Public Constructor is Called");
        }

        public class Child : Parent // The child class inner the parent class, then inheritance is possible
        {
            public Child() // Compile-time error 
            {
                Console.WriteLine("Child Class Public Constructor is Called");
            }


            // public Child() : base("Hello")
            // {
            //     Console.WriteLine("Child Class Public Constructor is Called");
            // }
        }
    }

    // public class Child : Parent // The child class outside the parent class and hence it is not accessible to the Parent class private constructor
    // {

    //     public Child() // Compile-time error 
    //     {
    //         Console.WriteLine("Child Class Public Constructor is Called");
    //     }


    //     // public Child() : base("Hello")
    //     // {
    //     //     Console.WriteLine("Child Class Public Constructor is Called");
    //     // }
    // }

}
