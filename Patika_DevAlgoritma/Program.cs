using System;

namespace Patika_DevAlgoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime giriniz: ");
            string girilenkelime = Console.ReadLine();
            Console.WriteLine();
            restart:
            Console.Write("Lütfen çıkarmak istediğiniz harfin basamak değerini - Basamak değeri sıfırdan başlamaktadır. - giriniz: ");
            int cikarilacakharf = int.Parse(Console.ReadLine());
            if (cikarilacakharf != -1)
            {
                int uzunluk = (girilenkelime.Length) - 1;
                // kelimenin uzunlugunu alıyoruz ama remove metodumuz 0dan yani 0 indexten basladigi icin -1 çıkarma yapıyoruz. Yapmazsak girilen deger ali olsun aliyi 3 olarak hesaplıyacak cikarilacakharf degiskenimize konsolda 3 girersek hesaplamasını yapmayacaktır.
                if (cikarilacakharf < uzunluk || uzunluk == -1)
                {
                    string sonuc = girilenkelime.Remove(cikarilacakharf, 1);
                    Console.WriteLine(sonuc);
                }
                else
                {
                    Console.WriteLine("Çıkarılmak istenen harfin basamak değeri bulunamadı. Lütfen kontrol edip tekrar giriniz.");
                    goto restart;
                }
            }
            
        }
    }
}
