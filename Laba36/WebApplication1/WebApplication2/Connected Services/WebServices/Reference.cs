﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.WebServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://kvv.by/", ConfigurationName="WebServices.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://kvv.by/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/HelloWorld", ReplyAction="*")]
        WebApplication2.WebServices.HelloWorldResponse HelloWorld(WebApplication2.WebServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.WebServices.HelloWorldResponse> HelloWorldAsync(WebApplication2.WebServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Sub", ReplyAction="*")]
        int Sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Mult", ReplyAction="*")]
        int Mult(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/Mult", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/SetX", ReplyAction="*")]
        void SetX(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/SetX", ReplyAction="*")]
        System.Threading.Tasks.Task SetXAsync(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/GetX", ReplyAction="*")]
        int GetX(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/GetX", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetXAsync(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/AddX", ReplyAction="*")]
        int AddX(int x);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/AddX", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddXAsync(int x);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://kvv.by/", Order=0)]
        public WebApplication2.WebServices.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebApplication2.WebServices.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://kvv.by/", Order=0)]
        public WebApplication2.WebServices.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebApplication2.WebServices.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://kvv.by/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebApplication2.WebServices.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebApplication2.WebServices.WebService1Soap>, WebApplication2.WebServices.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.WebServices.HelloWorldResponse WebApplication2.WebServices.WebService1Soap.HelloWorld(WebApplication2.WebServices.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebApplication2.WebServices.HelloWorldRequest inValue = new WebApplication2.WebServices.HelloWorldRequest();
            inValue.Body = new WebApplication2.WebServices.HelloWorldRequestBody();
            WebApplication2.WebServices.HelloWorldResponse retVal = ((WebApplication2.WebServices.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.WebServices.HelloWorldResponse> WebApplication2.WebServices.WebService1Soap.HelloWorldAsync(WebApplication2.WebServices.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.WebServices.HelloWorldResponse> HelloWorldAsync() {
            WebApplication2.WebServices.HelloWorldRequest inValue = new WebApplication2.WebServices.HelloWorldRequest();
            inValue.Body = new WebApplication2.WebServices.HelloWorldRequestBody();
            return ((WebApplication2.WebServices.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
        
        public int Sub(int x, int y) {
            return base.Channel.Sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int x, int y) {
            return base.Channel.SubAsync(x, y);
        }
        
        public int Mult(int x, int y) {
            return base.Channel.Mult(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultAsync(int x, int y) {
            return base.Channel.MultAsync(x, y);
        }
        
        public void SetX(int x) {
            base.Channel.SetX(x);
        }
        
        public System.Threading.Tasks.Task SetXAsync(int x) {
            return base.Channel.SetXAsync(x);
        }
        
        public int GetX(int x) {
            return base.Channel.GetX(x);
        }
        
        public System.Threading.Tasks.Task<int> GetXAsync(int x) {
            return base.Channel.GetXAsync(x);
        }
        
        public int AddX(int x) {
            return base.Channel.AddX(x);
        }
        
        public System.Threading.Tasks.Task<int> AddXAsync(int x) {
            return base.Channel.AddXAsync(x);
        }
    }
}
