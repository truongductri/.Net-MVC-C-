using ApartmentManage.Services.RoomSrv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentManage.Models;

namespace ApartmentManage.Dao.RoomDao
{
    public class TypeRoomDao
    {
        private TypeRoomSrv typeRoomSrv;
        public TypeRoomDao()
        {
            typeRoomSrv = new TypeRoomSrv();
        }
        //SetViewBag() RoomTypeId type room by dropdownList => nameType
        public void SetViewBag(int? selectedId)
        {
             var drop_TypeRoom = SelectList(typeRoomSrv.GetAll(), "Id", "Name", selectedId);
        }

        private object SelectList(List<TypeRoom> list, string v1, string v2, int? selectedId)
        {
            throw new NotImplementedException();
        }
    }
}
