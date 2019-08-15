using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ShopingMall.Models
{
    public class UserProfile
    {

        [Key]
        [DisplayName("帳號")]
        [Required]
        public String UserID { get; set; }

        [DisplayName("密碼")]
        [Required]
        public String Password { get; set; }

        [DisplayName("電子信箱")]
        [Required]
        [EmailAddress]
        public String UserName { get; set; }



    }
}
