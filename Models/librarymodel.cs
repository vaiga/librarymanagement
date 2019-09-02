using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Librarymanagement.Models
{
    public class librarymodel
    {

        public int BookId { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Book Name")]
        public string BookName { get; set; }
        
        [Required(ErrorMessage = "Please enter Book Published Year")]
        public int  BookPublishedYear { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Book author")]
        public string BookAuthor { get; set; }
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        [Required(ErrorMessage = "Please enter Book Category")]
        public string BookCategory { get; set; }
        
    }
}
