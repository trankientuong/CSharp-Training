using System;
namespace MethodHiding
{
    public class Parent
    {
        public virtual void Method1()
        {
            Console.WriteLine("Parent Class Method1 Method");
        }
        public void Method2()
        {
            Console.WriteLine("Parent Class Method2 Method");
        }
        public virtual void Method3()
        {
            Console.WriteLine("Parent Class Method3 Method");
        }
        public void Method4()
        {
            Console.WriteLine("Parent Class Method4 Method");
        }
    }
    public class Child : Parent
    {
        //Overriding Virtual Method
        //Method Overriding
        public override void Method1()
        {
            Console.WriteLine("Child Class Method1 Method");
        }
        //Overriding Non-Virtual Method
        //Not Possible. Compile Time Error
        public new void Method2()
        {
            Console.WriteLine("Child Class Method2 Method");
        }
        
        //Method Hiding/Shadowing Virtual Method
        public new void Method3()
        {
            Console.WriteLine("Child Class Method3 Method");
        }
        //Method Hiding/Shadowing Non-Virtual Method
        public new void Method4()
        {
            Console.WriteLine("Child Class Method4 Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent obj = new Child();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
            Console.ReadKey();
        }
    }
}