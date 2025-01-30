﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SignalR.DataAccesLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DataAccesLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccesLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(SignalRContext context) : base(context)
        {

        }

        public int ActiveOrderCount()
        {
            using var context = new SignalRContext();
            return context.Orders.Where(x => x.Description == "Musteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new SignalRContext();
            return context.Orders.OrderByDescending(x=> x.OrderID).Take(1).Select(y=>y.TotalPrice).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            using var context = new SignalRContext();
            return context.Orders.Count();
        }
    }
}
