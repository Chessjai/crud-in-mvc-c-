using System.Collections.Generic;

namespace WebApplication17.Models
{
    public class Productdata
    {
        public IEnumerable<Product1> ProductsList
        {
            get
            {
                List<Product1> products = new List<Product1>()
                {
                    new Product1{ProductId=1,Name="Samsung TV",Price=32000.2 },
                    new Product1{ProductId=2,Name="Nike Shoes",Price=2003.2 }
                };
                return products;
            }
        }

    }
}