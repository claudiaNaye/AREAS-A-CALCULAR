﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CALCULO_DE_AREAS.ServiceReferenceAreas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAreas.WebServiceAREASoap")]
    public interface WebServiceAREASoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CREADORResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CREADOR", ReplyAction="*")]
        CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse CREADOR(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CREADOR", ReplyAction="*")]
        System.Threading.Tasks.Task<CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse> CREADORAsync(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CUADRADO", ReplyAction="*")]
        int CUADRADO(int LADO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CUADRADO", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CUADRADOAsync(int LADO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TRIANGULO", ReplyAction="*")]
        int TRIANGULO(int BASE, int ALTURA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TRIANGULO", ReplyAction="*")]
        System.Threading.Tasks.Task<int> TRIANGULOAsync(int BASE, int ALTURA);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CIRCULO", ReplyAction="*")]
        double CIRCULO(double RADIO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CIRCULO", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CIRCULOAsync(double RADIO);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CREADORRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CREADOR", Namespace="http://tempuri.org/", Order=0)]
        public CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequestBody Body;
        
        public CREADORRequest() {
        }
        
        public CREADORRequest(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CREADORRequestBody {
        
        public CREADORRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CREADORResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CREADORResponse", Namespace="http://tempuri.org/", Order=0)]
        public CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponseBody Body;
        
        public CREADORResponse() {
        }
        
        public CREADORResponse(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CREADORResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CREADORResult;
        
        public CREADORResponseBody() {
        }
        
        public CREADORResponseBody(string CREADORResult) {
            this.CREADORResult = CREADORResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAREASoapChannel : CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAREASoapClient : System.ServiceModel.ClientBase<CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap>, CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap {
        
        public WebServiceAREASoapClient() {
        }
        
        public WebServiceAREASoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAREASoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAREASoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAREASoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap.CREADOR(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest request) {
            return base.Channel.CREADOR(request);
        }
        
        public string CREADOR() {
            CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest inValue = new CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest();
            inValue.Body = new CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequestBody();
            CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse retVal = ((CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap)(this)).CREADOR(inValue);
            return retVal.Body.CREADORResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse> CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap.CREADORAsync(CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest request) {
            return base.Channel.CREADORAsync(request);
        }
        
        public System.Threading.Tasks.Task<CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORResponse> CREADORAsync() {
            CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest inValue = new CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequest();
            inValue.Body = new CALCULO_DE_AREAS.ServiceReferenceAreas.CREADORRequestBody();
            return ((CALCULO_DE_AREAS.ServiceReferenceAreas.WebServiceAREASoap)(this)).CREADORAsync(inValue);
        }
        
        public int CUADRADO(int LADO) {
            return base.Channel.CUADRADO(LADO);
        }
        
        public System.Threading.Tasks.Task<int> CUADRADOAsync(int LADO) {
            return base.Channel.CUADRADOAsync(LADO);
        }
        
        public int TRIANGULO(int BASE, int ALTURA) {
            return base.Channel.TRIANGULO(BASE, ALTURA);
        }
        
        public System.Threading.Tasks.Task<int> TRIANGULOAsync(int BASE, int ALTURA) {
            return base.Channel.TRIANGULOAsync(BASE, ALTURA);
        }
        
        public double CIRCULO(double RADIO) {
            return base.Channel.CIRCULO(RADIO);
        }
        
        public System.Threading.Tasks.Task<double> CIRCULOAsync(double RADIO) {
            return base.Channel.CIRCULOAsync(RADIO);
        }
    }
}