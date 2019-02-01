using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class User
    {
        [Key]
        public int Code { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام باید بین 3 تا 50 کاراکتر باشد")]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "نام کاربری باید بین 5 تا 50 کاراکتر باشد")]
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "رمزعبور باید بین 5 تا 50 کاراکتر باشد")]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل وارد شده نامعتبر است")]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 3, ErrorMessage = "شماره اشتباه است ")]
        [Display(Name = "شماره")]
        public string Phonenumber { get; set; }
        //Admin = true
        [Display(Name = "مدیر سایت")]
        public bool Type { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}