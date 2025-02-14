using SignalR.EntityLayer.Entities;
using System;


namespace SignalR.BusinessLayer.Abstract
{
    public interface IMoneyCaseService:IGenericService<MoneyCase>
    {
        decimal TTotalMoneyCaseAmount();
    }
}
