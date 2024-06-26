﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BlacklistClientValRequest", Namespace="http://beans.ddmws.services.emerio.com/xsd")]
    public partial class BlacklistClientValRequest : object
    {
        
        private string nameField;
        
        private string passportField;
        
        private string businessTagField;
        
        private string nricField;
        
        private string trxIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string passport
        {
            get
            {
                return this.passportField;
            }
            set
            {
                this.passportField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string businessTag
        {
            get
            {
                return this.businessTagField;
            }
            set
            {
                this.businessTagField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string nric
        {
            get
            {
                return this.nricField;
            }
            set
            {
                this.nricField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string trxId
        {
            get
            {
                return this.trxIdField;
            }
            set
            {
                this.trxIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ddmws.services.emerio.com", ConfigurationName="ServiceReference1.IBlacklistService")]
    public interface IBlacklistService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ddmws.services.emerio.com/IBlacklistService/BlacklistClientValidate", ReplyAction="http://ddmws.services.emerio.com/IBlacklistService/BlacklistClientValidateRespons" +
            "e")]
        System.Threading.Tasks.Task<ServiceReference1.BlacklistClientValRequest> BlacklistClientValidateAsync(ServiceReference1.BlacklistClientValRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IBlacklistServiceChannel : ServiceReference1.IBlacklistService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class BlacklistServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IBlacklistService>, ServiceReference1.IBlacklistService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public BlacklistServiceClient() : 
                base(BlacklistServiceClient.GetDefaultBinding(), BlacklistServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IBlacklistService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlacklistServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(BlacklistServiceClient.GetBindingForEndpoint(endpointConfiguration), BlacklistServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlacklistServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(BlacklistServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlacklistServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(BlacklistServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public BlacklistServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.BlacklistClientValRequest> BlacklistClientValidateAsync(ServiceReference1.BlacklistClientValRequest request)
        {
            return base.Channel.BlacklistClientValidateAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBlacklistService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IBlacklistService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:5134/BlacklistService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return BlacklistServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IBlacklistService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return BlacklistServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IBlacklistService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IBlacklistService,
        }
    }
}
