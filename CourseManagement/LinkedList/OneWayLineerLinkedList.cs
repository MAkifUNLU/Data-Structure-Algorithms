using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.LinkedList
{
    class OneWayLineerLinkedList
    {
        public NodeS<Course> head;
        public NodeS<Course> tail;
        public int count = 0;

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
        public bool insertAfter(int position, Course course)
        {

            NodeS<Course> temp = head;
            NodeS<Course> next;
            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.next;
            }

            var node = new NodeS<Course>(course);
            if (temp == head)
            {
                head = node;
            }
            if (temp == tail)
            {
                tail = node;
            }

            next = temp.next;
            temp.next = node;
            node.next = next;

            count++;
            return true;
        }
        public void removeFirst()
        {
            if (count != 0 )
            {
                head = head.next;
                count--;

                if (count==0)
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
        public void removeById(int index)
        {
            NodeS<Course> temp = head;
            if (temp._data.code == index)
            {
                removeFirst();
                return;
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
            NodeS<Course> temp = head;
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
            NodeS<Course> temp = head;
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
            }
        }
    }
}
