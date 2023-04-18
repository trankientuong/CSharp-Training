namespace GenericLinkedListCollection
{
    public class Program
    {
        public static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            LinkedListNode<string> USANode = linkedList.AddLast("USA");
            linkedList.AddLast("Srilanka");
            LinkedListNode<string> UKNode = linkedList.AddLast("UK");
            linkedList.AddLast("Japan");
            Console.WriteLine("Initial LinkedList Elements");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            // Removing Element using Remove(LinkedListNode) method
            // linkedList.Remove(linkedList.First); //Remove First Node
            // linkedList.Remove(linkedList.Last);  //Remove Second Node
            linkedList.Remove(USANode); //Remove Specific Node
            Console.WriteLine("\nLinkedList Elements After Remove(USANode)");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            // Removing Element using Remove(T) method
            linkedList.Remove("UK");
            Console.WriteLine("\nLinkedList Elements After Remove(UK)");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            // Removing Element using RemoveFirst() method
            linkedList.RemoveFirst();
            Console.WriteLine("\nLinkedList Elements After RemoveFirst()");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            // Removing Element using RemoveLast() method
            linkedList.RemoveLast();
            Console.WriteLine("\nLinkedList Elements After RemoveLast()");
            foreach (string item in linkedList)
            {
                Console.WriteLine(item);
            }
            // Removing Element using Clear() method
            linkedList.Clear();
            Console.WriteLine($"\nLinkedList Count After Clear(): {linkedList.Count}");
            Console.ReadKey();
        }
    }
}