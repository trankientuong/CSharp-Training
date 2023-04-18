using System;
namespace GenericConstraint 
{
    // public class GenericClass<T> where T: class
    // {
    //     public T Message;
    //     public void GenericMethod(T Param1, T Param2)
    //     {
    //         Console.WriteLine($"Message: {Message}");
    //         Console.WriteLine($"Param1: {Param1}");
    //         Console.WriteLine($"Param2: {Param2}");
    //     }
    // }

    // public class GenericClass<T> where T: struct
    // {
    //     public T Message;
    //     public void GenericMethod(T Param1, T Param2)
    //     {
    //         Console.WriteLine($"Message: {Message}");
    //         Console.WriteLine($"Param1: {Param1}");
    //         Console.WriteLine($"Param2: {Param2}");
    //     }
    // }

    // public class GenericClass<T> where T: new()
    // {
    //     public T Message;
    //     public void GenericMethod(T Param1, T Param2)
    //     {
    //         Console.WriteLine($"Message: {Message}");
    //         Console.WriteLine($"Param1: {Param1}");
    //         Console.WriteLine($"Param2: {Param2}");
    //     }
    // }

    // public class GenericClass<T> where T: BaseEmployee
    // {
    //     public T Message;
    //     public void GenericMethod(T Param1, T Param2)
    //     {
    //         Console.WriteLine($"Message: {Message}");
    //         Console.WriteLine($"Param1: {Param1}");
    //         Console.WriteLine($"Param2: {Param2}");
    //     }
    // }

    public class BaseEmployee
    {

    }

    public interface IEmployee
    {

    }

    public class Employee : BaseEmployee,IEmployee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Customer(string customerName, string customerLocation)
        {
            Name = customerName;
            Location = customerLocation;
        }
    }

    // public class GenericClass<T, U> where T : U
    // {
    //     public T Message;
    //     public void GenericMethod(T Param1, U Param2)
    //     {
    //         Console.WriteLine($"Message: {Message}");
    //         Console.WriteLine($"Param1: {Param1}");
    //         Console.WriteLine($"Param2: {Param2}");
    //     }
    // }

    public class Program 
    {        
        static void Main(string[] args)
        {
            /* 
                1. where T: struct => The type argument must be non-nullable value types such as primitive data types int, double, char, bool, float, etc. The struct constraint can’t be combined with the unmanaged constraint.
                2. where T: class => The type argument must be a reference type. This constraint can be applied to any class (non-nullable), interface, delegate, or array type in C#.
                3. where T: new() => The type argument must be a reference type that has a public parameterless (default) constructor.
                4. where T: <base class name> => The type of argument must be or derive from the specified base class.
                5. where T: <interface name> => The type argument must be or implement the specified interface. Also, multiple interface constraints can be specified.
                6. where T: U => The type argument supplied for must be or derive from the argument supplied for U. In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type. If U is a nullable reference type, T may be either nullable or non-nullable.
            */

            /*
            1. where T: struct => The type argument must be non-nullable value types such as primitive data types int, double, char, bool, float, etc. The struct constraint can’t be combined with the unmanaged constraint.
            GenericClass<int> intClass = new GenericClass<int>();
            intClass.Message = 30;
            intClass.GenericMethod(10, 20); 
            */

            /* 
            2. where T: class => The type argument must be a reference type. This constraint can be applied to any class (non-nullable), interface, delegate, or array type in C#.
            GenericClass<string> stringClass = new GenericClass<string>();
            stringClass.Message = "Welcome to DotNetTutorials";
            stringClass.GenericMethod("Anurag Mohanty", "Bhubaneswar");
            GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();
            Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
            Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
            Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };
            EmployeeClass.Message = emp1;
            EmployeeClass.GenericMethod(emp2, emp3);
            */

            /*
            3. where T: new() => The type argument must be a reference type that has a public parameterless (default) constructor.
            GenericClass<Employee> employee = new GenericClass<Employee>();
            Employee emp1 = new Employee() { Name = "Anurag", Location = "Bhubaneswar" };
            Employee emp2 = new Employee() { Name = "Mohanty", Location = "Cuttack" };
            Employee emp3 = new Employee() { Name = "Sambit", Location = "Delhi" };
            employee.Message = emp1;
            employee.GenericMethod(emp2, emp3);
            //CompileTime Error, as Customer class has Parameterized constructor
            //GenericClass<Customer> customer = new GenericClass<Customer>();
            */

            /*
            4. where T: <base class name> => The type of argument must be or derive from the specified base class.
            //No Error, as Emplyoee is a derived class of BaseEmployee class
            GenericClass<Employee> employee = new GenericClass<Employee>();
            Employee emp1 = new Employee() { Name = "Anurag" };
            Employee emp2 = new Employee() { Name = "Mohanty" };
            Employee emp3 = new Employee() { Name = "Sambit" };
            employee.Message = emp1;
            employee.GenericMethod(emp2, emp3);
            //CompileTime Error, as Customer is not a derived class of BaseEmployee class
            //GenericClass<Customer> customer = new GenericClass<Customer>();
            */
            
            /*
            5. where T: <interface name> => The type argument must be or implement the specified interface. Also, multiple interface constraints can be specified.
            //No Error, as Emplyoee class Implement the IEmployee Interface
            GenericClass<Employee> employee = new GenericClass<Employee>();
            Employee emp1 = new Employee() { Name = "Anurag" };
            Employee emp2 = new Employee() { Name = "Mohanty" };
            Employee emp3 = new Employee() { Name = "Sambit" };
            employee.Message = emp1;
            employee.GenericMethod(emp2, emp3);
            //CompileTime Error, as Customer is not Implement the IEmployee Interface
            //GenericClass<Customer> customer = new GenericClass<Customer>(); 
            */

            /*
            6. where T: U => The type argument supplied for must be or derive from the argument supplied for U. In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type. If U is a nullable reference type, T may be either nullable or non-nullable.
            //No Error, as Emplyoee class Implement the IEmployee Interface i.e. T Implements U
            GenericClass<Employee, IEmployee> employeeGenericClass = new GenericClass<Employee, IEmployee>();
            //CompileTime Error, as Customer is not Implement the IEmployee Interface i.e. T does not Implements U
            //GenericClass<Customer, IEmployee> customerGenericClass = new GenericClass<Customer, IEmployee>();
            */

            Console.ReadKey();
        }
    }
}