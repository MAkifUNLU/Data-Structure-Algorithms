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
    } 
}

