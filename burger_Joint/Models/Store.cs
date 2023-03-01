using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Store
    {
        [Key]
        public int Item_ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        
        public ICollection<Employee> KEEPS { get; set; }
         
    }
}