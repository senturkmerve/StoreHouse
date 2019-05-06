using StoreHouseProject.Model.Option;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreHouseProject.UI.Areas.Admin.Models.DTO
{
    public class AppUserDTO
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "please write username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "please write password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "please insert picture")]
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "please choose role")]
        public Role Role { get; set; }
        [Required(ErrorMessage = "please write first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "please write last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "please write last name")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please write last name")]
        public string Address { get; set; }
    }
}