using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreHouseProject.UI.Areas.Admin.Models.DTO
{
    public class CategoryDTO
    {
        public Guid ID { get; set; }
        [Required(ErrorMessage = "please write Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please write Description")]
        public string Description { get; set; }
    }
}