using System;
using System.Data.Entity;
using CsharpEgitimKampi301.Entities;
using CsharpEgitimKampi301.EntityLayer.Concrete;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccessLayer.Context;

public class KampContex : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { set; get; }
    public DbSet<Order> Orders { set; get; }
    public DbSet<Customer> Customers { set; get; }
    public DbSet<Admin> Admins { get; set; }
}
