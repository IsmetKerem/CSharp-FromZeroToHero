#region For Döngüsü İşlemleri Ve Uygulaması

//int i;
//for (i = 0; i <= 5; i++)
//{
//    Console.WriteLine("C# Eğitim Kampı");
//}

//for (int i = 1; i <= 20; i++)
//{ 
//    Console.WriteLine(i);
//}

//for (int i = 3; i <= 50; i += 3)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
//int finishValue = int.Parse(Console.ReadLine());

//for (int i = 0; i < finishValue; i++)
//{
//    Console.WriteLine("Yaşasın Cumhuriyet");
//}

#endregion
#region For Döngüsü ile Karar Yapilari

//for (int i = 0; i <= 100; i++)
//{
//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int totalvalue = 0;
//for (int i = 1; i <= 10; i++)
//{
//    totalvalue += i;
//}
//Console.WriteLine(totalvalue);

//int totalValue = 0;
//for (int i = 1; i < 20; i++) 
//{
//    if (i % 2 == 0) 
//    { 
//        totalValue += i;
//        Console.WriteLine(i);
//    }   
//}
//Console.WriteLine("-------------");
//Console.WriteLine(totalValue);

//int count = 0;
//for (int i = 1; i <= 50; i++)
//{
//    if (i % 7 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//int bacterium = 1;
//for (int i = 1; i <= 24; i++)
//{
//    bacterium *= 2;
//    Console.WriteLine(i + ". Saat Sonunda: " + bacterium);
//}

#endregion
#region While Döngüsü Uygulaması Ve İşlemleri

//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine("Merhaba Döngüler");
//    i++;
//}

//int i = 1;
//while (i <= 10)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}

//int i = 1, sum = 0;
//while (i <= 10) 
//{
//    sum += i;
//    i++;
//}
//Console.WriteLine(sum);

#endregion
#region Örnek Soru Uygulaması

//int number, total = 0, i, figure;
//Console.Write("Lütfen 3 basamaklı sayı giriniz: ");
//number = int.Parse(Console.ReadLine());

//for (i = 0; i < 3; i++)
//{
//    figure = number % 10;
//    number = number - figure;
//    number = number / 10;
//    total += figure;
//}
//Console.WriteLine("Toplam: " + total);

#endregion
