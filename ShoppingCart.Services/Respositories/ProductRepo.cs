using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Services.Data;
using ShoppingCart.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Services.Respositories
{
     class ProductRepo : IProduct
    {
        private readonly AppDbContext context;

        public ProductRepo(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            return context.Products.Include(x => x.Categories).ThenInclude(y => y.Category).Where(a=>a.Id==Id).FirstOrDefault();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
