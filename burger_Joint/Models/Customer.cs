using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Customer
    {
        [Key]
        public int Cus_Id { get; set; }
        public string Name { get; set; }
        public int Phone_num { get; set; }
        public string street{ get; set; }
        public string city{ get; set; }
        public string district { get; set; }

        
        // Navigation property for related orders
        public ICollection<Order> Orders { get; set; }
         

    }
}