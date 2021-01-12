using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Tour")]
    public class eTour
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int tourID { get; set; }

        public string tourName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime departureDate { get; set; }
        public int numberOfDay { get; set; }
        public string startAddress { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public double price { get; set; }
        public int numSeat { get; set; }
        public int emptySeat { get; set; }
        public bool tourType { get; set; }
        public string Describe { get; set; }
        public string Picture { get; set; }

        //Nối đến hợp đồng
        public virtual ICollection<eBill> Bills { get; set; }
    }
}
