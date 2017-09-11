using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApartmentManage.Models
{
    public class ContractViewModels
    {
       [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string ImageStudent { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public int NoIdentity { get; set; }
        public int? Sex { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        

        public string ContractNo { get; set; }
        public string RoomName{ get; set; }
        public int? TypeRooms { get; set; }
        public int Floor { get; set; }
        public long Price { get; set; }
        public int NumberOfPerson { get; set; }
   
        
        public int NumOfMonth { get; set; }
        public long MoneyAmount { get; set; }
        public int? Status { get; set; }

    }
}