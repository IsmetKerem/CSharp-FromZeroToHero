// Ado.net 
using System;
using System.Data;
using Microsoft.Data.SqlClient;
Console.WriteLine("***** C# Ürün Katagori Bilgi Sistemi *****");
Console.WriteLine();
Console.WriteLine();

string tablenumber; 
Console.WriteLine("------------------------------------------");
Console.WriteLine("1-Katagoriler:");
Console.WriteLine("2-Ürünler");
Console.WriteLine("3-Siparişler");
Console.WriteLine("4-Çıkış Yap");
Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz:");
tablenumber = Console.ReadLine();
Console.WriteLine("------------------------------------------");

SqlConnection connection = new SqlConnection("Server=localhost,1433;Database=EgitimKampiDb;User ID=SA;Password=yourStrong(!)Password;TrustServerCertificate=True;");
connection.Open();
SqlCommand command = new SqlCommand("Select *From TblCatagory", connection);
SqlDataAdapter adapter = new SqlDataAdapter(command);
// SqlDataAdapter adapter = new SqlDataAdapter(command, connection);  
DataTable dataTable = new DataTable();
adapter.Fill(dataTable);
connection.Close();
foreach (DataRow row in dataTable.Rows)
{
    foreach (var item in row.ItemArray)
    {
        Console.WriteLine(item.ToString());
   }
}