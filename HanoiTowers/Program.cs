using System;

namespace HanoiTowers
{
    class Program
    {
        //Program boyunca sabit olacak olan değişkenleri class dışında statik ve public olarak tanımlıyorum.
        //Console çıktısı için iki boyutlu bir dizi tanımlıyorum.
        public static int[,] kuleler;
        public static int sutunlar = 3;
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
                kuleler[disk, 0] = (disk * 2) + 1;
            }

            
            kuleleriYaz();
            kuleleriÇöz(diskler, 0,2);
            Console.WriteLine("Adım Sayısı : " + adımSayısı);

        }

        public static void kuleleriÇöz(int diskNo, int eskiSutun, int yeniSutun )
        {
            int ortaSutun = sutunlar - yeniSutun - eskiSutun;
            if (diskNo == 0)
            {

            } else
            {
                kuleleriÇöz(diskNo - 1, eskiSutun, ortaSutun);
                diskHareketi(eskiSutun, yeniSutun);
                kuleleriÇöz(diskNo - 1, ortaSutun, yeniSutun);
            } 
        }

        //burada disk hareketini tanımlıyorum
        public static void diskHareketi(int eski, int yeni)
        {
            adımSayısı++;
            int disk = 0;
            while (disk < diskler && kuleler[disk, eski] == 0)
            {
                disk++;
            }

            int temp = kuleler[disk, eski];
            kuleler[disk, eski] = 0;


            int yeniDisk = 0;
            while (yeniDisk < diskler && kuleler[yeniDisk, yeni] == 0)
            {
                yeniDisk++;
            }

            kuleler[--yeniDisk, yeni] = temp;

            kuleleriYaz();
        }

        //burada kuleleri ekrana yazıyoruz  "bir" kule
        public static void kuleleriYaz()
        {
            for (int disk = 0; disk < diskler; disk++)
            {
                for (int sutun = 0; sutun < sutunlar; sutun++)
                {

                    Console.Write(aralık(kuleler[disk, sutun]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Console ekranında görünüm iyileştirmesi için
        public static string aralık(int disk)
        {

            int sutunGenisligi = (diskler * 2) + 2;

            string cıkıs = "";
            if (disk == 0)
            {
                cıkıs = "|";
            }
            else
            {
                for (int i = 0; i < disk; i++)
                {
                    cıkıs += "*";
                }

            }
            if (cıkıs.Length % 2 == 1)
            {
                cıkıs += " ";
            }

            while (cıkıs.Length < sutunGenisligi)
            {
                cıkıs = " " + cıkıs + " ";
            }
            return cıkıs;
        }
    }
}
