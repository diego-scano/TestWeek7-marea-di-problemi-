//------------------------------------------------------------------------------
// <auto-generated>
//     Questo codice è stato generato da uno strumento.
//
//     Le modifiche apportate a questo file possono causare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Core.Models")]
    public partial class Customer : object
    {
        
        private string CustomerCodeField;
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerCode
        {
            get
            {
                return this.CustomerCodeField;
            }
            set
            {
                this.CustomerCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShopService.IShopService")]
    public interface IShopService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/FetchCustomers", ReplyAction="http://tempuri.org/IShopService/FetchCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ShopService.Customer>> FetchCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/CreateCustomer", ReplyAction="http://tempuri.org/IShopService/CreateCustomerResponse")]
        System.Threading.Tasks.Task<bool> CreateCustomerAsync(ShopService.Customer newCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/EditCustomer", ReplyAction="http://tempuri.org/IShopService/EditCustomerResponse")]
        System.Threading.Tasks.Task<bool> EditCustomerAsync(ShopService.Customer editedCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/DeleteCustomerById", ReplyAction="http://tempuri.org/IShopService/DeleteCustomerByIdResponse")]
        System.Threading.Tasks.Task<bool> DeleteCustomerByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IShopServiceChannel : ShopService.IShopService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class ShopServiceClient : System.ServiceModel.ClientBase<ShopService.IShopService>, ShopService.IShopService
    {
        
        /// <summary>
        /// Implementare questo metodo parziale per configurare l'endpoint servizio.
        /// </summary>
        /// <param name="serviceEndpoint">Endpoint da configurare</param>
        /// <param name="clientCredentials">Credenziali del client</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ShopServiceClient() : 
                base(ShopServiceClient.GetDefaultBinding(), ShopServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IShopService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ShopServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ShopServiceClient.GetBindingForEndpoint(endpointConfiguration), ShopServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ShopServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ShopServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ShopServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ShopServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ShopServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ShopService.Customer>> FetchCustomersAsync()
        {
            return base.Channel.FetchCustomersAsync();
        }
        
        public System.Threading.Tasks.Task<bool> CreateCustomerAsync(ShopService.Customer newCustomer)
        {
            return base.Channel.CreateCustomerAsync(newCustomer);
        }
        
        public System.Threading.Tasks.Task<bool> EditCustomerAsync(ShopService.Customer editedCustomer)
        {
            return base.Channel.EditCustomerAsync(editedCustomer);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCustomerByIdAsync(int id)
        {
            return base.Channel.DeleteCustomerByIdAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IShopService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IShopService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCF/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("L\'endpoint denominato \'{0}\' non è stato trovato.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ShopServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IShopService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ShopServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IShopService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IShopService,
        }
    }
}
