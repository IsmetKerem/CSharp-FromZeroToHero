
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Data.SqlClient;
 

// crud => create-read-update-Delete

Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
Console.WriteLine();
#region Katagori Ekleme İşlemleri
// Console.WriteLine("-----------");
// Console.Write("Eklemek İstediğiniz Katagori Adı:");
// string catergoryname = Console.ReadLine();
// SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
// command.Parameters.AddWithValue("@p1", catergoryname);
// command.ExecuteNonQuery();
// connection.Close();
// Console.Write("Katagori Başarıyla Eklendi !");
#endregion
#region Ürün Ekleme İşi
// string productName;
// decimal productPrice;
// //bool productStatus;
// Console.Write("Eklemek İstediğiniz Ürün Adı:");
// productName = Console.ReadLine();
// Console.Write("Ürün Fiyatı:");
// productPrice = decimal.Parse(Console.ReadLine());

// SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
// connection.Open();
// SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
// command.Parameters.AddWithValue("@productName", productName);
// command.Parameters.AddWithValue("@productPrice", productPrice);
// command.Parameters.AddWithValue("@productStatus", true);
// command.ExecuteNonQuery();  
// connection.Close();
// Console.Write("Ürün Eklemesi Başarılı! :)");

#endregion
#region Ürün Listeleme İşi
// SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
//  connection.Open();

// SqlCommand command = new SqlCommand("Select *From TblProduct", connection);
// SqlDataAdapter adapter = new SqlDataAdapter(command);
// DataTable dataTable = new DataTable();
// adapter.Fill(dataTable);
// foreach (DataRow row in dataTable.Rows)
// {
//     foreach (var item in row.ItemArray)
//     {
//         Console.Write(item.ToString());
//     }
//     Console.WriteLine(" ");
// }
// connection.Close();
#endregion
#region Ürün Silme İşlemi
// Console.Write("Silinecek Ürün İd Giriniz:");
// int productId = int.Parse(Console.ReadLine());
// SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
//  connection.Open();
// SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
// command.Parameters.AddWithValue("@productId", productId);
// command.ExecuteNonQuery();
// connection.Close();
// Console.WriteLine("Silme İşlemi Yapıldı ");
#endregion
#region Ürün Güncelleme İşlemi
Console.WriteLine("Güncellenek Ürün İd:");
int productıd = int.Parse(Console.ReadLine());
Console.WriteLine("Güncellenecek Ürün Adı:");
string productname = Console.ReadLine();

Console.WriteLine("Güncellenecek Ürün Fiyatı:"); // eksik olan satır
decimal productprice = decimal.Parse(Console.ReadLine());


SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
 connection.Open();
SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName=@productName, ProductPrice=@productPrice WHERE ProductId=@productId", connection);

command.Parameters.AddWithValue("@productName", productname);
command.Parameters.AddWithValue("@productPrice", productprice);
command.Parameters.AddWithValue("@productId", productıd);
command.ExecuteNonQuery();
connection.Close();
Console.WriteLine("Güncelleme Başarılı");
#endregion
