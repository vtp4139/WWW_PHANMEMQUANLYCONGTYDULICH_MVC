using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourManager.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
       
        public string CustomerName { get; set; }
        public string IDCard { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
