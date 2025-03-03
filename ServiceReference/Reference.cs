
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://diagraph.com/services", ConfigurationName="IDiagraphWebService")]
public interface IDiagraphWebService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SearchPrinters", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SearchPrintersResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> SearchPrintersAsync(string printerType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetVersion", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetVersionResponse")]
    System.Threading.Tasks.Task<string> GetVersionAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetLogfile", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetLogfileResponse")]
    System.Threading.Tasks.Task<string[]> GetLogfileAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPrinterIDs", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPrinterIDsResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetPrinterIDsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Connect", ReplyAction="http://diagraph.com/services/IDiagraphWebService/ConnectResponse")]
    System.Threading.Tasks.Task<bool> ConnectAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetConnection", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetConnectionResponse")]
    System.Threading.Tasks.Task<string> GetConnectionAsync(string printerType, string connectionString);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Disconnect", ReplyAction="http://diagraph.com/services/IDiagraphWebService/DisconnectResponse")]
    System.Threading.Tasks.Task<bool> DisconnectAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Lock", ReplyAction="http://diagraph.com/services/IDiagraphWebService/LockResponse")]
    System.Threading.Tasks.Task<bool> LockAsync(string printerId, string disconnect);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Unlock", ReplyAction="http://diagraph.com/services/IDiagraphWebService/UnlockResponse")]
    System.Threading.Tasks.Task<bool> UnlockAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPrinterInfo", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPrinterInfoResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetPrinterInfoAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetConnectionStatus", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetConnectionStatusResponse")]
    System.Threading.Tasks.Task<bool> GetConnectionStatusAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/TriggerPrint", ReplyAction="http://diagraph.com/services/IDiagraphWebService/TriggerPrintResponse")]
    System.Threading.Tasks.Task<bool> TriggerPrintAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/ResetError", ReplyAction="http://diagraph.com/services/IDiagraphWebService/ResetErrorResponse")]
    System.Threading.Tasks.Task<bool> ResetErrorAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Reboot", ReplyAction="http://diagraph.com/services/IDiagraphWebService/RebootResponse")]
    System.Threading.Tasks.Task<bool> RebootAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPrinterLogfile", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPrinterLogfileResponse")]
    System.Threading.Tasks.Task<string[]> GetPrinterLogfileAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/ClearAllLogfiles", ReplyAction="http://diagraph.com/services/IDiagraphWebService/ClearAllLogfilesResponse")]
    System.Threading.Tasks.Task<bool> ClearAllLogfilesAsync(string authKey);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/Stop", ReplyAction="http://diagraph.com/services/IDiagraphWebService/StopResponse")]
    System.Threading.Tasks.Task<bool> StopAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetErrorStatus", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetErrorStatusResponse")]
    System.Threading.Tasks.Task<string> GetErrorStatusAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetErrorDetails", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetErrorDetailsResponse")]
    System.Threading.Tasks.Task<string[]> GetErrorDetailsAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPrintCounter", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPrintCounterResponse")]
    System.Threading.Tasks.Task<long> GetPrintCounterAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetFormatNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetFormatNamesResponse")]
    System.Threading.Tasks.Task<string[]> GetFormatNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetFontNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetFontNamesResponse")]
    System.Threading.Tasks.Task<string[]> GetFontNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetFormat", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetFormatResponse")]
    System.Threading.Tasks.Task<string> GetFormatAsync(string printerId, string formatName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetFormat", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetFormatResponse")]
    System.Threading.Tasks.Task<bool> SetFormatAsync(string printerId, string formatName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/RenameFormat", ReplyAction="http://diagraph.com/services/IDiagraphWebService/RenameFormatResponse")]
    System.Threading.Tasks.Task<bool> RenameFormatAsync(string printerId, string oldFormatName, string newFormatName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/PrintFormat", ReplyAction="http://diagraph.com/services/IDiagraphWebService/PrintFormatResponse")]
    System.Threading.Tasks.Task<bool> PrintFormatAsync(string printerId, string formatName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPropertyNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPropertyNamesResponse")]
    System.Threading.Tasks.Task<string[]> GetPropertyNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetPropertyAttribute", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPropertyAttributeResponse")]
    System.Threading.Tasks.Task<string> GetPropertyAttributeAsync(string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetProperty", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetPropertyResponse")]
    System.Threading.Tasks.Task<string> GetPropertyAsync(string printerId, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetAllProperties", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetAllPropertiesResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllPropertiesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetProperty", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetPropertyResponse")]
    System.Threading.Tasks.Task<bool> SetPropertyAsync(string printerId, string propertyName, string propertyValue);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativePropertyNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativePropertyNamesResponse")]
    System.Threading.Tasks.Task<string[]> GetNativePropertyNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativePropertyAttributes", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativePropertyAttributesRespo" +
        "nse")]
    System.Threading.Tasks.Task<string> GetNativePropertyAttributesAsync(string printerId, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativeProperty", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativePropertyResponse")]
    System.Threading.Tasks.Task<string> GetNativePropertyAsync(string printerId, string propertyName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetAllNativeProperties", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetAllNativePropertiesResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllNativePropertiesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetNativeProperty", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetNativePropertyResponse")]
    System.Threading.Tasks.Task<bool> SetNativePropertyAsync(string printerId, string propertyName, string propertyValue);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfoNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfoNamesResponse" +
        "")]
    System.Threading.Tasks.Task<string[]> GetNativeDeviceInfoNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfoAttributes", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfoAttributesRes" +
        "ponse")]
    System.Threading.Tasks.Task<string> GetNativeDeviceInfoAttributesAsync(string printerId, string deviceInfoName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfo", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetNativeDeviceInfoResponse")]
    System.Threading.Tasks.Task<string> GetNativeDeviceInfoAsync(string printerId, string deviceInfoName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetAllNativeDeviceInfos", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetAllNativeDeviceInfosResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllNativeDeviceInfosAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetVariableNames", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetVariableNamesResponse")]
    System.Threading.Tasks.Task<string[]> GetVariableNamesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetVariable", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetVariableResponse")]
    System.Threading.Tasks.Task<string> GetVariableAsync(string printerId, string variableName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/GetVariables", ReplyAction="http://diagraph.com/services/IDiagraphWebService/GetVariablesResponse")]
    System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetVariablesAsync(string printerId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetVariable", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetVariableResponse")]
    System.Threading.Tasks.Task<bool> SetVariableAsync(string printerId, string variableName, string variableValue);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetPropertyValue", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetPropertyValueResponse")]
    System.Threading.Tasks.Task<SetPropertyValueResponse> SetPropertyValueAsync(SetPropertyValueRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetNativePropertyValue", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetNativePropertyValueResponse")]
    System.Threading.Tasks.Task<SetNativePropertyValueResponse> SetNativePropertyValueAsync(SetNativePropertyValueRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetVariables", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetVariablesResponse")]
    System.Threading.Tasks.Task<SetVariablesResponse> SetVariablesAsync(SetVariablesRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SetVariableValue", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SetVariableValueResponse")]
    System.Threading.Tasks.Task<SetVariableValueResponse> SetVariableValueAsync(SetVariableValueRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://diagraph.com/services/IDiagraphWebService/SendFormat", ReplyAction="http://diagraph.com/services/IDiagraphWebService/SendFormatResponse")]
    System.Threading.Tasks.Task<SendFormatResponse> SendFormatAsync(SendFormatRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetPropertyValueRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPropertyValue", Namespace="http://diagraph.com/services", Order=0)]
    public SetPropertyValueRequestBody Body;
    
    public SetPropertyValueRequest()
    {
    }
    
    public SetPropertyValueRequest(SetPropertyValueRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetPropertyValueRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string printerId;
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
    public string propertyName;
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public byte[] StreamBody;
    
    public SetPropertyValueRequestBody()
    {
    }
    
    public SetPropertyValueRequestBody(string printerId, string propertyName, byte[] StreamBody)
    {
        this.printerId = printerId;
        this.propertyName = propertyName;
        this.StreamBody = StreamBody;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetPropertyValueResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetPropertyValueResponse", Namespace="http://diagraph.com/services", Order=0)]
    public SetPropertyValueResponseBody Body;
    
    public SetPropertyValueResponse()
    {
    }
    
    public SetPropertyValueResponse(SetPropertyValueResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetPropertyValueResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public bool SetPropertyValueResult;
    
    public SetPropertyValueResponseBody()
    {
    }
    
    public SetPropertyValueResponseBody(bool SetPropertyValueResult)
    {
        this.SetPropertyValueResult = SetPropertyValueResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetNativePropertyValueRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetNativePropertyValue", Namespace="http://diagraph.com/services", Order=0)]
    public SetNativePropertyValueRequestBody Body;
    
    public SetNativePropertyValueRequest()
    {
    }
    
    public SetNativePropertyValueRequest(SetNativePropertyValueRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetNativePropertyValueRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string printerId;
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
    public string propertyName;
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public byte[] StreamBody;
    
    public SetNativePropertyValueRequestBody()
    {
    }
    
    public SetNativePropertyValueRequestBody(string printerId, string propertyName, byte[] StreamBody)
    {
        this.printerId = printerId;
        this.propertyName = propertyName;
        this.StreamBody = StreamBody;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetNativePropertyValueResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetNativePropertyValueResponse", Namespace="http://diagraph.com/services", Order=0)]
    public SetNativePropertyValueResponseBody Body;
    
    public SetNativePropertyValueResponse()
    {
    }
    
    public SetNativePropertyValueResponse(SetNativePropertyValueResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetNativePropertyValueResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public bool SetNativePropertyValueResult;
    
    public SetNativePropertyValueResponseBody()
    {
    }
    
    public SetNativePropertyValueResponseBody(bool SetNativePropertyValueResult)
    {
        this.SetNativePropertyValueResult = SetNativePropertyValueResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetVariablesRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetVariables", Namespace="http://diagraph.com/services", Order=0)]
    public SetVariablesRequestBody Body;
    
    public SetVariablesRequest()
    {
    }
    
    public SetVariablesRequest(SetVariablesRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetVariablesRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string printerId;
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
    public byte[] StreamBody;
    
    public SetVariablesRequestBody()
    {
    }
    
    public SetVariablesRequestBody(string printerId, byte[] StreamBody)
    {
        this.printerId = printerId;
        this.StreamBody = StreamBody;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetVariablesResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetVariablesResponse", Namespace="http://diagraph.com/services", Order=0)]
    public SetVariablesResponseBody Body;
    
    public SetVariablesResponse()
    {
    }
    
    public SetVariablesResponse(SetVariablesResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetVariablesResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public bool SetVariablesResult;
    
    public SetVariablesResponseBody()
    {
    }
    
    public SetVariablesResponseBody(bool SetVariablesResult)
    {
        this.SetVariablesResult = SetVariablesResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetVariableValueRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetVariableValue", Namespace="http://diagraph.com/services", Order=0)]
    public SetVariableValueRequestBody Body;
    
    public SetVariableValueRequest()
    {
    }
    
    public SetVariableValueRequest(SetVariableValueRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetVariableValueRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string printerId;
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
    public string variableName;
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public byte[] StreamBody;
    
    public SetVariableValueRequestBody()
    {
    }
    
    public SetVariableValueRequestBody(string printerId, string variableName, byte[] StreamBody)
    {
        this.printerId = printerId;
        this.variableName = variableName;
        this.StreamBody = StreamBody;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SetVariableValueResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SetVariableValueResponse", Namespace="http://diagraph.com/services", Order=0)]
    public SetVariableValueResponseBody Body;
    
    public SetVariableValueResponse()
    {
    }
    
    public SetVariableValueResponse(SetVariableValueResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SetVariableValueResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public bool SetVariableValueResult;
    
    public SetVariableValueResponseBody()
    {
    }
    
    public SetVariableValueResponseBody(bool SetVariableValueResult)
    {
        this.SetVariableValueResult = SetVariableValueResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SendFormatRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SendFormat", Namespace="http://diagraph.com/services", Order=0)]
    public SendFormatRequestBody Body;
    
    public SendFormatRequest()
    {
    }
    
    public SendFormatRequest(SendFormatRequestBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SendFormatRequestBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public string printerId;
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
    public string formatName;
    
    [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
    public byte[] StreamBody;
    
    public SendFormatRequestBody()
    {
    }
    
    public SendFormatRequestBody(string printerId, string formatName, byte[] StreamBody)
    {
        this.printerId = printerId;
        this.formatName = formatName;
        this.StreamBody = StreamBody;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class SendFormatResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="SendFormatResponse", Namespace="http://diagraph.com/services", Order=0)]
    public SendFormatResponseBody Body;
    
    public SendFormatResponse()
    {
    }
    
    public SendFormatResponse(SendFormatResponseBody Body)
    {
        this.Body = Body;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.Runtime.Serialization.DataContractAttribute(Namespace="http://diagraph.com/services")]
public partial class SendFormatResponseBody
{
    
    [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
    public bool SendFormatResult;
    
    public SendFormatResponseBody()
    {
    }
    
    public SendFormatResponseBody(bool SendFormatResult)
    {
        this.SendFormatResult = SendFormatResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
public interface IDiagraphWebServiceChannel : IDiagraphWebService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
public partial class DiagraphWebServiceClient : System.ServiceModel.ClientBase<IDiagraphWebService>, IDiagraphWebService
{
    
    /// <summary>
    /// Implementieren Sie diese partielle Methode, um den Dienstendpunkt zu konfigurieren.
    /// </summary>
    /// <param name="serviceEndpoint">Der zu konfigurierende Endpunkt</param>
    /// <param name="clientCredentials">Die Clientanmeldeinformationen</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public DiagraphWebServiceClient() : 
            base(DiagraphWebServiceClient.GetDefaultBinding(), DiagraphWebServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDiagraphWebService.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public DiagraphWebServiceClient(EndpointConfiguration endpointConfiguration) : 
            base(DiagraphWebServiceClient.GetBindingForEndpoint(endpointConfiguration), DiagraphWebServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public DiagraphWebServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
            base(DiagraphWebServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public DiagraphWebServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(DiagraphWebServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public DiagraphWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> SearchPrintersAsync(string printerType)
    {
        return base.Channel.SearchPrintersAsync(printerType);
    }
    
    public System.Threading.Tasks.Task<string> GetVersionAsync()
    {
        return base.Channel.GetVersionAsync();
    }
    
    public System.Threading.Tasks.Task<string[]> GetLogfileAsync()
    {
        return base.Channel.GetLogfileAsync();
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetPrinterIDsAsync()
    {
        return base.Channel.GetPrinterIDsAsync();
    }
    
    public System.Threading.Tasks.Task<bool> ConnectAsync(string printerId)
    {
        return base.Channel.ConnectAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetConnectionAsync(string printerType, string connectionString)
    {
        return base.Channel.GetConnectionAsync(printerType, connectionString);
    }
    
    public System.Threading.Tasks.Task<bool> DisconnectAsync(string printerId)
    {
        return base.Channel.DisconnectAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> LockAsync(string printerId, string disconnect)
    {
        return base.Channel.LockAsync(printerId, disconnect);
    }
    
    public System.Threading.Tasks.Task<bool> UnlockAsync(string printerId)
    {
        return base.Channel.UnlockAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetPrinterInfoAsync(string printerId)
    {
        return base.Channel.GetPrinterInfoAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> GetConnectionStatusAsync(string printerId)
    {
        return base.Channel.GetConnectionStatusAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> TriggerPrintAsync(string printerId)
    {
        return base.Channel.TriggerPrintAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> ResetErrorAsync(string printerId)
    {
        return base.Channel.ResetErrorAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> RebootAsync(string printerId)
    {
        return base.Channel.RebootAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string[]> GetPrinterLogfileAsync(string printerId)
    {
        return base.Channel.GetPrinterLogfileAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> ClearAllLogfilesAsync(string authKey)
    {
        return base.Channel.ClearAllLogfilesAsync(authKey);
    }
    
    public System.Threading.Tasks.Task<bool> StopAsync(string printerId)
    {
        return base.Channel.StopAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetErrorStatusAsync(string printerId)
    {
        return base.Channel.GetErrorStatusAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string[]> GetErrorDetailsAsync(string printerId)
    {
        return base.Channel.GetErrorDetailsAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<long> GetPrintCounterAsync(string printerId)
    {
        return base.Channel.GetPrintCounterAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string[]> GetFormatNamesAsync(string printerId)
    {
        return base.Channel.GetFormatNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string[]> GetFontNamesAsync(string printerId)
    {
        return base.Channel.GetFontNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetFormatAsync(string printerId, string formatName)
    {
        return base.Channel.GetFormatAsync(printerId, formatName);
    }
    
    public System.Threading.Tasks.Task<bool> SetFormatAsync(string printerId, string formatName)
    {
        return base.Channel.SetFormatAsync(printerId, formatName);
    }
    
    public System.Threading.Tasks.Task<bool> RenameFormatAsync(string printerId, string oldFormatName, string newFormatName)
    {
        return base.Channel.RenameFormatAsync(printerId, oldFormatName, newFormatName);
    }
    
    public System.Threading.Tasks.Task<bool> PrintFormatAsync(string printerId, string formatName)
    {
        return base.Channel.PrintFormatAsync(printerId, formatName);
    }
    
    public System.Threading.Tasks.Task<string[]> GetPropertyNamesAsync(string printerId)
    {
        return base.Channel.GetPropertyNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetPropertyAttributeAsync(string propertyName)
    {
        return base.Channel.GetPropertyAttributeAsync(propertyName);
    }
    
    public System.Threading.Tasks.Task<string> GetPropertyAsync(string printerId, string propertyName)
    {
        return base.Channel.GetPropertyAsync(printerId, propertyName);
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllPropertiesAsync(string printerId)
    {
        return base.Channel.GetAllPropertiesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> SetPropertyAsync(string printerId, string propertyName, string propertyValue)
    {
        return base.Channel.SetPropertyAsync(printerId, propertyName, propertyValue);
    }
    
    public System.Threading.Tasks.Task<string[]> GetNativePropertyNamesAsync(string printerId)
    {
        return base.Channel.GetNativePropertyNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetNativePropertyAttributesAsync(string printerId, string propertyName)
    {
        return base.Channel.GetNativePropertyAttributesAsync(printerId, propertyName);
    }
    
    public System.Threading.Tasks.Task<string> GetNativePropertyAsync(string printerId, string propertyName)
    {
        return base.Channel.GetNativePropertyAsync(printerId, propertyName);
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllNativePropertiesAsync(string printerId)
    {
        return base.Channel.GetAllNativePropertiesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> SetNativePropertyAsync(string printerId, string propertyName, string propertyValue)
    {
        return base.Channel.SetNativePropertyAsync(printerId, propertyName, propertyValue);
    }
    
    public System.Threading.Tasks.Task<string[]> GetNativeDeviceInfoNamesAsync(string printerId)
    {
        return base.Channel.GetNativeDeviceInfoNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetNativeDeviceInfoAttributesAsync(string printerId, string deviceInfoName)
    {
        return base.Channel.GetNativeDeviceInfoAttributesAsync(printerId, deviceInfoName);
    }
    
    public System.Threading.Tasks.Task<string> GetNativeDeviceInfoAsync(string printerId, string deviceInfoName)
    {
        return base.Channel.GetNativeDeviceInfoAsync(printerId, deviceInfoName);
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetAllNativeDeviceInfosAsync(string printerId)
    {
        return base.Channel.GetAllNativeDeviceInfosAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string[]> GetVariableNamesAsync(string printerId)
    {
        return base.Channel.GetVariableNamesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<string> GetVariableAsync(string printerId, string variableName)
    {
        return base.Channel.GetVariableAsync(printerId, variableName);
    }
    
    public System.Threading.Tasks.Task<KeyValuePair<string, string>[]> GetVariablesAsync(string printerId)
    {
        return base.Channel.GetVariablesAsync(printerId);
    }
    
    public System.Threading.Tasks.Task<bool> SetVariableAsync(string printerId, string variableName, string variableValue)
    {
        return base.Channel.SetVariableAsync(printerId, variableName, variableValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetPropertyValueResponse> IDiagraphWebService.SetPropertyValueAsync(SetPropertyValueRequest request)
    {
        return base.Channel.SetPropertyValueAsync(request);
    }
    
    public System.Threading.Tasks.Task<SetPropertyValueResponse> SetPropertyValueAsync(string printerId, string propertyName, byte[] StreamBody)
    {
        SetPropertyValueRequest inValue = new SetPropertyValueRequest();
        inValue.Body = new SetPropertyValueRequestBody();
        inValue.Body.printerId = printerId;
        inValue.Body.propertyName = propertyName;
        inValue.Body.StreamBody = StreamBody;
        return ((IDiagraphWebService)(this)).SetPropertyValueAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetNativePropertyValueResponse> IDiagraphWebService.SetNativePropertyValueAsync(SetNativePropertyValueRequest request)
    {
        return base.Channel.SetNativePropertyValueAsync(request);
    }
    
    public System.Threading.Tasks.Task<SetNativePropertyValueResponse> SetNativePropertyValueAsync(string printerId, string propertyName, byte[] StreamBody)
    {
        SetNativePropertyValueRequest inValue = new SetNativePropertyValueRequest();
        inValue.Body = new SetNativePropertyValueRequestBody();
        inValue.Body.printerId = printerId;
        inValue.Body.propertyName = propertyName;
        inValue.Body.StreamBody = StreamBody;
        return ((IDiagraphWebService)(this)).SetNativePropertyValueAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetVariablesResponse> IDiagraphWebService.SetVariablesAsync(SetVariablesRequest request)
    {
        return base.Channel.SetVariablesAsync(request);
    }
    
    public System.Threading.Tasks.Task<SetVariablesResponse> SetVariablesAsync(string printerId, byte[] StreamBody)
    {
        SetVariablesRequest inValue = new SetVariablesRequest();
        inValue.Body = new SetVariablesRequestBody();
        inValue.Body.printerId = printerId;
        inValue.Body.StreamBody = StreamBody;
        return ((IDiagraphWebService)(this)).SetVariablesAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SetVariableValueResponse> IDiagraphWebService.SetVariableValueAsync(SetVariableValueRequest request)
    {
        return base.Channel.SetVariableValueAsync(request);
    }
    
    public System.Threading.Tasks.Task<SetVariableValueResponse> SetVariableValueAsync(string printerId, string variableName, byte[] StreamBody)
    {
        SetVariableValueRequest inValue = new SetVariableValueRequest();
        inValue.Body = new SetVariableValueRequestBody();
        inValue.Body.printerId = printerId;
        inValue.Body.variableName = variableName;
        inValue.Body.StreamBody = StreamBody;
        return ((IDiagraphWebService)(this)).SetVariableValueAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<SendFormatResponse> IDiagraphWebService.SendFormatAsync(SendFormatRequest request)
    {
        return base.Channel.SendFormatAsync(request);
    }
    
    public System.Threading.Tasks.Task<SendFormatResponse> SendFormatAsync(string printerId, string formatName, byte[] StreamBody)
    {
        SendFormatRequest inValue = new SendFormatRequest();
        inValue.Body = new SendFormatRequestBody();
        inValue.Body.printerId = printerId;
        inValue.Body.formatName = formatName;
        inValue.Body.StreamBody = StreamBody;
        return ((IDiagraphWebService)(this)).SendFormatAsync(inValue);
    }
    
    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }
    
    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDiagraphWebService))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
    }
    
    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDiagraphWebService))
        {
            return new System.ServiceModel.EndpointAddress(EndpointAddress);
        }
        throw new System.InvalidOperationException(string.Format("Es wurde kein Endpunkt mit dem Namen \"{0}\" gefunden.", endpointConfiguration));
    }
    
    public static string EndpointAddress { get; set; }
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return DiagraphWebServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDiagraphWebService);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return DiagraphWebServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDiagraphWebService);
    }
    
    public enum EndpointConfiguration
    {
        
        BasicHttpBinding_IDiagraphWebService,
    }
}
