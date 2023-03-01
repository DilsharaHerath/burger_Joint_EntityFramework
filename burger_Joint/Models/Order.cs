using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace burger_Joint.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Total_amount { get; set; }
        
         // Foreign key property for the related customer
        public int Cus_Id { get; set; }

        // Navigation property for the related customer
        public Customer Customer { get; set; }

        // Navigation property for Payments
        public ICollection<Payment> Payments { get; set; }

        // Foreign key property for the "ORDER:EMPLOYEE" relationship
        public int Employee_ID { get; set; }

        // Navigation property for the "ORDER:EMPLOYEE" relationship
        public virtual Employee Employee { get; set; }
    }
}
