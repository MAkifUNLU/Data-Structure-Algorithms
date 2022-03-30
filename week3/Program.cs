using System;

namespace week3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int[] array2 = new int[] { 1, 5, 8, 3, 27 };
            int[] array3 = { 1, 5, 8, 3, 27 };

            int[,] array4 = new int[5,5];
            int[,] array5 = new int[,] { {1,5,8,3,27 },{1,5,8,3,27 } };
            int[,] array6 = { { 1, 5, 8, 3, 27 }, { 1, 5, 8, 3, 27 } };

            //Burası hazır fonksiyon ile yapılabilen kısmı
            //foreach (var value in array3)
            //{
            //    Console.WriteLine(value);
            //}

            //Array.Reverse(array3);
            //Console.WriteLine("Ters çevrildikten sonra.");

            //foreach (var item in array3)
            //{
            //    Console.WriteLine(item);
            //}

            int n = array3.Length;
            int[] yeniarray3 = new int[n];

            Console.WriteLine("Tek boyutlu dizinin ilk hali");
            for (int j = 0; j < n; j++)
                Console.Write(array3[j] + " ");

            for (int i = 0; i < n; i++)
            {
                yeniarray3[n - 1 - i] = array3[i];
            }
            Console.WriteLine("");
            Console.WriteLine("Tek boyutlu dizinin ters çevrilmiş hali");
            for (int j = 0; j < n; j++)
                Console.Write(yeniarray3[j] + " ");
            Console.WriteLine("");

            int[,] array7 = { { 1, 3, 2, }, { 1, 4, 5 }, { 3, 4, 2 } };
            Console.WriteLine("İki boyutlu dizi ");
            
            for (int j = 0; j < array7.GetLength(0); j++)
            {
                for (int k = 0; k < array7.GetLength(1); k++)
                {
                    Console.Write(array7[j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("İki boyutlu dizinin ters çevrilmiş hali");
            tersdenYaz(array7);
            Console.WriteLine();

            sıralama();
        }
       
        static void tersdenYaz(int[,] dizi)
        {
            for (int i = (dizi.GetLength(0) - 1); i >= 0; i--)
            {
                for (int j = (dizi.GetLength(1) - 1); j >= 0; j--)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void sıralama()
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girilen sayi : " + sayi);

            Random random = new Random();
            int[] arr = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                arr[i] = random.Next(100,200);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("----------Sıralandıktan sonra----------");
            int min = arr[0];
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.WriteLine(arr[i]);
            }
            //int secim = 0;

            //int secim = Convert.ToInt32(Console.ReadLine());
            //while (secim != 3)
            //{
            //    Console.WriteLine("En küçük eleman için 1 e indise göre silmek için 2 ye basın");
            //    switch (secim)
            //    {
            //        case 1:


            //        case 2:

            //    }
            //    break;
            //}
            int index = 3;
            int count = 0;
            int[] array = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i!= index -1)
                {
                    array[count] = arr[i];
                    count++;
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    } 
}

