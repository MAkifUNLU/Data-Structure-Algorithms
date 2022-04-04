using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.LinkedList
{
    class OneWayLineerLinkedList
    {
        public NodeL<Course> head;
        public NodeL<Course> tail;
        public int count = 0;

        public void addFront(NodeL<Course> node)
        {
            NodeL<Course> temp = head;
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
            addFront(new NodeL<Course>(course));
        }

        //public void insert(Course node, int x)
        //{
        //    //if (Count>=2)
        //    //{
        //    //    if (x<=Count)
        //    //    {
        //    //        for (int i = 0; i < x; i++)
        //    //        {
        //    //            head = head.next;
        //    //        }

        //    //    }

        //    //}
        //    if (node == null)
        //    {
        //        Console.WriteLine("Hata");
        //        return;
        //    }
        //    Node<Course> noder = new Node<Course>(x);
        //    //Node<Course> temp = head;
        //    noder.next = node.next;
        //    node.next = noder;

        //}
        //public void insert(Course course, int x)
        //{
        //    insert(new Node<Course>(course), x);
        //}
        public void addBack(NodeL<Course> node)
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
            addBack(new NodeL<Course>(course));
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
                    NodeL<Course> current = head;
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
            NodeL<Course> temp = head;
            int count = 0;
            if (temp._data.code == index)
            {
                head = temp.next;
                Console.WriteLine("Removed: Found at [0] index");
            }
            //else if (temp.next == null)
            //{
            //    removeLast();
            //    return;
            //}
            else
            {
                while (temp.next != null)
                {
                    count++;
                    if (temp.next._data.code == index)
                    {
                        temp.next = temp.next.next;
                        Console.WriteLine("Removed: Found at [" + count + "] index");
                    }
                    temp = temp.next;                    
                }
            }

            //Node<Course> temp = head, prev = null;

            //if (temp != null && temp._data.code == index)
            //{
            //    head = temp.next;
            //    return;
            //}

            //while (temp != null && temp._data.code != index)
            //{
            //    prev = temp;
            //    temp = temp.next;
            //}

            //if (temp == null)
            //    return;
            //prev.next = temp.next;
            ////if (true)
            ////{
            ////    Node<Course> current = head;
            ////    //Node<Course> prev = null;
            ////    while (current != null)
            ////    {
            ////        //prev = current;
            ////        if (current._data.code.Equals(index))
            ////        {

            ////            current = current.next;
            ////            Count--;
            ////            break;
            ////        }
            ////        current = current.next;
            ////    }
            ////}
            //if (Count!=0)
            //{
            //    Node<Course> newNode = head;
            //    while (newNode != null)
            //    {
            //        if (newNode._data.code == index)
            //        {
            //            if (newNode == head)
            //            {
            //                Console.WriteLine(index + " silindi");                      
            //                removeFirst();
            //                return;
            //            }
            //            else if (newNode == tail)
            //            {
            //                Console.WriteLine(index + " silindi");
            //                removeLast();
            //                return;
            //            }
            //            else
            //            {
            //                while (newNode!=null)
            //                {
            //                    if (newNode._data.code.Equals(index))
            //                    {
            //                        newNode = newNode.next;
            //                        Count--;
            //                        break;
            //                    }
            //                    newNode.next = newNode.next.next;
            //                }

            //            }
            //            Count--;
            //            return;
            //        }
            //        newNode = newNode.next;
            //    }
            //}
        }
        public void listElements()
        {
            NodeL<Course> temp = head;
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
        public void findCourseById(int index)
        {            
            NodeL<Course> temp = head;
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
            NodeL<Course> temp = head;
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
    }
}
