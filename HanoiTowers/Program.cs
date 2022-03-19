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

            //for döngüsü ile diskin uzunluğu belirtiliyor ve satırlara atanıyor
            for (int disk = 0; disk < diskler; disk++)
            {
                kuleler[disk, 0] = (disk * 2) + 1;
            }

            //Dış fonksiyonları Main fonksiyonuna çağırıyorum
            kuleleriYaz();
            kuleleriÇözümle(diskler, 0, 2);
            Console.WriteLine("Adım Sayısı : " + adımSayısı);
        }

        //Recurisive fonksiyonum
        public static void kuleleriÇözümle(int diskNo, int eskiSutun, int yeniSutun)
        {
            //Orta sütunun int değeri diğer sütunların değerine göre atanıyor
            int ortaSutun = sutunlar - yeniSutun - eskiSutun;
            if (diskNo == 0)
            {
                //İlk durum disk yok ise bu satır çalışmayacak
            }
            else
            {
                //Disk sayısı bir azaltılarak gönderilen parametrelere göre eski sütundan orta sütuna diskler hareket ediyor
                kuleleriÇözümle(diskNo - 1, eskiSutun, ortaSutun);
                //Diskler hareket ettiriliyor
                diskHareketi(eskiSutun, yeniSutun);
                //Disk sayısı bir azaltılarak gönderilen parametrelere göre orta sütundan yeni sütuna diskler hareket ediyor
                kuleleriÇözümle(diskNo - 1, ortaSutun, yeniSutun);
            }
        }

        //burada disk hareketini tanımlıyorum
        public static void diskHareketi(int eski, int yeni)
        {
            //Fonksiyon her çağrıldığında adım sayısı bir artıyor
            adımSayısı++;
            int disk = 0;
            //Kullanıcının girdiği disk sayısı kontrol ediliyor ve iki boyutlu dizinin ilgili değerinin 0 olması isteniyor.
            while (disk < diskler && kuleler[disk, eski] == 0)
            {
                disk++;
            }
            //Temp değişkeni ile kuleler dizisinin referansını tutuyorum
            int temp = kuleler[disk, eski];
            kuleler[disk, eski] = 0;

            int yeniDisk = 0;
            //Kullanıcının girdiği disk sayısı kontrol ediliyor ve iki boyutlu dizinin ilgili değerinin 0 olması isteniyor.
            while (yeniDisk < diskler && kuleler[yeniDisk, yeni] == 0)
            {
                yeniDisk++;
            }
            //Tuttuğum referansı dizime geri atıyorum ve disklerin yeri değişmiş oluyor
            //Out of bounds hatası almamak için yeniDisk değişkenini bir azaltıyorum
            kuleler[--yeniDisk, yeni] = temp;
            //kuleleriYaz fonksiyonu çağırılıyor
            kuleleriYaz();
        }

        //burada kuleleri ve diskleri ekrana yazıyoruz
        public static void kuleleriYaz()
        {
            for (int disk = 0; disk < diskler; disk++)
            {
                for (int sutun = 0; sutun < sutunlar; sutun++)
                {
                    //Kule veya diskin console a yazıldığı yer
                    Console.Write(aralık(kuleler[disk, sutun]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------");
        }

        //Console ekranında görünüm iyileştirmesi için
        public static string aralık(int disk)
        {
            //Kuleler arası mesafe
            int sutunGenisligi = (diskler * 2) + 2;
            //ilk basım değeri
            string cıkıs = "";
            //Disk yok ise | işareti koyuluyor
            if (disk == 0)
            {
                //Temsili sütun
                cıkıs = "|";
            }
            else
            {
                //Kullanıcı girdisi kadar + işareti koyuluyor
                for (int i = 0; i < disk; i++)
                {
                    //Temsili disk
                    cıkıs += "+";
                }
            }
            //Kulenin sağına koyulan boşluk
            if (cıkıs.Length % 2 == 1)
            {
                cıkıs += " ";
            }
            //Disklerin sol ve sağ taraflarına koyulan boşluk
            while (cıkıs.Length < sutunGenisligi)
            {
                cıkıs = " " + cıkıs + " ";
            }
            return cıkıs;
        }
    }
}
