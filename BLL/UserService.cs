using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool AddUser(string username, string password, string role)
        {
            var user = new User
            {
                UserName = username,
                Password = password,
                Role = role
            };

            context.Add(user);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool DeleteUser(int id)
        {
            var user = context.Users.Find(id);
            if (user == null)
                return false;

            context.Users.Remove(user);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public List<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
        //return => allow null
        public User? GetUserById(int id)
        {
            var user = context.Users.Find(id);
            return user != null ? user : null;
        }

        public bool UpdateUser(int id, string username, string role, string password)
        {
            var oldUser = context.Users.Find(id);
            if (oldUser == null)
                return false;

            oldUser.UserName = username;
            oldUser.Role = role;
            oldUser.Password = password;

            context.Users.Update(oldUser);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
    }
}
