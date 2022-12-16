using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourManager.Models
{
    [Table("Tour")]
    public class Tour
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string tourName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DepartureDate { get; set; }
        public int MumberOfDay { get; set; }
        public string StartAddress { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public double Price { get; set; }
        public int NumSeat { get; set; }
        public int EmptySeat { get; set; }
        public bool TourType { get; set; }
        public string Describe { get; set; }
        public string Picture { get; set; }

        //Nối đến hợp đồng
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
