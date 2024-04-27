using System.ComponentModel.DataAnnotations;

namespace TIX_API.Models
{
    public class Users
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }          

    }
}
