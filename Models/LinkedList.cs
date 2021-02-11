namespace CodingPractice.Models
{
    public class LinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> pointer;

        public LinkedList()
        {
            head = new ListNode<T>();
            pointer = head;
        }

        public ListNode<T> Add(T value)
        {
            if (value == null)
            {
                return null;
            }

            var node = new ListNode<T>(value);
            pointer.Next = node;
            pointer = pointer.Next;
            return node;
        }
        public void Print()
        {
            var printPointer = head.Next;
            while (printPointer.Next != null)
            {
                System.Console.WriteLine(printPointer.Value);
                printPointer = printPointer.Next;
            }
        }
    }
}