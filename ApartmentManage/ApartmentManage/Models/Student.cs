using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManage.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Student Name")]
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public int NoIdentity { get; set; }
        public int? Sex { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int? Status { get; set; }

    }
}
