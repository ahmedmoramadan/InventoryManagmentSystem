using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    class CategoryService
    {
        private readonly InventoryDbContext context;
        public CategoryService(InventoryDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddCategoryAsync(Category category)
        {
            if (category == null)
            {
                return false;
            }
            await context.AddAsync(category);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }
        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            if (category == null)
            {
                return false;
            }

            var oldcategory = await context.Categories.FindAsync(category.Id);
            if (oldcategory == null)
            {
                return false;
            }

            oldcategory.Name = category.Name;
            oldcategory.Id = category.Id;
            context.Categories.Update(oldcategory);           

            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteCategoryAsync(int id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null)
            {
                return false;
            }

            context.Categories.Remove(category);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }


        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await context.Categories.ToListAsync();
        }


        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await context.Categories.FindAsync(id);
        }
    }


}

