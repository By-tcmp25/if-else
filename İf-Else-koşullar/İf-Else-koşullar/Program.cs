using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf_Else_koşullar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------ İf Else koşullar ------------------------------------------------------------------------------------

            // Burda kullanıcının verdiği değere koşul verdik sözel olarak açıklaması nedir derseniz dedik'ki: 
            // bize verdiğin değer koşullara uyuyo mu eğer uyuyosa if süslü parantezinin içindeki kodları çalıştır.
            // eğer koşullar yanlışsa else süslü parantezinin içindeki kodları çalıştır demiş olucaz
            

            Console.WriteLine("Matematik 1.sınav notun kaç:");    //burda kullanıcıya sorumuzu sorduk.
            string A = Console.ReadLine();                     //burda sorduğumuz orunun cevabını alıp A değerinin içine kaydettik.
                
            int B = int.Parse(A);        // burda aldığımız string değerini matematiksel işlem kullanabilmek için int değerine çevirdik
                                         // biz kullanıcıdan sayısal değer almak istediğimiz için int değrine çevirdik eğer string değerini kullancaksanız gerek yok
            Console.WriteLine("Matematik 2.sınav notun kaç:");
            string C = Console.ReadLine();

            int D = int.Parse(C);

            Console.WriteLine("Matematik 3.sınavı notun kaç:");
            string E = Console.ReadLine();

            int F = int.Parse(E);

            int ortalama = (B + D + F) / 3;
            
            if (ortalama >= 75) // eğer B değeri 75den büyük veya eşitse  bize if süslü parantezindeki kodları çalıştırcak. B değerinide kullanıcıdan almıştık.
            {
                Console.WriteLine("Matematik ortalaman:"+ ortalama );
                Console.WriteLine("Hll sana bu dersin iyiymiş");       // burda ekrana yazı yazdırdık 

            }
            else if (B < 75 && B >=50)   // burda ikinci koşul sundum eğer 1.if değilse bu koşulu kontrol edicek ve
            {                           // burda true değerini alırsa else if süslü parantesinin komutlarını çalıştırcak.
                Console.WriteLine("Matematik ortalaman:" + ortalama);
                Console.WriteLine("derslerin biraz kötü gibi çalışsan düzeltirsin gibi");
            }
            else // burda eğer if koşulları değilse çalıştırcağı kodları söyledik eğer B değeri 75'den küçükse bize else'in süslü prantezindeki kodları çalıştıamsını söyledik.
            {
                Console.WriteLine("Matematik ortalaman:" + ortalama);
                Console.WriteLine("Bu derse biraz daha çalışmalısın dostum"); // burda ekrana yazı yazdırdık

            }


                Console.ReadLine();  // burda yazdırdığımız değerlerin ekranda kalmasını sağladık.



            // --------------------------------------------------------------- İf Else (koşul) konusu  bitmiştir ----------------------------------------------------------------------------



        }
    }
}
