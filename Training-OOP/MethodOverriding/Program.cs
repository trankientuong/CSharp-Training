using System;

namespace MethodOverriding
{

    class Class1
    {
        //Virtual Function (Overridable Method)
        public virtual void Show()
        {
            //Parent Class Logic Same for All Child Classes
            Console.WriteLine("Parent Class Show Method");
        }
    }
    class Class2 : Class1
    {
        //Overriding Method
        public override void Show()
        {
            //Child Class Reimplementing the Logic
            Console.WriteLine("Child Class Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.Show();

            Employee dev = new Developer()
            {
                Id = 1,
                Name = "Tran Kien Tuong",
                Designation = "Developer",
                Salary = 500000
            };
            double bonus = dev.CalculateBonus(dev.Salary);
            Console.WriteLine($"Name: {dev.Name}, Designation: {dev.Designation}, Salary: {dev.Salary}, Bonus:{bonus}");
            Console.WriteLine();

            Employee manager = new Developer()
            {
                Id = 2,
                Name = "Tran Kien Tuong 2",
                Designation = "Software Manager",
                Salary = 800000
            };
            bonus = dev.CalculateBonus(manager.Salary);
            Console.WriteLine($"Name: {manager.Name}, Designation: {manager.Designation}, Salary: {manager.Salary}, Bonus:{bonus}");
            Console.WriteLine();

            Employee admin = new Developer()
            {
                Id = 3,
                Name = "Tran Kien Tuong 3",
                Designation = "Admin",
                Salary = 300000
            };
            bonus = dev.CalculateBonus(admin.Salary);
            Console.WriteLine($"Name: {admin.Name}, Designation: {admin.Designation}, Salary: {admin.Salary}, Bonus:{bonus}");
            Console.WriteLine();

            Employee emp4 = new Developer
            {
                Id = 1004,
                Name = "Priyanka",
                Salary = 200000,
                Designation = "Developer"
            };
            bonus = emp4.CalculateBonus(emp4.Salary);
            Console.WriteLine($"Name: {emp4.Name}, Designation: {emp4.Designation}, Salary: {emp4.Salary}, Bonus:{bonus}");

            Console.Read();
        }
    }
}