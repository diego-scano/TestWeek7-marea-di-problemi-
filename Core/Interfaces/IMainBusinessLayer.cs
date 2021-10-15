using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        #region Customer

        IEnumerable<Customer> FetchCustomers();
        Customer FetchCustomerById(int id);
        bool CreateCustomer(Customer newCustomer);
        bool EditCustomer(Customer editedCustomer);
        bool DeleteCustomerById(int id);

        #endregion

        #region Order

        IEnumerable<Order> FetchOrders();
        Order FetchOrderById(int id);
        bool CreateOrder(Order newOrder);
        bool EditOrder(Order editedOrder);
        bool DeleteOrderById(int id);

        #endregion
    }
}
