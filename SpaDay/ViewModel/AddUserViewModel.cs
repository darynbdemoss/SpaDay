using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "UserName is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "The User Name is between 5 and 15 characters long")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The password is between 6 and 20 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verify Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The verify password is between 6 and 20 characters long")]
        public string Verify { get; set; }

        [EmailAddress]
        public string Email { get; set; }


    }
}
