﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.WebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://kvv.by/", ConfigurationName="WebService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен http://kvv.by/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/HelloWorld", ReplyAction="*")]
        WindowsFormsApp1.WebService.HelloWorldResponse HelloWorld(WindowsFormsApp1.WebService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://kvv.by/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.WebService.HelloWorldResponse> HelloWorldAsync(WindowsFormsApp1.WebService.HelloWorldRequest request);
        
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
        public WindowsFormsApp1.WebService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApp1.WebService.HelloWorldRequestBody Body) {
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
        public WindowsFormsApp1.WebService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApp1.WebService.HelloWorldResponseBody Body) {
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
    public interface WebService1SoapChannel : WindowsFormsApp1.WebService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.WebService.WebService1Soap>, WindowsFormsApp1.WebService.WebService1Soap {
        
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
        WindowsFormsApp1.WebService.HelloWorldResponse WindowsFormsApp1.WebService.WebService1Soap.HelloWorld(WindowsFormsApp1.WebService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApp1.WebService.HelloWorldRequest inValue = new WindowsFormsApp1.WebService.HelloWorldRequest();
            inValue.Body = new WindowsFormsApp1.WebService.HelloWorldRequestBody();
            WindowsFormsApp1.WebService.HelloWorldResponse retVal = ((WindowsFormsApp1.WebService.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.WebService.HelloWorldResponse> WindowsFormsApp1.WebService.WebService1Soap.HelloWorldAsync(WindowsFormsApp1.WebService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.WebService.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsApp1.WebService.HelloWorldRequest inValue = new WindowsFormsApp1.WebService.HelloWorldRequest();
            inValue.Body = new WindowsFormsApp1.WebService.HelloWorldRequestBody();
            return ((WindowsFormsApp1.WebService.WebService1Soap)(this)).HelloWorldAsync(inValue);
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