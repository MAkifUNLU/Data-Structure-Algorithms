using System;

namespace deneme
{
    class Program
    {
        class LinkedListNode
        {
            //personel tutacaz
            public int data;
            public LinkedListNode next;
            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }
        }

        class LinkedList
        {
            int count;
            LinkedListNode head;
            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }
            public void PrintList()
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
