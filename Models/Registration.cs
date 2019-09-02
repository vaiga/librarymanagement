using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models
{
    public class Registration
    {

        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter First Name")]
        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Mail Id")]
        public string MailId { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Compare("Password", ErrorMessage = "Confirm Password required")]
        [Required(ErrorMessage = "Confirm Password should match password")]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
    }
}
