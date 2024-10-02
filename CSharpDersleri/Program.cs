using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDersleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello World !");
            //            Console.WriteLine("What's up");
            //            Console.ReadLine(); //ekranın bekletir.
            //Biz enter a basınca ekran kaybolur
            // MOR RENKLİ KÜP METODTUR

            #region YAZDIRMA KOMUTLARI 

            //Console.WriteLine("******YEMEK KATEGORİLERİ*******");
            //Console.WriteLine();
            //Console.WriteLine("1-ÇORBALAR");
            //Console.WriteLine("2-ANA YEMEKLER");
            //Console.WriteLine("3-SOĞUK BAŞLANGIÇLAR");
            //Console.WriteLine("4-SALATALAR");
            //Console.WriteLine("5-TATLILAR");
            //Console.WriteLine("6-İÇECEKLER");
            //Console.WriteLine();

            //Console.WriteLine("******YEMEK KATEGORİLERİ*******");
            //Console.ReadLine();
            #endregion

            #region STRING DEĞİŞKENLER

            // string değişkenler:
            // Değişken_türü DeğişkenAdı;

            //string name;
            //name = "Tufan";
            //Console.WriteLine(name);


            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone;
            //string customerCity;
            //string customerCountry;

            //customerName = "Tufan";
            //customerSurname = "Özkurt";
            //customerEmail = "tufanozkurt2024@gmail.com";
            //customerPhone = "+90 536 36 00";
            //customerCity = "Adana";
            //customerCountry = "Türkiye";


            //Console.WriteLine("********Rezervasyon Kartı*********");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri Adı : "+customerName);
            //Console.WriteLine("Müşteri Soyadı:"+customerSurname);
            //Console.WriteLine("Tel No : "+customerPhone);
            //Console.WriteLine();
            //Console.WriteLine("********Rezervasyon Kartı*********");
            //Console.ReadLine();



            #endregion

            #region INT DEĞİŞKENLER
            // Tamsayı türündeki değişkenlerdir.

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("*** Restoran Menü Fiyatları ***");
            //Console.WriteLine();
            //Console.WriteLine("----Hamburger : "+hamburgerPrice+ " TL ");
            //Console.WriteLine("----Kola : "+cokePrice+ " TL ");
            //Console.WriteLine("----Su : "+waterPrice+ " TL ");
            //Console.WriteLine("----Limonata : "+lemonadePrice+ " TL ");
            //Console.WriteLine("----Kızartma : "+friesPrice+ " TL ");
            //Console.WriteLine();
            //Console.WriteLine("*** Restoran Menü Fiyatları ***");
            //Console.WriteLine();



            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice;
            //int totalCokePrice;
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //lemonadeCount = 1;
            //friesCount = 1;
            //pizzaCount = 0;

            //totalHamburgerPrice = hamburgerCount* hamburgerPrice;
            //totalCokePrice = cokeCount* cokeCount;
            //totalWaterPrice = waterCount* waterPrice;
            //totalFriesPrice = friesCount* friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice= lemonadeCount* lemonadePrice;

            //Console.WriteLine("*****HESAP*****");
            //Console.WriteLine("Hamburger Tutarı : "+totalHamburgerPrice+ " TL ");
            //Console.WriteLine("Kola Tutarı : "+totalCokePrice+ " TL ");
            //Console.WriteLine("Su Tutarı : "+totalWaterPrice+ " TL ");
            //Console.WriteLine("Pizza Tutarı : "+totalPizzaPrice+ " TL ");
            //Console.WriteLine("Kızartma Tutarı : "+totalFriesPrice+ " TL ");
            //Console.WriteLine("Limonata Tutarı : "+totalLemonadePrice+ " TL ");
            //int allPrice;
            //allPrice = totalHamburgerPrice+totalCokePrice+totalWaterPrice+totalFriesPrice+totalPizzaPrice+totalLemonadePrice;
            //Console.WriteLine("TOPLAM TUTAR : "+allPrice+" TL ");


            //Console.ReadLine();





            #endregion


            #region DOUBLE DEĞİŞKENLER

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.ReadLine();


            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---Elma Birim Fiyatı:"+applePrice+" TL ");
            //Console.WriteLine("---Portakal Birim Fiyatı:"+orangePrice+ " TL ");
            //Console.WriteLine("---Çilek Birim Fiyatı:"+strawberryPrice+ " TL ");
            //Console.WriteLine("---Patates Birim Fiyatı:"+potatoPrice+ " TL ");
            //Console.WriteLine("---Domates Birim Fiyatı:"+tomatoPrice+ " TL ");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=appleGram*applePrice;
            //double orangeTotalPrice=orangeGram*orangePrice;
            //double strawberryTotalPrice=strawberryGram*strawberryPrice;
            //double potatoTotalPrice=potatoGram*potatoPrice;
            //double tomatoTotalPrice=tomatoGram*tomatoGram;


            //Console.WriteLine("Alınan Ürün : Elma-"+"Birim Fiyat: "+applePrice+" TL "+"-Gramaj : "+appleGram+" Toplam Tutar : "+appleTotalPrice+" TL " );
            //Console.WriteLine("Alınan Ürün : Portakal-"+"Birim Fiyat: "+orangePrice+ " TL " + "-Gramaj : " +orangeGram+" Toplam Tutar : "+orangeTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Çilek-"+"Birim Fiyat: "+strawberryPrice+ " TL " + "-Gramaj : " +strawberryGram+" Toplam Tutar : "+strawberryTotalPrice+ " TL ") ;
            //Console.WriteLine("Alınan Ürün : Patates-"+"Birim Fiyat: "+potatoPrice+ " TL " + "-Gramaj : " +potatoGram+" Toplam Tutar : "+potatoTotalPrice + " TL ");
            //Console.WriteLine("Alınan Ürün : Domates-"+"Birim Fiyat: "+tomatoPrice+ " TL " + "-Gramaj : " +tomatoGram+" Toplam Tutar : "+tomatoTotalPrice + " TL ");

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+strawberryTotalPrice+tomatoTotalPrice+potatoTotalPrice;
            //Console.WriteLine("Toplam Tutar: "+shoppingTotalPrice);
            #endregion

            #region CHAR DEĞİŞKENLER

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region KLAVYEDEN VERİ GİRİŞLERİ
            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi :");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC Bilgisi : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu : "+passengerName+" "+passengerSurname+
            //    passengerDistrict+passengerCity+passengerIdentityNumber);

            #endregion


            #region KLAVYEDEN TAM SAYI GİRİŞLERİ VE DÖNÜŞÜMLER

            //int shoesPrice,computerPrice,chairPrice,tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız koltuk sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+
            //    chairCount*chairPrice+tvPrice*tvCount;
            //Console.WriteLine("Ödemeniz gereken tutar: "+totalPrice);



            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI İŞLEMLERİ

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalama: "+result);





            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ

            //char gender;
            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);

            //Console.ReadLine();


            #endregion
        }
    }
}
