using System;
using System.Collections.Generic;
namespace GenericQueueDemo
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
            // Create a Generic Queue of Employees
            Queue<Employee> queueEmployees = new Queue<Employee>();
            // To add an item into the queue, use the Enqueue() method.
            // emp1 is added first, so this employee, will be the first to get out of the queue
            queueEmployees.Enqueue(emp1);
            // emp2 will be queued up next, so employee 2 will be second to get out of the queue
            queueEmployees.Enqueue(emp2);
            // emp3 will be queued up next, so employee 3 will be third to get out of the queue
            queueEmployees.Enqueue(emp3);
            // emp3 will be queued up next, so employee 4 will be fourth to get out of the queue
            queueEmployees.Enqueue(emp4);
            // emp5 will be queued up next, so employee 5 will be fifth to get out of the queue
            queueEmployees.Enqueue(emp5);
            // If you need to loop thru each items in the queue, then we can use the foreach loop 
            // in the same way as we use it with other collection classes. 
            // The foreach loop will only iterate thru the items in the queue, but will not remove them. 
            // Notice that the items from the queue are retrieved in FIFI (First In First Out), order. 
            // The First element added to the queue is the first one to be removed.
            Console.WriteLine("Retrive Using Foreach Loop");
            foreach (Employee emp in queueEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
                Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            }
            Console.WriteLine("------------------------------");
            // To retrieve an item from the queue, use the Dequeue() method. 
            // Notice that the items are dequeued in the same order in which they were enqueued.
            // Dequeue() method removes and returns the item at the beginning of the Queue.
            // Since emp1 object is the one that is enqueued onto the queue first, this object will be
            // first to be dequeued and returned from the queue by using Dequeue() method
            Console.WriteLine("Retrive Using Dequeue Method");
            Employee e1 = queueEmployees.Dequeue();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Gender + " - " + e1.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Employee e2 = queueEmployees.Dequeue();
            Console.WriteLine(e2.ID + " - " + e2.Name + " - " + e2.Gender + " - " + e2.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Employee e3 = queueEmployees.Dequeue();
            Console.WriteLine(e3.ID + " - " + e3.Name + " - " + e3.Gender + " - " + e3.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Employee e4 = queueEmployees.Dequeue();
            Console.WriteLine(e4.ID + " - " + e4.Name + " - " + e4.Gender + " - " + e4.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Employee e5 = queueEmployees.Dequeue();
            Console.WriteLine(e5.ID + " - " + e5.Name + " - " + e5.Gender + " - " + e5.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Console.WriteLine("------------------------------");
            // Now there will be no items left in the queue. 
            // So, let's Enqueue the five objects once again
            queueEmployees.Enqueue(emp1);
            queueEmployees.Enqueue(emp2);
            queueEmployees.Enqueue(emp3);
            queueEmployees.Enqueue(emp4);
            queueEmployees.Enqueue(emp5);
            // To retrieve an item that is present at the beginning of the queue,
            // without removing it, then use the Peek() method.
            Console.WriteLine("Retrive Using Peek Method");
            Employee e101 = queueEmployees.Peek();
            Console.WriteLine(e101.ID + " - " + e101.Name + " - " + e101.Gender + " - " + e101.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Employee e103 = queueEmployees.Peek();
            Console.WriteLine(e103.ID + " - " + e103.Name + " - " + e103.Gender + " - " + e103.Salary);
            Console.WriteLine("Items left in the Queue = " + queueEmployees.Count);
            Console.WriteLine("------------------------------");
            // To check if an item exists in the stack, use Contains() method.
            if (queueEmployees.Contains(emp3))
            {
                Console.WriteLine("Emp3 is in Queue");
            }
            else
            {
                Console.WriteLine("Emp3 is not in queue");
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