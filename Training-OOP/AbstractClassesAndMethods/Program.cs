using System;
namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating child class instance 
            AbsChild absChild = new AbsChild();
            absChild.Add(10, 5);
            absChild.Sub(10, 5);
            absChild.Mul(10, 5);
            absChild.Div(10, 2);
            absChild.Mod(10,5);

            // Creating abstract class reference pointing to child class object
            AbsParent absParent = absChild;
            // Access method using reference
            absParent.Add(10, 5);
            absParent.Sub(10, 5);
            absParent.Mul(10, 5);
            absParent.Div(10, 5);
            //You cannot call the Mod method using Parent reference as it is a pure child class method
            //absParent.Mod(100, 35);
            Console.ReadKey();
        }
    }

    public abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    public class AbsChild : AbsParent // mandatory
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        }
        public void Mod(int x, int y)
        {
            Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
        }
    }
}