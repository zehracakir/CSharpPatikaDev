using System;

namespace MyConsoleProject
{
    internal class Degiskenler
    {
        public static void Main(string[] args)
        {
            //Ekrana bastırma
            Console.WriteLine("Hello World!");

            //Klavyeden giriş yapma
            Console.WriteLine("Lütfen adınızı girin: ");
            string name = Console.ReadLine();

            //Klavyeden aldığımız veriyi ekrana bastırma 
            Console.WriteLine("Hoşgeldin "+name);

            //Değişkenleri tanımlama ve ekrana bastırma
            byte a = 1;
            Console.WriteLine(a);
            sbyte b = 2;
            Console.WriteLine(b);
            short c = 14;
            Console.WriteLine(c);
            ushort d = 12;
            Console.WriteLine(d);
            int i = 1548;
            Console.WriteLine(i);
            long l = 8;
            Console.WriteLine(l);
            float f = 25;
            Console.WriteLine(f);
            double e = 84;
            System.Console.WriteLine(e);
            string str = "Zehra Çakır";
            Console.WriteLine(str);
            bool b1 = true;
            Console.WriteLine(b1);
            bool b2 = false;
            Console.WriteLine(b2);

            //Datetime Kullanımı
            DateTime dt = DateTime.Now;
            Console.WriteLine("Şu anın tarihi: "+dt);

            //object
            object x = 12;
            Console.WriteLine(x);
            object y = "zehracakir";
            Console.WriteLine(y);
            object z = 4.3;
            Console.WriteLine(z);

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Zehra";
            Console.WriteLine(str1);

            //integer ifadeler
            int t = 2;
            int r = 4;
            //toplama işlemi
            Console.WriteLine(t + r);
            //çıkarma işlemi 
            Console.WriteLine(t - r);
            //çarpma işlemi
            Console.WriteLine(t * r);
            //bölme işlemi
            Console.WriteLine(t / r);

            //boolean ifadeler
            bool bool1= 10 > 5;
            Console.WriteLine(bool1);

            //Değişken dönüşümleri
            string number = "123";
            int number1 = 456;
            string newStringNumber = number+ number1.ToString();
            Console.WriteLine("string->new number= " + newStringNumber);
            int newIntNumber = Convert.ToInt32(number) + number1;
            Console.WriteLine("int->new number= "+newIntNumber);

            //Datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Date: "+datetime);

            //Hour
            string hour = DateTime.Now.ToString("HH/mm");
            Console.WriteLine("Hour: "+hour);






        }
    }
}
