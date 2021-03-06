﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VersionOneTFSServer.Tests.ServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03", ConfigurationName="ServiceProxy.IService")]
    public interface IService {
        
        // CODEGEN: Generating message contract since element name eventXml from namespace http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Noti" +
            "fy", ReplyAction="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/ISer" +
            "vice/NotifyResponse")]
        VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse Notify(VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Noti" +
            "fy", ReplyAction="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/ISer" +
            "vice/NotifyResponse")]
        System.Threading.Tasks.Task<VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse> NotifyAsync(VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Notify", Namespace="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03", Order=0)]
        public VersionOneTFSServer.Tests.ServiceProxy.NotifyRequestBody Body;
        
        public NotifyRequest() {
        }
        
        public NotifyRequest(VersionOneTFSServer.Tests.ServiceProxy.NotifyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03")]
    public partial class NotifyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string eventXml;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tfsIdentityXml;
        
        public NotifyRequestBody() {
        }
        
        public NotifyRequestBody(string eventXml, string tfsIdentityXml) {
            this.eventXml = eventXml;
            this.tfsIdentityXml = tfsIdentityXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NotifyResponse", Namespace="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03", Order=0)]
        public VersionOneTFSServer.Tests.ServiceProxy.NotifyResponseBody Body;
        
        public NotifyResponse() {
        }
        
        public NotifyResponse(VersionOneTFSServer.Tests.ServiceProxy.NotifyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NotifyResponseBody {
        
        public NotifyResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : VersionOneTFSServer.Tests.ServiceProxy.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<VersionOneTFSServer.Tests.ServiceProxy.IService>, VersionOneTFSServer.Tests.ServiceProxy.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse VersionOneTFSServer.Tests.ServiceProxy.IService.Notify(VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest request) {
            return base.Channel.Notify(request);
        }
        
        public void Notify(string eventXml, string tfsIdentityXml) {
            VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest inValue = new VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest();
            inValue.Body = new VersionOneTFSServer.Tests.ServiceProxy.NotifyRequestBody();
            inValue.Body.eventXml = eventXml;
            inValue.Body.tfsIdentityXml = tfsIdentityXml;
            VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse retVal = ((VersionOneTFSServer.Tests.ServiceProxy.IService)(this)).Notify(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse> VersionOneTFSServer.Tests.ServiceProxy.IService.NotifyAsync(VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest request) {
            return base.Channel.NotifyAsync(request);
        }
        
        public System.Threading.Tasks.Task<VersionOneTFSServer.Tests.ServiceProxy.NotifyResponse> NotifyAsync(string eventXml, string tfsIdentityXml) {
            VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest inValue = new VersionOneTFSServer.Tests.ServiceProxy.NotifyRequest();
            inValue.Body = new VersionOneTFSServer.Tests.ServiceProxy.NotifyRequestBody();
            inValue.Body.eventXml = eventXml;
            inValue.Body.tfsIdentityXml = tfsIdentityXml;
            return ((VersionOneTFSServer.Tests.ServiceProxy.IService)(this)).NotifyAsync(inValue);
        }
    }
}
