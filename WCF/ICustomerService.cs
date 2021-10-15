using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Models;

namespace WCF
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        IEnumerable<Customer> FetchCustomers();

        [OperationContract]
        bool CreateCustomer(Customer newCustomer);

        [OperationContract]
        bool EditCustomer(Customer editedCustomer);

        [OperationContract]
        bool DeleteCustomerById(int id);
    }

}
