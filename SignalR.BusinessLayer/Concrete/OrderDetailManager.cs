using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccesLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailService;

        public OrderDetailManager(IOrderDetailDal orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        public void TAdd(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public OrderDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
