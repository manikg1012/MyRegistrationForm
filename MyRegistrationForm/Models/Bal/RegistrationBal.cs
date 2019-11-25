using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MyRegistrationForm.Models.Bal
{
    public class RegistrationBal
    {
        [Key]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}