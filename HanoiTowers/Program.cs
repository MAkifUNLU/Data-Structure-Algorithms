using System;

namespace HanoiTowers
{
    class Program
    {
        //Program boyunca sabit olacak olan değişkenleri class dışında statik ve public olarak tanımlıyorum.
        //Console çıktısı için iki boyutlu bir dizi tanımlıyorum.
        public static int[,] kuleler;
        public static int sutunlar;
        public static int diskler;
        public static int adımSayısı = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Disk sayısını giriniz");
            //Kullanıcıdan disk sayısı alınıyor 
            int deger = int.Parse(Console.ReadLine());
            diskler = deger;
            //İki boyutlu diziye diskleri ve sütunları atıyorum.
            kuleler = new int[diskler, sutunlar];

            //for döngüsü ile ilk kuleye kullanıcının girdiği diskleri koyuyoruz
            for (int disk = 0; disk < diskler; disk++)
            {
                kuleler[diskler, 0] = (disk * 2) - 1; 
            }

            //printTowers();
            //solveTowers
            //scancllose
            //syso(hareket sayısı)

        }

        //burada disk hareketini tanımlıyorum
        public static void diskHareketi(int eski, int yeni)
        {
            adımSayısı++;
            int disk = 0;
            while (disk < diskler && kuleler[disk,eski] == 0)
            {
                disk++;
            }

            int temp = kuleler[disk, eski];
            kuleler[disk, eski] = 0;


            int yeniDisk = 0;
            while (yeniDisk < diskler && kuleler [disk,yeni] == 0 )
            {
                yeniDisk++;
            }

            kuleler[--yeniDisk, yeni] = temp;
            

        }

    }
}
