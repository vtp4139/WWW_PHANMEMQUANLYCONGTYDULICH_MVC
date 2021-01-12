using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Feedback")]
    public class eFeedback
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int feedbackID { get; set; }

        public DateTime dateCreate { get; set; }
        public string title { get; set; }
        public string content { get; set; }

        [ForeignKey("Customer")]
        public int customerID { get; set; }
        public virtual eCustomer Customer { get; set; }
    }
}
