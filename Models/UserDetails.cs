using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models
{
    public class UserDetails
    {
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        [Required(ErrorMessage = "Please enter MailId"), MaxLength(30)]
        public string MailId { get; set; }
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        [Required(ErrorMessage = "Please enter Password"), MaxLength(30)]
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public int UserId { get; set; }
    }
}
