using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.BusinessLayer
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly ICustomerRepository CustomerRepo;
        private readonly IOrderRepository OrderRepo;

        public MainBusinessLayer()  // WCF
        {
            this.CustomerRepo = DependencyContainer.Resolve<ICustomerRepository>();
        }

        public MainBusinessLayer(IOrderRepository orderR)   // ASP.NET CORE
        {
            this.OrderRepo = orderR;
        }

        #region Customer

        public IEnumerable<Customer> FetchCustomers()
        {
            return CustomerRepo.Fetch();
        }

        public Customer FetchCustomerById(int id)
        {
            if (id <= 0)
                return null;

            return CustomerRepo.GetById(id);
        }

        public bool CreateCustomer(Customer newCustomer)
        {
            if (newCustomer == null)
                return false;

            return CustomerRepo.Add(newCustomer);
        }

        public bool EditCustomer(Customer editedCustomer)
        {
            if (editedCustomer == null)
                return false;

            return CustomerRepo.Update(editedCustomer);
        }

        public bool DeleteCustomerById(int id)
        {
            if (id <= 0)
                return false;

            Customer customerToBeDeleted = this.CustomerRepo.GetById(id);

            if (customerToBeDeleted != null)
                return CustomerRepo.Delete(customerToBeDeleted);

            return false;
        }

        #endregion

        #region Order

        public IEnumerable<Order> FetchOrders()
        {
            return OrderRepo.Fetch();
        }

        public Order FetchOrderById(int id)
        {
            if (id <= 0)
                return null;

            return OrderRepo.GetById(id);
        }

        public bool CreateOrder(Order newOrder)
        {
            if (newOrder == null)
                return false;

            return OrderRepo.Add(newOrder);
        }

        public bool EditOrder(Order editedOrder)
        {
            if (editedOrder == null)
                return false;

            return OrderRepo.Update(editedOrder);
        }

        public bool DeleteOrderById(int id)
        {
            if (id <= 0)
                return false;

            Order orderToBeDeleted = this.OrderRepo.GetById(id);

            if (orderToBeDeleted != null)
                return OrderRepo.Delete(orderToBeDeleted);

            return false;
        }

        #endregion
    }
}
