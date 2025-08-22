//double number;
//number = 4.85;
//Console.Write(number);

#region Double Değişkenler 
using System.Diagnostics;

Console.WriteLine("***** Fiyat Listesi ******");
Console.WriteLine();

double applePrice, orangePrice, strawberryPrice, patato, tomato;

applePrice = 14.85;
orangePrice = 20.95;
strawberryPrice = 45;
patato = 9.74;
tomato = 6.88;

Console.WriteLine("-----Elma Birim Fiyatı:" + applePrice+"TL");
Console.WriteLine("-----Portakal Birim Fiyatı:" + orangePrice+"TL");
Console.WriteLine("-----Çilek Birim Fiyatı:" + strawberryPrice+"TL");
Console.WriteLine("-----Patetes Birim Fiyatı:" + patato+"TL");
Console.WriteLine("-----Domates Birim Fiyatı:" + tomato+"TL");

double appleGram, orangegram, strawberrygram, patotogram, tomatogram;

appleGram = 1.245;
orangegram = 2.650;
strawberrygram = 0.750;
patotogram = 4.859;
tomatogram = 3.745;
double appleTotalpRİCE = appleGram * applePrice;
double orangeTotalPrice = orangegram * orangegram;
double strawbeeytotalPrice = strawberrygram * strawberryPrice;
double patatototalprice = patotogram * patato;
double TomataTotalPrice = tomato * tomatogram;

Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat:" + applePrice + "Gramaj:" + appleGram + "Toplam Ödenmesi Gereken:" + appleTotalpRİCE);
Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fiyat:" + orangePrice + "Gramaj:" + orangePrice + "Toplam Ödenmesi Gereken:" + orangeTotalPrice);
Console.WriteLine("Alınan Ürün: Çilek -" + "Birim Fiyat:" + strawberryPrice + "Gramaj:" + strawberrygram + "Toplam Ödenmesi Gereken:" + strawbeeytotalPrice);
Console.WriteLine("Alınan Ürün: Patates -" + "Birim Fiyat:" + patato + "Gramaj:" + patotogram + "Toplam Ödenmesi Gereken:" + patatototalprice);
Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fiyat:" + tomato + "Gramaj:" + tomatogram + "Toplam Ödenmesi Gereken:" + TomataTotalPrice);

double shoppingtotalprice = appleTotalpRİCE + orangeTotalPrice + strawbeeytotalPrice + patatototalprice + TomataTotalPrice;
Console.Write(shoppingtotalprice);


#endregion
#region Char Değişkenler,Semboller
//Char değişkenler
//char symbol;
//symbol = 'a';

/// KLAVYEDEN VERİ GİRİŞLERİ
Console.WriteLine("****Sharp Hava Yolları Yolcu Bilgisi");
Console.WriteLine();
string passengerName, passengerSurName, passengerDistrict, customaerCity, cumstomerAge, passengerIdentityNumber;
Console.Write("Yolcu Adı");
passengerName = Console.ReadLine();
Console.Write("Yolcu Soyadı");
passengerSurName = Console.ReadLine();
#endregion
#region Klavyeden Tam Sayı
// 
int shoePrice, computerPrice, chairPrice, tvPrice;
shoePrice = 1000;
computerPrice = 20000;
chairPrice = 5000;
tvPrice = 1200;

int shoecount, computercount, chaircount, tvcunt;

Console.Write("Lütfen Kaç Tane Ayakkabı Aldığınızı Girin:");
shoecount = int.Parse(Console.ReadLine());
Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz:");
computercount= int.Parse(Console.ReadLine());
Console.Write("Lütfen Kaç Tane Sandalye Aldığınızı Girin:");
chaircount = int.Parse(Console.ReadLine());
Console.Write("Lütfen Kaç Tane Televizyon Aldığınızı Girin:");
tvcunt = int.Parse(Console.ReadLine());

int totalprice = shoecount * shoePrice + computercount * computerPrice + chaircount * chairPrice;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(totalprice);
#endregion
#region Klavyeden Ondaklıklı Sayı İşlemleri
double exam1, exam2, exam3, result;
Console.Write("Lütfen 1. sınav notunuzu giriniz:");
exam1 = double.Parse(Console.ReadLine());
Console.Write("Lütfen 2. sınav notunuzu giriniz:");
exam2 = double.Parse(Console.ReadLine());
Console.Write("Lütfen 3. sınav notunuzu giriniz:");
exam3 = double.Parse(Console.ReadLine());

result = (exam1 + exam2 + exam3) / 3;
Console.WriteLine();
Console.WriteLine("Sınav ortalamanız:" + result);


#endregion
#region Klavyeden Karakter Girişleri
char gender;
Console.Write("lütfen Cinsiyet Seçiniz:");
gender = char.Parse(Console.ReadLine());

Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);


#endregion