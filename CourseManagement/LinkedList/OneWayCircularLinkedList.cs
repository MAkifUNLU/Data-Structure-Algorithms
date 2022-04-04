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

        //public void addFront(NodeS<Course> node)
        //{
        //    NodeS<Course> temp = head;
        //    head = node;
        //    head.next = temp;

        //    count++;
        //    if (count == 1)
        //    {
        //        tail = head;
        //    }
        //}

        //public void addFront(Course course)
        //{
        //    addFront(new NodeS<Course>(course));
        //}
        public void listElements()
        {
            NodeS<Course> temp = head;
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
        public void add(NodeS<Course> node)
        {
            NodeS<Course> temp = head;
            head = node;
            if (head == null)
            {
                head = temp;
            }
            else
            {
                tail.next = temp;
            }

            tail = temp;
            tail.next = head;
        }
        public void add(Course course)
        {
            add(new NodeS<Course>(course));
        }

        public void addBack(NodeS<Course> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
                node.next = head;
            }
            else
            {
                tail.next = node;
                tail = node;
                tail.next = head;
            }
            //tail = node;
            count++;
        }
        public void addBack(Course course)
        {
            addBack(new NodeS<Course>(course));
        }
     
        //public void removeById(int index)
        //{
        //    NodeS<Course> temp = head;
        //    int count = 0;
        //    if (temp._data.code == index)
        //    {
        //        head = temp.next;
        //        Console.WriteLine("Removed: Found at [0] index");
        //    }
        //    //else if (temp.next == null)
        //    //{
        //    //    removeLast();
        //    //    return;
        //    //}
        //    else
        //    {
        //        while (temp.next != null)
        //        {
        //            count++;
        //            if (temp.next._data.code == index)
        //            {
        //                temp.next = temp.next.next;
        //                Console.WriteLine("Removed: Found at [" + count + "] index");
        //                listElements();
        //            }
        //            temp = temp.next;
        //        }
        //    }         
        //}
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
            NodeS<Course> p = head.next;
            while (p.next != head.next)
            {
                if (p.next._data.code == index)
                    break;
                p = p.next;
            }
            if (p.next == head.next)
                Console.WriteLine(index + "not found in the list");
            else
            {
                p.next = p.next.next;
                if (head._data.code == index)
                    head = p;
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
                    return;
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
                    return;
                }
                temp = temp.next;
            }
        }
        //    public void removeFirst()
        //{
        //    if (count != 0)
        //    {
        //        head = head.next;
        //        count--;

        //        if (count == 0)
        //        {
        //            tail = null;
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Eleman yok! Silinemez");
        //    }
        //}
        //public void removeLast()
        //{
        //    if (count != 0)
        //    {
        //        if (count == 1)
        //        {
        //            head = null;
        //            tail = null;
        //        }
        //        else
        //        {
        //            NodeS<Course> current = head;
        //            while (current.next != tail)
        //            {
        //                current = current.next;
        //            }
        //            current.next = null;
        //            tail = current;
        //        }
        //        count--;
        //    }
    }
        
}

