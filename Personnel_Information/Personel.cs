using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Information
{
    public class Personel
    {
        private static int tmpId;

        public Personel(string name, string surename , int salary)
        {
            this.name = name;
            this.surename = surename;
            this.registrationNumber = registrationNumber;
            this.salary = salary;
            tmpId++;
            this.registrationNumber = tmpId;
        }

        public string name { get; set; }
        public string surename { get; set; }
        public int registrationNumber { get; set; }
        public int salary { get; set; }

        public void printPerson()
        {
            Console.WriteLine("İsim:" + name);
            Console.WriteLine("Soyisim:" + surename);
            Console.WriteLine("ID:" + registrationNumber);
            Console.WriteLine("Maaş:" + salary);
            Console.WriteLine("--------------");
        }
    }  
}
