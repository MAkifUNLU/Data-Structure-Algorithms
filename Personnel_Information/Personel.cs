using System;
using System.Collections.Generic;
using System.Text;

namespace Personnel_Information
{
    public class Personel
    {
        private static int tmpId;

        public Personel(string name, string sureName , int salary)
        {
            this.name = name;
            this.sureName = sureName;
            this.registrationNumber = registrationNumber;
            this.salary = salary;
            tmpId++;
            this.registrationNumber = tmpId;
        }

        public string name { get; set; }
        public string sureName { get; set; }
        public int registrationNumber { get; set; }
        public int salary { get; set; }

        public void printPerson()
        {
            Console.WriteLine("İsim:" + name);
            Console.WriteLine("Soyisim:" + sureName);
            Console.WriteLine("ID:" + registrationNumber);
            Console.WriteLine("Maaş:" + salary);
        }
    }  
}
