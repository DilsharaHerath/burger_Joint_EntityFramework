using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        // Navigation property for the "ORDER:EMPLOYEE" relationship
        public virtual ICollection<Order> Orders { get; set; }

        public int Administrator_ID { get; set; }

        public Administrator Administrator { get; set; }

        public ICollection<Store> KEEPS { get; set; }
    }
}
