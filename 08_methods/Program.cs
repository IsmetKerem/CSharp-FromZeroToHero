#region Void Metotlar
// yapıyı metot yapan şey () budur.
// Geriye değer döndürmeyen metotlar
// void metrolar
// customer --> listele, ekle ,sil, güncelle
// void customerList()
// {
//     Console.WriteLine("Ali Yıldız");
//     Console.WriteLine("Ayşe Yıldız");
//     Console.WriteLine("Hakan Öztürk");
//     Console.WriteLine("Merve Çınar");

// }
// customerList();

// void sum()
// {
//     int x = 1;
//     int y = 2;
//     int z = x + y;
//     Console.WriteLine(z);
// }
// sum();


#endregion
#region Geriye Değer Döndürmeyen Parametreli Mototlar 
// void writemetot(string customername)
// {
//     Console.WriteLine(customername);
// }
// writemetot("Mehmet Yıldırım");

// using System.Diagnostics;

// void customercard(string name, string surname)
// {
//     Console.WriteLine("Müşteri:" + name + " " + surname);
// }
// customercard("Mehmet", "Yıldız");
// customercard("Ayşegül", "Kaya");
#endregion

#region Geriye Değer Döndürmeyen int Parametreli Mototlar 
// void Sum(int number1, int number2, int number3)
// {
//     int result = number1 + number2 + number3;
//     Console.WriteLine(result);
// }
// Sum(4,5,6);
#endregion
#region Geriye Değer Döndüren Metotlar
// string customername()
// {
//     return "Buse Yıldız";

// }
// customername();
// string studentcard()
// {
//     string name = "Ali";
//     string surname = "Kaya";
//     return name + " " + surname;

// }
// Console.WriteLine(studentcard());
#endregion
#region Geriye Değer Döndüren String Paremetreli Metotlar
// string countrycard(string countryname, string capital, string flagclor)
// {
//     string cardinfo = "Ülke:" + countryname + " " + "Başkent" + capital + " " + "Bayrak rENGİ" + flagclor;
//     return cardinfo;
// }
// string x, y, z;
// Console.Write("Ülke Adını Giriniz:");
// x = Console.ReadLine();
// Console.Write("Başkenti Giriniz:");
// y = Console.ReadLine();
// Console.Write("Bayrak Rengini Giriniz:");
// z = Console.ReadLine();
// Console.WriteLine(countrycard(x, y, z));

#endregion
#region Geriye Değer Döndüren Int Parametreli Metotlar

using System.Diagnostics;

// int Sum(int number1, int number2)
// {
//     int result = number1 + number2;
//     return result;

// }
// Console.WriteLine(Sum(45, 98));
// Console.WriteLine(Sum(54, 98));
// Console.WriteLine(Sum(45, 98));
// Console.WriteLine(Sum(45, 98));
// Console.WriteLine(Sum(45, 98))
;

#endregion
#region Örnek App
string  examresult(string student, int exam1, int exam2, int exam3)
{
    int result = (exam1 + exam2 + exam3) / 3;
    if (result >= 50)
    {
        return student + "İsimli Öğrenci Sınavı Geçti"+"Ortalama: "+ result ;
    }
    else
    {
        return student + "İsimli Öğrenci Geçemedi "+"Ortalama: "+ result ;
    }

}
    Console.Write(examresult("Ali", 25, 41, 85));
#endregion
