﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.NovinPayamakServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Auth", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    [System.SerializableAttribute()]
    public partial class Auth : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string numberField;
        
        private string passField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string number {
            get {
                return this.numberField;
            }
            set {
                if ((object.ReferenceEquals(this.numberField, value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                if ((object.ReferenceEquals(this.passField, value) != true)) {
                    this.passField = value;
                    this.RaisePropertyChanged("pass");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", ConfigurationName="NovinPayamakServiceReference.SMSBoxImplementationServicePortType")]
    public interface SMSBoxImplementationServicePortType {
        
        // CODEGEN: Generating message contract since element name Auth from namespace http://SMSBox.gateway.webservice.sspk.co.ir/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#Send", ReplyAction="*")]
        WebApplication1.NovinPayamakServiceReference.SendResponse Send(WebApplication1.NovinPayamakServiceReference.SendRequest request);
        
        // CODEGEN: Generating message contract since element name Auth from namespace http://SMSBox.gateway.webservice.sspk.co.ir/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#CheckCredit", ReplyAction="*")]
        WebApplication1.NovinPayamakServiceReference.CheckCreditResponse CheckCredit(WebApplication1.NovinPayamakServiceReference.CheckCreditRequest request);
        
        // CODEGEN: Generating message contract since element name Auth from namespace http://SMSBox.gateway.webservice.sspk.co.ir/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#MessageStatus", ReplyAction="*")]
        WebApplication1.NovinPayamakServiceReference.MessageStatusResponse MessageStatus(WebApplication1.NovinPayamakServiceReference.MessageStatusRequest request);
        
        // CODEGEN: Generating message contract since element name Auth from namespace http://SMSBox.gateway.webservice.sspk.co.ir/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="#Inbox", ReplyAction="*")]
        WebApplication1.NovinPayamakServiceReference.InboxResponse Inbox(WebApplication1.NovinPayamakServiceReference.InboxRequest request);
        
        // CODEGEN: Generating message contract since the operation GetDateTime is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="#GetDateTime", ReplyAction="*")]
        WebApplication1.NovinPayamakServiceReference.GetDateTimeResponse GetDateTime(WebApplication1.NovinPayamakServiceReference.GetDateTimeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Send", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.SendRequestBody Body;
        
        public SendRequest() {
        }
        
        public SendRequest(WebApplication1.NovinPayamakServiceReference.SendRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class SendRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.NovinPayamakServiceReference.Auth Auth;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WebApplication1.NovinPayamakServiceReference.ArrayOfString Recipients;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public WebApplication1.NovinPayamakServiceReference.ArrayOfString Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool Flash;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime DateTime;
        
        public SendRequestBody() {
        }
        
        public SendRequestBody(WebApplication1.NovinPayamakServiceReference.Auth Auth, WebApplication1.NovinPayamakServiceReference.ArrayOfString Recipients, WebApplication1.NovinPayamakServiceReference.ArrayOfString Message, bool Flash, System.DateTime DateTime) {
            this.Auth = Auth;
            this.Recipients = Recipients;
            this.Message = Message;
            this.Flash = Flash;
            this.DateTime = DateTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendResponse", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.SendResponseBody Body;
        
        public SendResponse() {
        }
        
        public SendResponse(WebApplication1.NovinPayamakServiceReference.SendResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class SendResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int MessageId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int MessageCount;
        
        public SendResponseBody() {
        }
        
        public SendResponseBody(int Status, int MessageId, int MessageCount) {
            this.Status = Status;
            this.MessageId = MessageId;
            this.MessageCount = MessageCount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCreditRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCredit", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.CheckCreditRequestBody Body;
        
        public CheckCreditRequest() {
        }
        
        public CheckCreditRequest(WebApplication1.NovinPayamakServiceReference.CheckCreditRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class CheckCreditRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.NovinPayamakServiceReference.Auth Auth;
        
        public CheckCreditRequestBody() {
        }
        
        public CheckCreditRequestBody(WebApplication1.NovinPayamakServiceReference.Auth Auth) {
            this.Auth = Auth;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCreditResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCreditResponse", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.CheckCreditResponseBody Body;
        
        public CheckCreditResponse() {
        }
        
        public CheckCreditResponse(WebApplication1.NovinPayamakServiceReference.CheckCreditResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class CheckCreditResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public decimal Credit;
        
        public CheckCreditResponseBody() {
        }
        
        public CheckCreditResponseBody(int Status, decimal Credit) {
            this.Status = Status;
            this.Credit = Credit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageStatus", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.MessageStatusRequestBody Body;
        
        public MessageStatusRequest() {
        }
        
        public MessageStatusRequest(WebApplication1.NovinPayamakServiceReference.MessageStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class MessageStatusRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.NovinPayamakServiceReference.Auth Auth;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int MessageId;
        
        public MessageStatusRequestBody() {
        }
        
        public MessageStatusRequestBody(WebApplication1.NovinPayamakServiceReference.Auth Auth, int MessageId) {
            this.Auth = Auth;
            this.MessageId = MessageId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageStatusResponse", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.MessageStatusResponseBody Body;
        
        public MessageStatusResponse() {
        }
        
        public MessageStatusResponse(WebApplication1.NovinPayamakServiceReference.MessageStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class MessageStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Info;
        
        public MessageStatusResponseBody() {
        }
        
        public MessageStatusResponseBody(int Status, string Info) {
            this.Status = Status;
            this.Info = Info;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InboxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Inbox", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.InboxRequestBody Body;
        
        public InboxRequest() {
        }
        
        public InboxRequest(WebApplication1.NovinPayamakServiceReference.InboxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class InboxRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebApplication1.NovinPayamakServiceReference.Auth Auth;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public WebApplication1.NovinPayamakServiceReference.ArrayOfString Conditions;
        
        public InboxRequestBody() {
        }
        
        public InboxRequestBody(WebApplication1.NovinPayamakServiceReference.Auth Auth, WebApplication1.NovinPayamakServiceReference.ArrayOfString Conditions) {
            this.Auth = Auth;
            this.Conditions = Conditions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InboxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InboxResponse", Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public WebApplication1.NovinPayamakServiceReference.InboxResponseBody Body;
        
        public InboxResponse() {
        }
        
        public InboxResponse(WebApplication1.NovinPayamakServiceReference.InboxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/")]
    public partial class InboxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Status;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string List;
        
        public InboxResponseBody() {
        }
        
        public InboxResponseBody(int Status, string List) {
            this.Status = Status;
            this.List = List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateTimeRequest {
        
        public GetDateTimeRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDateTimeResponse", WrapperNamespace="http://SMSBox.gateway.webservice.sspk.co.ir/", IsWrapped=true)]
    public partial class GetDateTimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=0)]
        public int Status;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://SMSBox.gateway.webservice.sspk.co.ir/", Order=1)]
        public System.DateTime CurrentDateTime;
        
        public GetDateTimeResponse() {
        }
        
        public GetDateTimeResponse(int Status, System.DateTime CurrentDateTime) {
            this.Status = Status;
            this.CurrentDateTime = CurrentDateTime;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SMSBoxImplementationServicePortTypeChannel : WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMSBoxImplementationServicePortTypeClient : System.ServiceModel.ClientBase<WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType>, WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType {
        
        public SMSBoxImplementationServicePortTypeClient() {
        }
        
        public SMSBoxImplementationServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMSBoxImplementationServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSBoxImplementationServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMSBoxImplementationServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.NovinPayamakServiceReference.SendResponse WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType.Send(WebApplication1.NovinPayamakServiceReference.SendRequest request) {
            return base.Channel.Send(request);
        }
        
        public int Send(WebApplication1.NovinPayamakServiceReference.Auth Auth, WebApplication1.NovinPayamakServiceReference.ArrayOfString Recipients, WebApplication1.NovinPayamakServiceReference.ArrayOfString Message, bool Flash, System.DateTime DateTime, out int MessageId, out int MessageCount) {
            WebApplication1.NovinPayamakServiceReference.SendRequest inValue = new WebApplication1.NovinPayamakServiceReference.SendRequest();
            inValue.Body = new WebApplication1.NovinPayamakServiceReference.SendRequestBody();
            inValue.Body.Auth = Auth;
            inValue.Body.Recipients = Recipients;
            inValue.Body.Message = Message;
            inValue.Body.Flash = Flash;
            inValue.Body.DateTime = DateTime;
            WebApplication1.NovinPayamakServiceReference.SendResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).Send(inValue);
            MessageId = retVal.Body.MessageId;
            MessageCount = retVal.Body.MessageCount;
            return retVal.Body.Status;
        }

        public int Send(WebApplication1.NovinPayamakServiceReference.Auth Auth, WebApplication1.NovinPayamakServiceReference.ArrayOfString Recipients, WebApplication1.NovinPayamakServiceReference.ArrayOfString Message, bool Flash, out int MessageId, out int MessageCount)
        {
            WebApplication1.NovinPayamakServiceReference.SendRequest inValue = new WebApplication1.NovinPayamakServiceReference.SendRequest();
            inValue.Body = new WebApplication1.NovinPayamakServiceReference.SendRequestBody();
            inValue.Body.Auth = Auth;
            inValue.Body.Recipients = Recipients;
            inValue.Body.Message = Message;
            inValue.Body.Flash = Flash;
            WebApplication1.NovinPayamakServiceReference.SendResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).Send(inValue);
            MessageId = retVal.Body.MessageId;
            MessageCount = retVal.Body.MessageCount;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.NovinPayamakServiceReference.CheckCreditResponse WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType.CheckCredit(WebApplication1.NovinPayamakServiceReference.CheckCreditRequest request) {
            return base.Channel.CheckCredit(request);
        }
        
        public int CheckCredit(WebApplication1.NovinPayamakServiceReference.Auth Auth, out decimal Credit) {
            WebApplication1.NovinPayamakServiceReference.CheckCreditRequest inValue = new WebApplication1.NovinPayamakServiceReference.CheckCreditRequest();
            inValue.Body = new WebApplication1.NovinPayamakServiceReference.CheckCreditRequestBody();
            inValue.Body.Auth = Auth;
            WebApplication1.NovinPayamakServiceReference.CheckCreditResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).CheckCredit(inValue);
            Credit = retVal.Body.Credit;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.NovinPayamakServiceReference.MessageStatusResponse WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType.MessageStatus(WebApplication1.NovinPayamakServiceReference.MessageStatusRequest request) {
            return base.Channel.MessageStatus(request);
        }
        
        public int MessageStatus(WebApplication1.NovinPayamakServiceReference.Auth Auth, int MessageId, out string Info) {
            WebApplication1.NovinPayamakServiceReference.MessageStatusRequest inValue = new WebApplication1.NovinPayamakServiceReference.MessageStatusRequest();
            inValue.Body = new WebApplication1.NovinPayamakServiceReference.MessageStatusRequestBody();
            inValue.Body.Auth = Auth;
            inValue.Body.MessageId = MessageId;
            WebApplication1.NovinPayamakServiceReference.MessageStatusResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).MessageStatus(inValue);
            Info = retVal.Body.Info;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.NovinPayamakServiceReference.InboxResponse WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType.Inbox(WebApplication1.NovinPayamakServiceReference.InboxRequest request) {
            return base.Channel.Inbox(request);
        }
        
        public int Inbox(WebApplication1.NovinPayamakServiceReference.Auth Auth, WebApplication1.NovinPayamakServiceReference.ArrayOfString Conditions, out string List) {
            WebApplication1.NovinPayamakServiceReference.InboxRequest inValue = new WebApplication1.NovinPayamakServiceReference.InboxRequest();
            inValue.Body = new WebApplication1.NovinPayamakServiceReference.InboxRequestBody();
            inValue.Body.Auth = Auth;
            inValue.Body.Conditions = Conditions;
            WebApplication1.NovinPayamakServiceReference.InboxResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).Inbox(inValue);
            List = retVal.Body.List;
            return retVal.Body.Status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.NovinPayamakServiceReference.GetDateTimeResponse WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType.GetDateTime(WebApplication1.NovinPayamakServiceReference.GetDateTimeRequest request) {
            return base.Channel.GetDateTime(request);
        }
        
        public int GetDateTime(out System.DateTime CurrentDateTime) {
            WebApplication1.NovinPayamakServiceReference.GetDateTimeRequest inValue = new WebApplication1.NovinPayamakServiceReference.GetDateTimeRequest();
            WebApplication1.NovinPayamakServiceReference.GetDateTimeResponse retVal = ((WebApplication1.NovinPayamakServiceReference.SMSBoxImplementationServicePortType)(this)).GetDateTime(inValue);
            CurrentDateTime = retVal.CurrentDateTime;
            return retVal.Status;
        }
    }
}