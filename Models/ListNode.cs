namespace CodingPractice.Models
{
    public class ListNode<T>
    {
        public ListNode<T> Next { get; set; }
        public T Value { get; }

        public ListNode()
        {
            Next = null;
            Value = default(T);
        }

        public ListNode(T value)
        {
            Value = value;
        }
    }
}