using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? cevap 30
            //int, decimal, float, doble, bool (0-1) = değer tip
            //bellekte stack ve heap diye iki alan vardır. değer tip olanlar stackte depolanır ve sayi1 = 10'u sayi1 in değeri 10'dur olarak okur.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ? cevap 999


            //array, class, interface = referas tip
            // sayilar1 olarak stackte tanımlanır "=new" dediğinde heapte [10,20,30] olarak tutar.
            //sayiler1 stackte "101 (referans sayısı)" olarak tutulur [10,20,30] ise heapte "101 (referans sayısı)" olarak tutulur.
            //daha sonrasında sayiler2 stackte "102 (referans sayısı)" olarak tuttulur [100,200,300] ise heapte "102 (referans sayısı)"olarak tuttulur.
            //new heap te yeni adres oluştur demek.
            //sayilar1 = sayilar2 satırı sayilar1 in referans sayısı sayilar2 nin referans sayısına eşittir olarak okunur.
            //sayilar2[0] = 999; kodu sayılar2'nin referans numarasının (102) 0. elamanı 999 a eşittir olarak okunur.
            //bu da sayilar1 in ref numarası artık 102 olduğundan sayilar1 in 0. elamanı 999 olur.
        }
    }
}
