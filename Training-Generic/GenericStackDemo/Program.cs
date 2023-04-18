using System;
using System.Collections.Generic;

namespace GenericStackDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 50000
            };
            // Create a Generic Stack of Employees
            Stack<Employee> stackEmployees = new Stack<Employee>();
            // To add an item into the stack, use the Push() method.
            // emp1 is inserted at the top of the stack
            stackEmployees.Push(emp1);
            // emp2 will be inserted on top of emp1 and now is on top of the stack
            stackEmployees.Push(emp2);
            // emp3 will be inserted on top of emp2 and now is on top of the stack
            stackEmployees.Push(emp3);
            // emp4 will be inserted on top of emp3 and now is on top of the stack
            stackEmployees.Push(emp4);
            // emp5 will be inserted on top of emp4 and now is on top of the stack
            stackEmployees.Push(emp5);
            // If you need to loop thru each items in the stack, then we can use the foreach loop 
            // in the same way as we use it with other collection classes. 
            // The foreach loop will only iterate thru the items in the stack, but will not remove them. 
            // Notice that the items from the stack are retrieved in LIFO (Last In First Out), order. 
            // The last element added to the Stack is the first one to be removed.
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Employee emp in stackEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            }
            Console.WriteLine("------------------------------");
            // To retrieve an item from the stack, use the Pop() method. 
            // This method removes and returns an object at the top of the stack. 
            // Since emp5 object is the one that is pushed onto the stack last, this object will be
            // first to be removed and returned from the stack by the Pop() method
            Console.WriteLine("Retrive Using Pop Method");
            Employee e1 = stackEmployees.Pop();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Employee e2 = stackEmployees.Pop();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Employee e3 = stackEmployees.Pop();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Employee e4 = stackEmployees.Pop();
            Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Employee e5 = stackEmployees.Pop();
            Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Console.WriteLine("------------------------------");
            // Now there will be no items left in the stack. 
            // So, let's push the five objects once again
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            stackEmployees.Push(emp4);
            stackEmployees.Push(emp5);
            // To retrieve an item that is present at the top of the stack, 
            // without removing it, then use the Peek() method.
            Console.WriteLine("Retrive Using Peek Method");
            Employee e105 = stackEmployees.Peek();
            Console.WriteLine(e105.ID + " - " + e105.Name + " - " + e105.Gender + " - " + e105.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            Employee e104 = stackEmployees.Peek();
            Console.WriteLine(e104.ID + " - " + e104.Name + " - " + e104.Gender + " - " + e104.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployees.Count);
            
            Console.WriteLine("------------------------------");
            // To check if an item exists in the stack, use Contains() method.
            if (stackEmployees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}