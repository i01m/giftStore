using System.Collections.Generic;
using System.Linq;


namespace GiftsForEveryone.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        { context = ctx; }

        public IQueryable<Product> Products => context.Products;

        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product dbentry = context.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                if (dbentry.ProductID != 0)
                {
                    dbentry.Name = product.Name;
                    dbentry.Price = product.Price;
                    dbentry.Description = product.Description;
                    dbentry.Category = product.Category;
                }
            }
            context.SaveChanges();
        }

        public Product DeleteProduct(int productID)
        {
            Product dbentry = context.Products.FirstOrDefault(p => p.ProductID == productID);
            if (dbentry != null)
            {
                context.Products.Remove(dbentry);
                context.SaveChanges();
            }
            return dbentry;
        }
    }
}