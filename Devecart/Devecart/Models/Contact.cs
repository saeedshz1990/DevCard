using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devecart.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری می باشد")]
        [MinLength(3,ErrorMessage = "حداقل طول این فیلد 3 کاراکتر می باشد")]
        [MaxLength(100,ErrorMessage = "حداکثر طول این فیلد 100 کاراکتر می باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده اشتباه می باشد")]
        public string Email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        [MinLength(10, ErrorMessage = "حداقل طول این فیلد 10 کاراکتر می باشد")]
        [MaxLength(250, ErrorMessage = "حداکثر طول این فیلد 250 کاراکتر می باشد")]
        public string Message { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری می باشد")]
        public string Service { get; set; }


    }
}
