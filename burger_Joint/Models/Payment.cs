using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Payment
    {
        [Key]
        public int Payment_Id { get; set; }
        public string method { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; }

        
        // Foreign key referencing Order
        public int Order_Id { get; set; }
        public Order Order { get; set; }
         

    }
}
