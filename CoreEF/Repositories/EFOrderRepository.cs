using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEF.Repositories
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly ShopContext ctx;

        public EFOrderRepository() : this(new ShopContext()) { }

        public EFOrderRepository(ShopContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Order> Fetch()
        {
            return ctx.Orders;
        }

        public Order GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Orders.Find(id);
        }

        public bool Add(Order item)
        {
            if (item == null)
                return false;

            try
            {
                ctx.Orders.Add(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Order item)
        {
            if (item == null)
                return false;

            try
            {
                ctx.Orders.Update(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Order item)
        {
            if (item == null)
                return false;

            try
            {
                var order = ctx.Orders.Find(item.Id);

                if (order != null)
                    ctx.Orders.Remove(order);

                ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }     
    }
}
