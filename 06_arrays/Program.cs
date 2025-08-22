#region Temel Dizi Örnekleri
// 2-4-6-8 (sayı dizisi)
// sarı lavciret (renk dizisi)
// değişken türü [] diziadi= new değişkentürü[eleman sayısı]

// string[] colars = new string[4];
// colars[0] = "Kırmızı";
// colars[1] = "Sarı";
// colars[2] = "Lavcirevt";
// colars[3] = "Turuncu";
// Console.WriteLine(colars[2]);

// string[] cities = new string[5];

// cities[0] = "milano";
// cities[1] = "budapeşte";
// cities[2] = "Lyon";
// cities[3] = "Kahire";
// cities[4] = "Üsküp";
// Console.WriteLine(cities[4]);

// int[] numbers = new int[10];
// numbers[0] = 50;
// numbers[1] = 48;
// numbers[2] = 698;
// numbers[3] = 24;
// numbers[4] = 748;
// Console.WriteLine(numbers[7]);

// string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
// Console.WriteLine(cities[2]);
#endregion
#region  Dizideki Tüm Elamanları Listeleme
//string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
//for (int i = 0; i < colors.Length; i++)
//{
//    Console.WriteLine(colors[i]);
//}

//int[] numbers = { 4, 85, 96, 74, 125, 638, 488, 7456, 2365, 1122 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 3 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}

//char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
//for (int i = 0; i < symbols.Length; i++)
//{
//    Console.WriteLine(symbols[i]);
//}

//int[] my_array = { 47, 85, 96, 87, 32, 152, 658, 140 };
//int maxnumber = my_array[0];
//for (int i = 0; i < my_array.Length; i++)
//{
//    if (my_array[i] > maxnumber)
//    {
//        maxnumber = my_array[i];
//    }
//}
//Console.WriteLine(maxnumber);

//string[] persons = { "ali", "ahmet", "ayşe", "birgül", "cem", "deniz" };
//Console.WriteLine(persons.Length);

//int[] numbers = { 1, 2, 45, 82, 86, 10, 35 };
//Array.Sort(numbers); // Küçükten büyüğe sıralıyor
//for (int i = 0; i < numbers.Length; i++)
//{ 
//    Console.WriteLine(numbers[i]);
//}

//int[] numbers = { 1, 2, 45, 82, 86, 10, 35 };
//Array.Reverse(numbers); // Diziyi tersten yazıyor
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

#endregion
#region dizi metodları
// string[] persons = { "ali", "veli", "buse", "ayşegül", "merve", "çınar", "kaya" };
// int index = Array.IndexOf(persons, "veli");
// Console.WriteLine(index);

// int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
// Console.WriteLine("Dizinin En büyük elemanı" + numbers.Max() + "Dizinin En Küçük Elamanı" + numbers.Min());


#endregion
#region kullacıdan değer alma

//string[] cities = new string[5];
//for (int i = 0; i < cities.Length; i++)
//{
//    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
//    cities[i] = Console.ReadLine();
//}
//Console.WriteLine();
//Console.WriteLine("------------------------");
//for (int i = 0; i < cities.Length; i++)
//{
//    Console.WriteLine(cities[i]);
//}

//int[] numbers = { 10, 20, 30, 40, 50 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine(sum);

//int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
//Console.WriteLine("Çift Sayılar");
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}
//Console.WriteLine();
//Console.WriteLine("Tek Sayılar");
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 1)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}


#endregion
