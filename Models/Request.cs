using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string status { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Book Name")]
        public string BookName { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }
    }
}
