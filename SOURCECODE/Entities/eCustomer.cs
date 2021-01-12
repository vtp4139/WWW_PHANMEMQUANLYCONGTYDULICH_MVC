using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Customer")]
    public class eCustomer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int customerID { get; set; }
       
        public string customerName { get; set; }
        public string IDCard { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        //Nối đến hợp đồng
        public virtual ICollection<eBill> Bills { get; set; }

        //Nối đến phản hồi
        public virtual ICollection<eFeedback> Feedbacks { get; set; }
    }
}
