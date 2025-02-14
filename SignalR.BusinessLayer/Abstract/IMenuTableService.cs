using SignalR.EntityLayer.Entities;
using System;


namespace SignalR.BusinessLayer.Abstract
{
    public interface IMenuTableService : IGenericService<MenuTable>
    {
        int TMenuTableCount();
        void TChangeMenuTableStatusToTrue(int id);
        void TChangeMenuTableStatusToFalse(int id);
    }
}
