using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManage.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Type { get; set; }
        [ForeignKey("Type")]
        public virtual TypeRoom TypeRoom { get; set; }
        public string Image { get; set; }
        public string No { get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
        public long Price { get; set; }
        public int Number { get; set; }
        public int? Status { get; set; }
    }
}
