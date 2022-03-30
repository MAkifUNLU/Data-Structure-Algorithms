using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Information
{
    public class LinkedList
    {
        Node head;
        public int counter;

        public LinkedList()
        {
            this.head = null;
        }

        public void addNode(Personel personel)
        {
            Node willBeAdded = new Node(personel);
            if (head == null)
            {
                head = willBeAdded;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                if (temp.person.registrationNumber == personel.registrationNumber)
                {
                    Console.WriteLine("Mevcut sicil numaralı personel bulunmakta.");
                    return;
                }
                temp = temp.next;
            }
            temp.next = willBeAdded;
        }

        public void listElements()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
                return;
            }
            while (temp != null)
            {
                temp.person.printPerson();
                temp = temp.next;
            }
        }

        public void find(string name, string surname)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
            }
            while (temp != null)
            {
                if (temp.person.name.Equals(name) && temp.person.sureName.Equals(surname))                  
                {
                    Console.WriteLine("Personel bulundu");
                    temp.person.printPerson();
                }
                temp = temp.next;
            }
        }
        // add methodu çalışmıyor düzenlenecek
        public void add(Personel personel)
        {
            
            Node pWillBeAdded = new Node(personel);

            Console.WriteLine("Adınızı giriniz");
            string aName = Console.ReadLine();
            pWillBeAdded.person.name = aName;

            Console.WriteLine("Soyadınızı giriniz");
            string aSureName = Console.ReadLine();
            pWillBeAdded.person.name = aSureName;

            Console.WriteLine("Sicil nunnmaranızı giriniz");
            string aRegistrationNumber = Console.ReadLine();
            pWillBeAdded.person.name = aRegistrationNumber;

            Console.WriteLine("Adınızı giriniz");
            string aSalary = Console.ReadLine();
            pWillBeAdded.person.name = aSalary;           

            if (head == null)
            {
                head = pWillBeAdded;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.person.registrationNumber == personel.registrationNumber)
                {
                    Console.WriteLine("Personel eklendi");
                    return;
                }
                temp = temp.next;
            }
            temp.next = pWillBeAdded;
        }
        public void find(int id)
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
            }
            while (temp != null)
            {
                if (temp.person.registrationNumber == id)
                {
                    Console.WriteLine("Aradığınız sicil numaralı personel bulundu");
                    temp.person.printPerson();
                }
                temp = temp.next;
            }
        }

        public void arrangement()
        {
            LinkedList linkedList = new LinkedList();

            Node temp = head;
            Node index = null;
            Personel tempItem;
            if (temp == null)
            {
                Console.WriteLine("Listenizde eleman yoktur.");
                return;
            }
            
            while (temp != null)
            {
                index = temp.next;
                while (index != null)
                {
                    if (temp.person.registrationNumber > index.person.registrationNumber)
                    {
                        tempItem = temp.person;
                        temp.person = index.person;
                        index.person = tempItem;
                    }
                    index = index.next;
                }
                temp = temp.next;
            }
        }
    }
}
