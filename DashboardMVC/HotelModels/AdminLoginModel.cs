using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModels
{
    public class AdminLoginModel
    {
        [Required(ErrorMessage = "UserName Required")]
        [MaxLength(100, ErrorMessage = "Should Be At Most 10 Characters")]
        [MinLength(5, ErrorMessage = "Should Be At Less 6 Chars")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [MaxLength(20, ErrorMessage = "Should Be At Most 10 Characters")]
        [MinLength(5, ErrorMessage = "Should Be At Less 6 Chars")]
        public string Password { get; set; }
    }
}
