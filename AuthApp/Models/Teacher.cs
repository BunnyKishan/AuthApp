using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthApp.Models
{
    public class Teacher
    {
        [Key]
        public long ID { get; set; }

        [Required(ErrorMessage = "This feild is required.")]
        public string Name { get; set; }

        public string PhoneNo { get; set; }
    }
}