using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.LinkedList
{
    class DoublyLineerLinkedList
    {
        public NodeD<Course> head;
        public NodeD<Course> tail;
        public int count = 0;

        public void addFront(Course course)
        {
            NodeD<Course> node = new NodeD<Course>(course);

            node.next = head;
            node.prev = null;
            count++;

            if (head != null)
            {
                head.prev = node;
            }           

            head = node;
        }

        public void addBack(Course course)
        {
            NodeD<Course> node = new NodeD<Course>(course);
            NodeD<Course> last = head;

            node.next = null;
            count++;

            if (head == null)
            {
                node.prev = null;
                head = node;
                return;
            }

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = node;
            node.prev = last;
        }

        public bool insertAfter(int position, Course course)
        {
            NodeD<Course> prev = head;
            NodeD<Course> next;
            for (int i = 0; i < position - 1; i++)
            {
                prev = prev.next;
            }

            var newNode = new NodeD<Course>(course);
            if (prev == head)
            {
                head = newNode;
            }
            if (prev == tail)
            {
                tail = newNode;
            }

            next = prev.next;
            prev.next = newNode;
            next.prev = newNode;
            newNode.prev = prev;
            newNode.next = next;

            count++;
            return true;
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
                    NodeD<Course> current = head;
                    while (current.next != tail)
                    {
                        current = current.next;
                    }
                    tail = current.prev;
                    tail.next = null;
                }
                count--;
            }
        }
        public void removeById(int index)
        {
            NodeD<Course> temp = head;
            int count = 0;
            if (temp._data.code == index)
            {
                head = temp.next;
            }
            else
            {
                while (temp.next != null)
                {
                    count++;
                    if (temp.next._data.code == index)
                    {
                        temp.next = temp.next.next;
                    }
                    temp = temp.next;
                }
            }
        }

        public void findCourseById(int index)
        {
            NodeD<Course> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
            }
            while (temp != null)
            {
                if (temp._data.code == index)
                {
                    Console.WriteLine("Aradığınız kodlu ders bulundu");
                    temp._data.printCours();
                }
                temp = temp.next;
            }
        }
        public void findCoursByName(string index)
        {
            NodeD<Course> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
            }
            while (temp != null)
            {
                if (temp._data.courseName == index)
                {
                    Console.WriteLine("Aradığınız isimli ders bulundu");
                    temp._data.printCours();
                }
                temp = temp.next;
            }
        }
        
        public void listElements()
        {
            NodeD<Course> temp = head;
            if (head == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
                return;
            }
            while (temp != null)
            {
                temp._data.printCours();
                temp = temp.next;
            }
        }
    }
}
