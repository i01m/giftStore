using System.Collections.Generic;
using System.Linq;

namespace GiftsForEveryone.Models
{
    public class FakeProductRepository //: IProductRepository //-don't need fake repository anymore
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Football", Price = 25},
            new Product {Name = "Surf Ball", Price = 179},
            new Product {Name = "Running Shoes", Price = 95}
        }.AsQueryable<Product>();
    }
}