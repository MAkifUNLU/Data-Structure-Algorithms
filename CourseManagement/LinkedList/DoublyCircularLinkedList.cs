using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.LinkedList
{
    class DoublyCircularLinkedList
    {
        public NodeD<Course> head;
        public NodeD<Course> tail;
        public int count = 0;

        public void listElements()
        {
            NodeD<Course> temp = head;
            if (head == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
                return;
            }
            do
            {
                temp._data.printCours();
                temp = temp.next;
            } while (temp != head);
        }

        public void addBack(Course course)
        {
            count++;
            if (head == null)
            {
                NodeD<Course> node1 = new NodeD<Course>(course);
                node1._data = course;
                node1.next = node1.prev = node1;
                head = node1;
                return;
            }
            
            NodeD<Course> last = (head).prev;

            NodeD<Course> node = new NodeD<Course>(course);

            node._data = course;
            node.next = head;
            (head).prev = node;
            node.prev = last;
            last.next = node;
            tail = head;
        }
        public void addFront(Course course)
        {
            if (head == null)
            {
                NodeD<Course> node1 = new NodeD<Course>(course);
                node1._data = course;
                node1.next = node1.prev = node1;
                head = node1;
                return;
            }
            else
            {
                NodeD<Course> last = (head).prev;

                NodeD<Course> node = new NodeD<Course>(course);

                node._data = course;
                node.next = head;
                node.prev = last;
                last.next = (head).prev = node;
                head = node;
            }
            count++;
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
        public void removeById(int index)
        {
            if (head == null)
                return;
            if (head.next == head && head._data.code == index)
            {
                head = null;
                return;
            }
            if (head.next._data.code == index)
            {
                head.next = head.next.next;
                return;
            }
            NodeD<Course> p = head.next;
            while (p.next != head.next)
            {
                if (p.next._data.code == index)
                    break;
                p = p.next;
            }
            if (p.next == head.next)
                Console.WriteLine(index + "Ders listede bulunamadı");
            else
            {
                p.next = p.next.next;
                if (head._data.code == index)
                    head = p;
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
                    return;
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
                    return;
                }
                temp = temp.next;
            }
        }
    }
}
