using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using web_store.Controllers;
using web_store.Models;
using web_store.ViewModels;

namespace web_store.ViewModels
{
    public class ManagementViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }
}
