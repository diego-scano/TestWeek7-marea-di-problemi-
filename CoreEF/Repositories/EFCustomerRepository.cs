using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreEF.Repositories;

namespace CoreEF.Repositories
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly ShopContext ctx;

        public EFCustomerRepository() : this(new ShopContext()) { }

        public EFCustomerRepository(ShopContext ctx)
        {
            this.ctx = ctx;
        }

        public IEnumerable<Customer> Fetch()
        {
            return ctx.Customers;
        }

        public Customer GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Customers.Find(id);
        }

        public bool Add(Customer newCustomer)
        {
            if (newCustomer == null)
                return false;

            try
            {
                ctx.Customers.Add(newCustomer);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Customer updatedCustomer)
        {
            if (updatedCustomer == null)
                return false;

            try
            {
                ctx.Customers.Update(updatedCustomer);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Customer item)
        {
            if (item == null)
                return false;

            try
            {
                var customer = ctx.Customers.Find(item.Id);

                if (customer != null)
                    ctx.Customers.Remove(customer);

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
