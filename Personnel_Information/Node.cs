using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Information
{
    class Node
    {
        public Personel person;
        public Node next;

        public Node(Personel person)
        {
            this.person = person;
            next = null;
        }
    }    
}
