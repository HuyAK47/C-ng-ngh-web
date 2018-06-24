using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OperaShop.Areas.Admin.Models
{
    public class LoginModels
    {
        [Required(ErrorMessage = "Nhập username")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Nhập password")]

        public string Password { get; set; }

        public string Remmember { get; set; }

    }
}