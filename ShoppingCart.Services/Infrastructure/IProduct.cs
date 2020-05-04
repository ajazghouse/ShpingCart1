using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Infrastructure
{
   public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int Id);
        public void InsertProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(Product product);
        void Save();
    }
}
