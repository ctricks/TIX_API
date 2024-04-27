using System.ComponentModel.DataAnnotations;

namespace TIX_API.Models
{
    public class OutputUser
    {                
        [Key]
        public string Username { get; set; }        
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
