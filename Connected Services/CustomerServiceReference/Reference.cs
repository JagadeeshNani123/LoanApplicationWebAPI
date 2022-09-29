﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerModel", Namespace="http://schemas.datacontract.org/2004/07/LoanApplicationWCFService.Models")]
    public partial class CustomerModel : object
    {
        
        private string AddressProofField;
        
        private string AddressProofNumberField;
        
        private string DateOfBirthField;
        
        private string EmailAddressField;
        
        private string FirstNameField;
        
        private System.Guid IdField;
        
        private decimal IncomeField;
        
        private string LastNameField;
        
        private string OccupationField;
        
        private string PanCardNumberField;
        
        private string PasswordField;
        
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressProof
        {
            get
            {
                return this.AddressProofField;
            }
            set
            {
                this.AddressProofField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AddressProofNumber
        {
            get
            {
                return this.AddressProofNumberField;
            }
            set
            {
                this.AddressProofNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DateOfBirth
        {
            get
            {
                return this.DateOfBirthField;
            }
            set
            {
                this.DateOfBirthField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress
        {
            get
            {
                return this.EmailAddressField;
            }
            set
            {
                this.EmailAddressField = value;
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
        public System.Guid Id
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
        public decimal Income
        {
            get
            {
                return this.IncomeField;
            }
            set
            {
                this.IncomeField = value;
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Occupation
        {
            get
            {
                return this.OccupationField;
            }
            set
            {
                this.OccupationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PanCardNumber
        {
            get
            {
                return this.PanCardNumberField;
            }
            set
            {
                this.PanCardNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceReference.ICustomerService")]
    public interface ICustomerService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(CustomerServiceReference.CustomerModel customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(CustomerServiceReference.CustomerModel customer, System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetAllCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetAllCustomersResponse")]
        System.Threading.Tasks.Task<CustomerServiceReference.CustomerModel[]> GetAllCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerById", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerByIdResponse")]
        System.Threading.Tasks.Task<CustomerServiceReference.CustomerModel> GetCustomerByIdAsync(System.Guid Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface ICustomerServiceChannel : CustomerServiceReference.ICustomerService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<CustomerServiceReference.ICustomerService>, CustomerServiceReference.ICustomerService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CustomerServiceClient() : 
                base(CustomerServiceClient.GetDefaultBinding(), CustomerServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICustomerService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CustomerServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CustomerServiceClient.GetBindingForEndpoint(endpointConfiguration), CustomerServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CustomerServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CustomerServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CustomerServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CustomerServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(CustomerServiceReference.CustomerModel customer)
        {
            return base.Channel.AddCustomerAsync(customer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(CustomerServiceReference.CustomerModel customer, System.Guid id)
        {
            return base.Channel.UpdateCustomerAsync(customer, id);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(System.Guid id)
        {
            return base.Channel.DeleteCustomerAsync(id);
        }
        
        public System.Threading.Tasks.Task<CustomerServiceReference.CustomerModel[]> GetAllCustomersAsync()
        {
            return base.Channel.GetAllCustomersAsync();
        }
        
        public System.Threading.Tasks.Task<CustomerServiceReference.CustomerModel> GetCustomerByIdAsync(System.Guid Id)
        {
            return base.Channel.GetCustomerByIdAsync(Id);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICustomerService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICustomerService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:54073/WCFServices/Customer/CustomerService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CustomerServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICustomerService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CustomerServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICustomerService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICustomerService,
        }
    }
}
