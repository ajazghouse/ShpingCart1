using ShoppingCart.DataAccess.Model;
using ShoppingCart.Services.Data;
using ShoppingCart.Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Services.Respositories
{
    class CategoryRepo : ICategory
    {
        private readonly AppDbContext context;

        public CategoryRepo(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteCategory(Category category)
        {
            context.Categories.Remove(category);
        }

        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            return context.Categories.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void InsertCategory(Category category)
        {
            context.Categories.Add(category);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
        }
    }
}
