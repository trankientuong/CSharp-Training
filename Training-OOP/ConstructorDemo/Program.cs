using System;
namespace ConstructorDemo
{
    class Program
    {
        //Main Method is the Entry Point for our Application Execution
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            //Creating Object of ConstructorsDemo
            //Now the ConstructorsDemo class Execution Start
            //First, it will execute the Static constructor 
            //Then it will execute the non-static constructor

            //Before Executing the non-static constructor
            //it will first execute the static constructor of the class
            ConstructorsDemo obj1 = new ConstructorsDemo();
            //Now, onwards it will not execute the static constructor,
            //Because static constructor executed only once
            ConstructorsDemo obj2 = new ConstructorsDemo();
            ConstructorsDemo obj3 = new ConstructorsDemo();
            Console.WriteLine("X: " + ConstructorsDemo.x);
            Console.WriteLine("Y: " + obj1.y);
            Console.WriteLine("Main Method Completed");
        }
    }
    public class ConstructorsDemo
    {
        public static int x; //It is going to be initialized by static constructor
        public int y; //It is going to be initialized by non-static constructor
        //Static Constructor

        static ConstructorsDemo()
        {
            //This constructor initialized the static variable x with default value i.e. 0
            Console.WriteLine("Static Constructor is Called");
        }

        //Non-Static Constructor
        public ConstructorsDemo()
        {
            //This constructor initialized the variable y with default value i.e. 0
            Console.WriteLine("Non-Static Constructor is Called");
        }
    }
}