#region ForechLoop
// foreach //(1,2,3,4)
// değişken türü
// değişken adı
// ın
// liste, koleksiyon , dizi adı
// string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
// foreach (string city in cities)
// {
//     Console.WriteLine(city);
// }


// foreach (int number in numbers)
// {
//     Console.Write(number);
// }
// foreach (int numberss in numbers)
// {
//     if (numberss % 2 == 0) ;
//     {
//         Console.WriteLine(numberss);
//     }

// }
// int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
// int total = 0;
// foreach (int i in numbers)
// {
//     total += i;
// }
// Console.WriteLine(total);
// List<int> numbers = new List<int>()
// {
//     1,2,3,4,5,8
// };
// foreach (int number in numbers)
// {
// Console.WriteLine(number);

// }

// string word = "Merhaba";
// foreach (char c in word)
// {
//     Console.WriteLine(c);
// }

#endregion
#region Örnek Sınav Sistemi Uygulaması
using System.Diagnostics;

// Console.Write("********* C# Eğitim Kampı Sınavı *****");
// Console.WriteLine();
// Console.WriteLine();
// /// Sınıftaki talebelerin sayısını öğrenme
// Console.WriteLine("-----------------------");
// Console.Write("Sınıfınızda Kaç Talebe Var:");
// int studentcount = int.Parse(Console.ReadLine());
// Console.WriteLine("-----------------------");
// string[] studentname = new string[studentcount];
// double[] studentexamaverge = new double[studentcount];

// for (int i = 0; i < studentcount; i++)
// {
//     Console.Write($"{i + 1}. öğrencinin ismini giriniz:");
//     studentname[i] = Console.ReadLine();
//     double totalexamresult = 0;
//     // her talebe için 3 sınav notu
//     for (int j = 0; j < 3; j++)
//     {
//         Console.Write($"{studentname[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:");
//         double value = double.Parse(Console.ReadLine());
//         totalexamresult += value; // notları toplama işlemini sağlıyor.
//     }
//     studentexamaverge[i] = totalexamresult / 3;

// }

// // sınav ort

// for (int i = 0; i < studentcount; i++)
// {
//     Console.WriteLine($"{studentname[i]} adlı öğrencinin ortalaması: {studentexamaverge[i]}");

//     // talebenin geçip geçmemesi 
//     if (studentexamaverge[i] > 50)
//     {
//         Console.WriteLine($"{studentname[i]} adlı öğrenci dersi geçti");
//     }
//     else
//     {
//         Console.WriteLine($"{studentname[i]}adlı öğrenci dersten kaldı");
//     }
// }
 #endregion
