using System;

namespace Personnel_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel { name = "Akif", sureName = "Ünlü", registrationNumber = 1, salary = 4000 };
            Personel personel2 = new Personel { name= "Selçuk", sureName= "Bayraktar", registrationNumber = 2, salary= 5000};
            Personel personel3 = new Personel { name = "Barış", sureName = "Özcan", registrationNumber = 3, salary = 6000 };
            Personel personel4 = new Personel { name = "Neşet", sureName = "Ertaş", registrationNumber = 4, salary = 7000 };
        }


    }
}
