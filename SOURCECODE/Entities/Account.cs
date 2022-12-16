using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourManager.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage = "Không chừa trống tài khoản")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Không chừa trống mật khẩu")]
        public string Password { get; set; }

        //Kết nối đến khách hàng
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
