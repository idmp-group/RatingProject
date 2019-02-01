using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class Owner
    {
        [Key]
        [ForeignKey("Store")]
        public int StoreCode { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام")]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام خانوادگی باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "نام کاربری باید بین 5 تا 50 کاراکتر باشد")]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "رمزعبور باید بین 5 تا 50 کاراکتر باشد")]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }

        //[EmailAddress(ErrorMessage = "ایمیل وارد شده نامعتبر است")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 3, ErrorMessage = "شماره باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "شماره فروشگاه")]
        public string Phonenumber { get; set; }
        


        public virtual Store Store { get; set; }
    }
}