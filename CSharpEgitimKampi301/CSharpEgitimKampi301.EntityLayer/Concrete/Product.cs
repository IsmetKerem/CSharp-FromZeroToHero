using System.Runtime.CompilerServices;
using CsharpEgitimKampi301.Entities;

namespace CsharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal PrdocutPrice { get; set; }
        public string ProductDescription { get; set; }
        public int CatagoryId { get; set; }
        public virtual Category Category { get; set; }
        public List<Order> Orders { get;  set;}
    }


}