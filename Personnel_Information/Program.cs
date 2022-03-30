using System;

namespace Personnel_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            Personel person1 = new Personel("Akif", "ÜNLÜ", 9000);
            Personel person2 = new Personel("Barış", "ÖZCAN", 2000);
            Personel person3 = new Personel("Selçuk", "BAYRAKTAR", 8000);
            Personel person4 = new Personel("Neşet", "ERTAŞ", 3000);
            Personel person5 = new Personel("Şatlık", "MURADOV", 3000);

            LinkedList list = new LinkedList();

            list.addNode(person1);
            list.addNode(person2);           
            list.addNode(person3);
            list.addNode(person4);
            list.addNode(person5);

            //list.arrangement();
            list.listElements();
            Console.WriteLine("--------------------");
            list.find(2);
            
            
        }
    }
}
