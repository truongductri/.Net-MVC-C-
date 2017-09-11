using ApartmentManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ApartmentManage.Services.ContractSrv
{
    public class ContractRegister
    {
        private ApartmentDbContext db;
        public ContractRegister()
        {
            db = new ApartmentDbContext();
        }
       public List<ContractViewModels> ConstractRegister()
        {
            var model = (from c in db.Contracts
                         join s in db.Students on c.StudentId equals s.Id
                         join r in db.Rooms on c.RoomId equals r.Id
                         select new {
                             StudentName = s.Name,
                             Image = s.Image,
                             Age = s.Age,
                             BirthDay = s.BirthDay,
                             NoIdentity = s.NoIdentity,
                             Sex = s.Sex,
                             Phone = s.Phone,
                             Address = s.Address,
                             Email = s.Email,
                             Type = r.Type,
                             ContractNo = c.Name,
                             RoomName = r.Name,
                             TypeRooms = r.Type,
                             NumberOfPerson = r.Capacity,
                             Floor = r.Floor,
                             Price = r.Price,
                             NumOfMonth = c.NumOfMonth,
                             MoneyAmount = c.MoneyAmount,
                             ContractStatus = c.Status }).AsEnumerable().Select(x => new ContractViewModels()
                             {
                                 StudentName = x.StudentName,
                                 ImageStudent = x.Image,
                                 Age = x.Age,
                                 BirthDay = x.BirthDay,
                                 NoIdentity = x.NoIdentity,
                                 Sex = x.Sex,
                                 Phone = x.Phone,
                                 Address = x.Address,
                                 Email = x.Email,
                                 TypeRooms = x.TypeRooms,
                                 NumberOfPerson = x.NumberOfPerson,
                                 Floor = x.Floor,
                                 Price = x.Price,
                                 NumOfMonth = x.NumOfMonth,
                                 MoneyAmount = x.MoneyAmount,
                                 Status = x.ContractStatus
                             });
            return model.ToList();

           
        }
        
       public List<Contract> GetAll()
        {
            return db.Contracts.ToList();
        }

    }
}