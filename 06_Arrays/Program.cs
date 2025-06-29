using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// temel dizi örnekleri
            ////değişkentürü[] diziadı = new değişkentürü[elemansayısı];
            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "blue";
            //colors[2] = "white";
            //colors[3] = "green";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[4]);

            ////10 boyutlu bir dizi tanımladık diyelim
            ////1-2-3 ve 7. indexlere atama yaptık diğerlerine yapmadık 
            ////diğerlerini ekrana basarsan 0 döndürür sen atama yapmasanda

            ////bir diğer dizi oluşturma yöntemi
            //string[] cities1 = { "prag", "roma" };

            ////dizideki tüm elemanları listeleme
            //string[] colors2 = { "kırmızı", "yeşil", "pembe", "mor", "beyaz", "siyah" };
            //for(int i = 0; i < colors2.Length; i++)
            //{
            //    Console.WriteLine(colors2[i]);
            //}

            //int[] numbers = { 1, 96, 43, 3635, 24, 46, 522, 645, 867 };
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0 )
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            ////dizideki en büyük elemanı bulma
            //int[] myArray = { 43, 56, 76, 23, 87, 68, 34, 83, 62 };
            //int max = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > max)
            //    {
            //        max = myArray[i];
            //    }
            //}
            //Console.WriteLine("en büyük eleman : " + max);

            //int[] myArray = { 43, 56, 76, 23, 87, 68, 34, 83, 62 };
            //Array.Sort(myArray);
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            ////tersten sıralama
            //int[] myArray2 = { 43, 56, 76, 23, 87, 68, 34, 83, 62 };
            //Array.Reverse(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            ////dizilerde indexof of metodu
            //string[] customers = { "ali", "buse", "ayşegül", "fatma", "mehmet" };
            ////int index = Array.IndexOf(customers, "buse");
            ////Console.WriteLine(index);
            ////veya
            //Console.WriteLine(Array.IndexOf(customers, "buse"));

            //kullanıcıdan alınan değeri diziye atama...
            string[] cities = new string[3];

            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine("lütfen " + (i + 1) + ".şehri giriniz");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }







            Console.Read();
        }
    }
}
