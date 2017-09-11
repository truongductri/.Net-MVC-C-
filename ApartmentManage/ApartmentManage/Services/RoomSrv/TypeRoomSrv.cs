using ApartmentManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApartmentManage.Services.RoomSrv
{
    public class TypeRoomSrv
    {
        private ApartmentDbContext db;
        public TypeRoomSrv()
        {
            db = new ApartmentDbContext();
        }
        public List<TypeRoom> GetAll()
        {
            return db.TypeRooms.ToList();
        }
    }
}