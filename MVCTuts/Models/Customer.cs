using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTuts.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Customer Name : ")]
        [Required(ErrorMessage ="*")]
        public string Name { get; set; }
        [Display(Name = "Customer Gender : ")]
        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }
        [Display(Name = "Customer Email : ")]
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }
    }
}