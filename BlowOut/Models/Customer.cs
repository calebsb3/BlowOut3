using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Required(ErrorMessage ="The First Name is required")]
        [Display(Name = "First Name")]
        public string sCustFirstName { get; set; }

        [Required(ErrorMessage ="The Last Name is required")]
        [Display(Name ="Last Name")]
        public string sCustLastName  { get; set; }

        [Display(Name = "Street Address")]
        public string sCustAddress { get; set; }

        [Display(Name = "State")]
        public string sCustState { get; set; }

        [Display(Name = "City")]
        public string sCustCity { get; set; }

        [Display(Name = "Zip Code")]
        [Range(10000,99999)]
        public int iCustZip { get; set; }

        [Display(Name = "Primary Phone")]
        [Phone(ErrorMessage ="Please enter a valid phone number")]
        public string cCustPhone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Please enter a valid email address")]
        public string cCustEmail { get; set; }

        [Key]
        [Required]
        public int iCustomerID { get; set; }
    }
}