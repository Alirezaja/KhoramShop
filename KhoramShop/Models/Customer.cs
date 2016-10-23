using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KhoramShop.Models
{
    public enum Gender
    {
        Male,Female
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(20)]
        public string  UserName { get; set; }
        [Required]
        [StringLength(20,MinimumLength =6)]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender? Gender { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
    }
}