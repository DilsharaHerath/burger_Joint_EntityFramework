using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Administrator
    {
        [Key]
        public int Administrator_ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        
        // Navigation property
        public ICollection<Employee> Employees { get; set; }
        
    }
}
