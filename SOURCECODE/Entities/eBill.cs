using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Bill")]
    public class eBill
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int billID { get; set; }

        public DateTime dateCreate { get; set; }

        [ForeignKey("Customer")]
        public int customerID { get; set; }
        public virtual eCustomer Customer { get; set; }

        [ForeignKey("Tour")]
        public int tourID { get; set; }
        public virtual eTour Tour { get; set; }
    }
}
