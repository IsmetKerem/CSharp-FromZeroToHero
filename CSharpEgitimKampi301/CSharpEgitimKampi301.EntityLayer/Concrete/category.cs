using CsharpEgitimKampi301.EntityLayer.Concrete;

namespace CsharpEgitimKampi301.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public bool CatagoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/*
field-variable-property

int x;--> field
*/
