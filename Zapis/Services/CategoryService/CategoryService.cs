using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Zapis.Services.CategoryService
{
    public class CategoryService
    {
        public async Task<List<Category>> GetAllCategories()
        {
            return new List<Category>()
            {
                new Category() { Id = Guid.NewGuid(), Title = "Auto", Description = "Auto Category" },
                new Category() { Id = Guid.NewGuid(), Title = "Fun", Description = "Fun Category" },
                new Category() { Id = Guid.NewGuid(), Title = "Sport", Description = "Sport Category" },
                new Category() { Id = Guid.NewGuid(), Title = "Food", Description = "Food Category" },
                new Category() { Id = Guid.NewGuid(), Title = "Other", Description = "Other Category" }
            };
        }

        public async Task<List<Category>> SearchCategories(string text)
        {
            return new List<Category>()
            {
                new Category() { Id = Guid.NewGuid(), Title = "Auto", Description = "Auto Category" },
                new Category() { Id = Guid.NewGuid(), Title = "Food", Description = "Food Category" }
            };
        }
    }
}