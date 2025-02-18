using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        public static ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode newHead = ReverseListRecursive(head.next);
            head.next.next = head;
            head.next = null;

            return newHead;
        }

        // Helper function to print the linked list
        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine("null");
        }

        static void Main()
        {
            // Creating the linked list: 1 -> 2 -> 3 -> 4 -> 5 -> null
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            

            head = ReverseListRecursive(head);

            Console.WriteLine("Reversed List:");
            PrintList(head);
        }
    }
}
