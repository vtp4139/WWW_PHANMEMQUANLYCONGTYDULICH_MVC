using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Account")]
    public class eAccount
    {
        [Key]
        [Required(ErrorMessage = "Không chừa trống tài khoản")]
        public string id { get; set; }
        [Required(ErrorMessage = "Không chừa trống mật khẩu")]
        public string password { get; set; }

        //Kết nối đến khách hàng
        public int customerID { get; set; }
        public virtual eCustomer Customer { get; set; }
    }
}
