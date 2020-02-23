using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace phonebook.Models
{
    public class pb
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string fname { get; set; }
        [Required]
        public string lname { get; set; }
        [Required]
        public string pnumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}