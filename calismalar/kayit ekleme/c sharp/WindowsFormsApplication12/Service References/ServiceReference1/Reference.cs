﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication12.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://cehars/", ConfigurationName="ServiceReference1.Yeni_Web_Servis")]
    public interface Yeni_Web_Servis {
        
        // CODEGEN: Generating message contract since element name name from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cehars/Yeni_Web_Servis/helloRequest", ReplyAction="http://cehars/Yeni_Web_Servis/helloResponse")]
        WindowsFormsApplication12.ServiceReference1.helloResponse hello(WindowsFormsApplication12.ServiceReference1.helloRequest request);
        
        // CODEGEN: Generating message contract since element name parameter from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cehars/Yeni_Web_Servis/denemeRequest", ReplyAction="http://cehars/Yeni_Web_Servis/denemeResponse")]
        WindowsFormsApplication12.ServiceReference1.denemeResponse deneme(WindowsFormsApplication12.ServiceReference1.denemeRequest request);
        
        // CODEGEN: Generating message contract since element name otel_ismi from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://cehars/Yeni_Web_Servis/ekleRequest", ReplyAction="http://cehars/Yeni_Web_Servis/ekleResponse")]
        WindowsFormsApplication12.ServiceReference1.ekleResponse ekle(WindowsFormsApplication12.ServiceReference1.ekleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(WindowsFormsApplication12.ServiceReference1.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(WindowsFormsApplication12.ServiceReference1.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class denemeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="deneme", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.denemeRequestBody Body;
        
        public denemeRequest() {
        }
        
        public denemeRequest(WindowsFormsApplication12.ServiceReference1.denemeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class denemeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string parameter;
        
        public denemeRequestBody() {
        }
        
        public denemeRequestBody(string parameter) {
            this.parameter = parameter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class denemeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="denemeResponse", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.denemeResponseBody Body;
        
        public denemeResponse() {
        }
        
        public denemeResponse(WindowsFormsApplication12.ServiceReference1.denemeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class denemeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public denemeResponseBody() {
        }
        
        public denemeResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ekleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ekle", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.ekleRequestBody Body;
        
        public ekleRequest() {
        }
        
        public ekleRequest(WindowsFormsApplication12.ServiceReference1.ekleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ekleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string otel_ismi;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fiyat;
        
        public ekleRequestBody() {
        }
        
        public ekleRequestBody(string otel_ismi, string fiyat) {
            this.otel_ismi = otel_ismi;
            this.fiyat = fiyat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ekleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ekleResponse", Namespace="http://cehars/", Order=0)]
        public WindowsFormsApplication12.ServiceReference1.ekleResponseBody Body;
        
        public ekleResponse() {
        }
        
        public ekleResponse(WindowsFormsApplication12.ServiceReference1.ekleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class ekleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public ekleResponseBody() {
        }
        
        public ekleResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Yeni_Web_ServisChannel : WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Yeni_Web_ServisClient : System.ServiceModel.ClientBase<WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis>, WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis {
        
        public Yeni_Web_ServisClient() {
        }
        
        public Yeni_Web_ServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Yeni_Web_ServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Yeni_Web_ServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Yeni_Web_ServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication12.ServiceReference1.helloResponse WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis.hello(WindowsFormsApplication12.ServiceReference1.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            WindowsFormsApplication12.ServiceReference1.helloRequest inValue = new WindowsFormsApplication12.ServiceReference1.helloRequest();
            inValue.Body = new WindowsFormsApplication12.ServiceReference1.helloRequestBody();
            inValue.Body.name = name;
            WindowsFormsApplication12.ServiceReference1.helloResponse retVal = ((WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication12.ServiceReference1.denemeResponse WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis.deneme(WindowsFormsApplication12.ServiceReference1.denemeRequest request) {
            return base.Channel.deneme(request);
        }
        
        public string deneme(string parameter) {
            WindowsFormsApplication12.ServiceReference1.denemeRequest inValue = new WindowsFormsApplication12.ServiceReference1.denemeRequest();
            inValue.Body = new WindowsFormsApplication12.ServiceReference1.denemeRequestBody();
            inValue.Body.parameter = parameter;
            WindowsFormsApplication12.ServiceReference1.denemeResponse retVal = ((WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis)(this)).deneme(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication12.ServiceReference1.ekleResponse WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis.ekle(WindowsFormsApplication12.ServiceReference1.ekleRequest request) {
            return base.Channel.ekle(request);
        }
        
        public string ekle(string otel_ismi, string fiyat) {
            WindowsFormsApplication12.ServiceReference1.ekleRequest inValue = new WindowsFormsApplication12.ServiceReference1.ekleRequest();
            inValue.Body = new WindowsFormsApplication12.ServiceReference1.ekleRequestBody();
            inValue.Body.otel_ismi = otel_ismi;
            inValue.Body.fiyat = fiyat;
            WindowsFormsApplication12.ServiceReference1.ekleResponse retVal = ((WindowsFormsApplication12.ServiceReference1.Yeni_Web_Servis)(this)).ekle(inValue);
            return retVal.Body.@return;
        }
    }
}