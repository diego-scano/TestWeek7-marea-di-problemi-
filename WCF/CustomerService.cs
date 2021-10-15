using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;
using Core.BusinessLayer;
using Core.Interfaces;
using Core.Models;
using CoreEF.Repositories;

namespace WCF
{
    public class CustomerService : ICustomerService
    {
        IMainBusinessLayer mainBL;

        public CustomerService()
        {
            // Dependency injection
            DependencyContainer.Register<IMainBusinessLayer, MainBusinessLayer>();
            DependencyContainer.Register<ICustomerRepository, EFCustomerRepository>();

            this.mainBL = DependencyContainer.Resolve<IMainBusinessLayer>();
        }

        public IEnumerable<Customer> FetchCustomers()
        {
            return this.mainBL.FetchCustomers();
        }

        public bool CreateCustomer(Customer newCustomer)
        {
            if (newCustomer == null)
                return false;

            return this.mainBL.CreateCustomer(newCustomer);
        }

        public bool EditCustomer(Customer editedCustomer)
        {
            if (editedCustomer == null)
                return false;

            return this.mainBL.EditCustomer(editedCustomer);
        }

        public bool DeleteCustomerById(int id)
        {
            if (id > 0)
                return this.mainBL.DeleteCustomerById(id);

            return false;
        }     
    }
}
