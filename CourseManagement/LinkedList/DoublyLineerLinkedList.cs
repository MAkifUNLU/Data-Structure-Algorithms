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
            /* 1. allocate node
            * 2. put in the data */
            NodeD<Course> node = new NodeD<Course>(course);

            /* 3. Make next of new node as head and previous as NULL */
            node.next = head;
            node.prev = null;
            count++;
            /* 4. change prev of head node to new node */
            if (head != null)
                head.prev = node;

            /* 5. move the head to point to the new node */
            head = node;
        }
        public void InsertAfter(NodeD<Course> prev_Node, Course course)
        {

            /*1. check if the given prev_node is NULL */
            if (prev_Node == null)
            {
                Console.WriteLine("The given previous node cannot be NULL ");               
                return;
            }

            /* 2. allocate node
            * 3. put in the data */
            NodeD<Course> node = new NodeD<Course>(course);

            /* 4. Make next of new node as next of prev_node */
            node.next = prev_Node.next;

            /* 5. Make the next of prev_node as new_node */
            prev_Node.next = node;

            /* 6. Make prev_node as previous of new_node */
            node.prev = prev_Node;

            /* 7. Change previous of new_node's next node */
            if (node.next != null)
                node.next.prev = node;
        }

        public void addBack(Course course)
        {
            /* 1. allocate node
             * 2. put in the data */
            NodeD<Course> node = new NodeD<Course>(course);

            NodeD<Course> last = head; /* used in step 5*/

            /* 3. This new node is going to be the last node, so
             * make next of it as NULL*/
            node.next = null;
            count++;
            /* 4. If the Linked List is empty, then make the new
             * node as head */
            if (head == null)
            {
                node.prev = null;
                head = node;
                return;
            }

            /* 5. Else traverse till the last node */
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = node;

            /* 7. Make last node as previous of new node */
            node.prev = last;
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
                    current.next = null;
                    tail = current;
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
        }
    }
}
