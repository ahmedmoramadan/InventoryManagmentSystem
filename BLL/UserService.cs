using DAL;
using DAL.Models;

namespace BLL
{
    public class UserService
    {
        private readonly InventoryDbContext context;

        public UserService()
        {
            context = new InventoryDbContext();
        }

        public string AddUser(string username, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Username and password cannot be empty.";
            }
            if (password.Length < 8)
            {
                return "Password must be at least 8 characters long.";
            }
            if (context.Users.Any(u => u.UserName == username))
            {
                return "The username already exists. Please choose another one.";
            }
            var user = new User
            {
                UserName = username,
                Password = password,
                Role = role
            };

            context.Add(user);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0 ? "User added successfully" : "Failed to add user";
        }

        public bool DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == id); ;
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
        public User? GetUserById(int id)
        {
            var user = context.Users.Find(id);
            return user != null ? user : null;
        }

        public bool UpdateUser(int id, string username, string role, string password)
        {
            var oldUser = context.Users.FirstOrDefault(u => u.Id == id); ;
            if (oldUser == null)
                return false;

            if (string.IsNullOrWhiteSpace(username) || username.Length < 3 || username.Length > 30)
            {
                return false;
            }

            oldUser.UserName = username;
            oldUser.Role = role;
            oldUser.Password = password;

            context.Users.Update(oldUser);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public string? AuthenticateUser(string username, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null) return user.Role;
            return null;
        }
        public IEnumerable<object> SearchUsers(string username, string? role)
        {
            var query = context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(username))
            {
                query = query.Where(u => u.UserName.Contains(username));
            }

            if (role != null && role != "All")
            {
                query = query.Where(u => u.Role == role);
            }

            var results = query.Select(u => new
            {
                u.UserName,
                u.Role,
            }).ToList();
            return results;
        }
    }
}