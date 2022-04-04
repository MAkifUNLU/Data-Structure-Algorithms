using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.LinkedList
{
    class OneWayCircularLinkedList
    {
        public NodeS<Course> head;
        public NodeS<Course> tail;
        public int count = 0;

        public void addFront(NodeS<Course> node)
        {
            NodeS<Course> temp = head;
            head = node;
            head.next = temp;

            count++;
            if (count == 1)
            {
                tail = head;
            }
        }

        public void addFront(Course course)
        {
            addFront(new NodeS<Course>(course));
        }
        public void add(Course course)
        {
            add(new Node)
        }

        public void addBack(NodeS<Course> node)
        {
            if (count == 0)
            {
                head = node;
            }
            else
            {
                tail.next = node;
            }
            tail = node;
            count++;
        }
        public void addBack(Course course)
        {
            addBack(new NodeS<Course>(course));
        }

        public void removeFirst()
        {
            if (count != 0)
            {
                head = head.next;
                count--;

                if (count == 0)
                {
                    tail = null;
                }
            }
            else
            {
                Console.WriteLine("Eleman yok! Silinemez");
            }
        }
        public void removeLast()
        {
            if (count != 0)
            {
                if (count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    NodeS<Course> current = head;
                    while (current.next != tail)
                    {
                        current = current.next;
                    }
                    current.next = null;
                    tail = current;
                }
                count--;
            }
        }
        public void listElements()
        {
            NodeS<Course> temp = head;
            if (head == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
                return;
            }
            while (temp != null)
            {
                temp._data.printCours();
                temp = temp.next;
                head = tail.next;
            }
        }
    }
}
