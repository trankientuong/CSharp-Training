using System;
namespace InheritanceDemo
{
    class A
    {
        public A()
        {
            Console.WriteLine("Class A Constructor is Called");
        }

        public A(int number)
        {
            Console.WriteLine($"Class A Constructor is Called : {number}");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public B(int num) : base(num)
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            A p; //p is a variable of class A
            B q = new B(); //q is an instance of Class B 
            //We can initialize a Parent class variable using child class instance as follows
            p = q; //now, p is a reference of parent class created by using child class instance
            //Now you can call members of A class as follows
            p.Method1();
            p.Method2();
            //We cannot call any pure child class members using the reference p
            //p.Method3();
            B b = new B(10);
            b.Method3();

            B b2 = new B();
            
            Console.ReadKey();
        }
    }
} 