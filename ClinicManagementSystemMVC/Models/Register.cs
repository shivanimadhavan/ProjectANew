using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagementSystemMVC.Models
{
    public class Register
    {
        [Key]
        [Required(ErrorMessage = "Enter Username")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "special characters are not allowed.")]
        public string Username { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Oops ! Invalid Email.")]
        [Display(Name = "Email-ID")]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
