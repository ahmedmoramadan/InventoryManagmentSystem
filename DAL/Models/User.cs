using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string UserName { get; set; } = string.Empty;
        [MaxLength(30)]
        public string Password { get; set; } = string.Empty;
        [NotMapped]
        public string ConfirmPassword { get; set; }
        [MaxLength(30)]
        public string Role { get; set; } = string.Empty;
    }
}
