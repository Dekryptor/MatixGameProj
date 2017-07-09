﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatixGameClient.MatixGameServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInformationData", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class UserInformationData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RegistrationResult", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class RegistrationResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MatixGameClient.MatixGameServiceReference.OperationStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MatixGameClient.MatixGameServiceReference.OperationStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OperationStatus", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    public enum OperationStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failure = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidEmail = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidPassword = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OperationtimeOut = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginData", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class LoginData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginResult", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class LoginResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MatixGameClient.MatixGameServiceReference.OperationStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MatixGameClient.MatixGameServiceReference.OperationStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WaitingPlayerResult", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class WaitingPlayerResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MatixGameClient.MatixGameServiceReference.OperationStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MatixGameClient.MatixGameServiceReference.WaitingPlayer[] WaitingPlayerslistField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MatixGameClient.MatixGameServiceReference.OperationStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MatixGameClient.MatixGameServiceReference.WaitingPlayer[] WaitingPlayerslist {
            get {
                return this.WaitingPlayerslistField;
            }
            set {
                if ((object.ReferenceEquals(this.WaitingPlayerslistField, value) != true)) {
                    this.WaitingPlayerslistField = value;
                    this.RaisePropertyChanged("WaitingPlayerslist");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WaitingPlayer", Namespace="http://schemas.datacontract.org/2004/07/WcfMatixServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class WaitingPlayer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NickNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberOfWinningsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalGamesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalScoreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NickName {
            get {
                return this.NickNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NickNameField, value) != true)) {
                    this.NickNameField = value;
                    this.RaisePropertyChanged("NickName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberOfWinnings {
            get {
                return this.NumberOfWinningsField;
            }
            set {
                if ((this.NumberOfWinningsField.Equals(value) != true)) {
                    this.NumberOfWinningsField = value;
                    this.RaisePropertyChanged("NumberOfWinnings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalGames {
            get {
                return this.TotalGamesField;
            }
            set {
                if ((this.TotalGamesField.Equals(value) != true)) {
                    this.TotalGamesField = value;
                    this.RaisePropertyChanged("TotalGames");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalScore {
            get {
                return this.TotalScoreField;
            }
            set {
                if ((this.TotalScoreField.Equals(value) != true)) {
                    this.TotalScoreField = value;
                    this.RaisePropertyChanged("TotalScore");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MatixGameServiceReference.IMatixService", CallbackContract=typeof(MatixGameClient.MatixGameServiceReference.IMatixServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMatixService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/UserRegistration", ReplyAction="http://tempuri.org/IMatixService/UserRegistrationResponse")]
        MatixGameClient.MatixGameServiceReference.RegistrationResult UserRegistration(MatixGameClient.MatixGameServiceReference.UserInformationData userData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/UserRegistration", ReplyAction="http://tempuri.org/IMatixService/UserRegistrationResponse")]
        System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.RegistrationResult> UserRegistrationAsync(MatixGameClient.MatixGameServiceReference.UserInformationData userData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/UserLogin", ReplyAction="http://tempuri.org/IMatixService/UserLoginResponse")]
        MatixGameClient.MatixGameServiceReference.LoginResult UserLogin(MatixGameClient.MatixGameServiceReference.LoginData loginData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/UserLogin", ReplyAction="http://tempuri.org/IMatixService/UserLoginResponse")]
        System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.LoginResult> UserLoginAsync(MatixGameClient.MatixGameServiceReference.LoginData loginData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/GetWaitingPlayers", ReplyAction="http://tempuri.org/IMatixService/GetWaitingPlayersResponse")]
        MatixGameClient.MatixGameServiceReference.WaitingPlayerResult GetWaitingPlayers(string excludedEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/GetWaitingPlayers", ReplyAction="http://tempuri.org/IMatixService/GetWaitingPlayersResponse")]
        System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.WaitingPlayerResult> GetWaitingPlayersAsync(string excludedEmail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/SelectPlayer", ReplyAction="http://tempuri.org/IMatixService/SelectPlayerResponse")]
        MatixGameClient.MatixGameServiceReference.OperationStatus SelectPlayer(string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/SelectPlayer", ReplyAction="http://tempuri.org/IMatixService/SelectPlayerResponse")]
        System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.OperationStatus> SelectPlayerAsync(string nickName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/SetGameAction", ReplyAction="http://tempuri.org/IMatixService/SetGameActionResponse")]
        MatixGameClient.MatixGameServiceReference.OperationStatus SetGameAction(string email, int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatixService/SetGameAction", ReplyAction="http://tempuri.org/IMatixService/SetGameActionResponse")]
        System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.OperationStatus> SetGameActionAsync(string email, int row, int col);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatixServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMatixService/Ping")]
        void Ping(int value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMatixService/UpdateWaitingPlayr")]
        void UpdateWaitingPlayr(MatixGameClient.MatixGameServiceReference.WaitingPlayerResult waitingPlayers);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMatixService/UpdateGameAction")]
        void UpdateGameAction(int row, int col);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatixServiceChannel : MatixGameClient.MatixGameServiceReference.IMatixService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatixServiceClient : System.ServiceModel.DuplexClientBase<MatixGameClient.MatixGameServiceReference.IMatixService>, MatixGameClient.MatixGameServiceReference.IMatixService {
        
        public MatixServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MatixServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MatixServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MatixServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MatixServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public MatixGameClient.MatixGameServiceReference.RegistrationResult UserRegistration(MatixGameClient.MatixGameServiceReference.UserInformationData userData) {
            return base.Channel.UserRegistration(userData);
        }
        
        public System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.RegistrationResult> UserRegistrationAsync(MatixGameClient.MatixGameServiceReference.UserInformationData userData) {
            return base.Channel.UserRegistrationAsync(userData);
        }
        
        public MatixGameClient.MatixGameServiceReference.LoginResult UserLogin(MatixGameClient.MatixGameServiceReference.LoginData loginData) {
            return base.Channel.UserLogin(loginData);
        }
        
        public System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.LoginResult> UserLoginAsync(MatixGameClient.MatixGameServiceReference.LoginData loginData) {
            return base.Channel.UserLoginAsync(loginData);
        }
        
        public MatixGameClient.MatixGameServiceReference.WaitingPlayerResult GetWaitingPlayers(string excludedEmail) {
            return base.Channel.GetWaitingPlayers(excludedEmail);
        }
        
        public System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.WaitingPlayerResult> GetWaitingPlayersAsync(string excludedEmail) {
            return base.Channel.GetWaitingPlayersAsync(excludedEmail);
        }
        
        public MatixGameClient.MatixGameServiceReference.OperationStatus SelectPlayer(string nickName) {
            return base.Channel.SelectPlayer(nickName);
        }
        
        public System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.OperationStatus> SelectPlayerAsync(string nickName) {
            return base.Channel.SelectPlayerAsync(nickName);
        }
        
        public MatixGameClient.MatixGameServiceReference.OperationStatus SetGameAction(string email, int row, int col) {
            return base.Channel.SetGameAction(email, row, col);
        }
        
        public System.Threading.Tasks.Task<MatixGameClient.MatixGameServiceReference.OperationStatus> SetGameActionAsync(string email, int row, int col) {
            return base.Channel.SetGameActionAsync(email, row, col);
        }
    }
}
