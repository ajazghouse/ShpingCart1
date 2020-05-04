using ShoppingCart.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Services.Infrastructure
{
  public  interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int Id);
      public void InsertCategory(Category category);
        public void UpdateCategory(Category category);
        public void DeleteCategory(Category category);
        void Save();
    }
}
