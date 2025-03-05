using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class UserService  
    {
        private readonly InventoryDbContext context;

        public UserService(InventoryDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            await context.AddAsync(user);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
                return false;

            context.Users.Remove(user);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user != null)
                return user;
            else
                return null;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var oldUser = await context.Users.FindAsync(user.Id);
            if (oldUser == null)
                return false;

            oldUser.UserName = user.UserName;  
            oldUser.Role = user.Role;
            oldUser.Password = user.Password;   

            context.Users.Update(oldUser);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }
    }
}
