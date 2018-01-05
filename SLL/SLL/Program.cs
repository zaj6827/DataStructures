using System;

namespace SLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public RemoveNode(n)
        {
            Node curr = head;
            Node next = curr.next;
            Node prev;

            while(curr != n)
            {
                prev = curr;
                curr = curr.next;
                next = curr.next;

            }

            prev.next = next;
            return head;
        }

        public FindMiddle()
        {
            Node middleNode = head;
            Node lastNode = head;

            while( lastNode.next && lastNode.next.next != null)
            {
                middleNode = middleNode.next;
                lastNode = lastNode.next.next;
            }
            return middleNode;
        }

        public FindNthFromEnd(n) {
            Node sleeper = head;
            Node walker = head;
            int counter = 1;

            while(walker.next != null)
            {
                if(counter >= n)
                {
                    sleeper = sleeper.next;
                }

                walker = walker.next;
                counter++;
            }
            return sleeper;
        }
    }
}
